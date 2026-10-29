using InventorBridge.ReferenceGenerator.Model;

namespace InventorBridge.ReferenceGenerator.Analysis
{
    /// <summary>
    /// Infers the inheritance that the interop hides and fills in <see cref="MergedType.Ancestors"/>.
    /// </summary>
    /// <remarks>
    /// COM flattens inheritance: in the interop, PartDocument does not inherit from Document, but the
    /// PartDocument vtable starts with the whole Document vtable. That prefix alone is not enough, because
    /// older types copied a shorter version of their base's vtable (TrimFeature would look like a "base"
    /// of ExtrudeFeature). So:
    /// 1. Types listed in inheritance.txt (extracted from the Autodesk posters) use the declared base;
    ///    the vtable only breaks ties when the legend is ambiguous.
    /// 2. Types that are known bases do not get a base by inference.
    /// 3. All others (proxies, new types) use the longest vtable prefix, as long as it is not too short.
    /// </remarks>
    public static class InheritanceResolver
    {
        // Prefixes shorter than this (Type, Application, Parent...) are shared by almost every object.
        private const int MinimumFallbackVTableLength = 12;

        public static void Resolve(MergedApi api, IReadOnlyDictionary<string, string[]> declaredBases)
        {
            var objects = api.VisibleObjectsByName;
            var knownBaseNames = declaredBases.Values.SelectMany(names => names).ToHashSet();

            var parentByName = new Dictionary<string, string>();
            foreach (var type in objects.Values)
            {
                var parentName = FindParent(type, objects, declaredBases, knownBaseNames);
                if (parentName is not null)
                {
                    parentByName[type.Name] = parentName;
                }
            }

            foreach (var type in objects.Values)
            {
                AddAncestorChain(type, parentByName);
            }
        }

        private static string? FindParent(
            MergedType type,
            IReadOnlyDictionary<string, MergedType> objects,
            IReadOnlyDictionary<string, string[]> declaredBases,
            HashSet<string> knownBaseNames)
        {
            if (declaredBases.TryGetValue(type.Name, out var candidateNames))
            {
                return ChooseDeclaredParent(type, candidateNames, objects);
            }

            if (knownBaseNames.Contains(type.Name))
            {
                return null;
            }

            return objects.Values
                .Where(candidate => candidate != type
                    && candidate.VTable.Count >= MinimumFallbackVTableLength
                    && IsVTablePrefix(candidate, type))
                .MaxBy(candidate => candidate.VTable.Count)?
                .Name;
        }

        /// <summary>
        /// Among the declared bases, prefers the one confirmed by the vtable; then the one whose members are
        /// all present in the type; and, if there is a single candidate, trusts the poster even without
        /// confirmation.
        /// </summary>
        private static string? ChooseDeclaredParent(MergedType type, string[] candidateNames, IReadOnlyDictionary<string, MergedType> objects)
        {
            var candidates = candidateNames
                .Where(objects.ContainsKey)
                .Select(name => objects[name])
                .ToList();

            var byVTable = candidates.FirstOrDefault(candidate => IsVTablePrefix(candidate, type));
            if (byVTable is not null)
            {
                return byVTable.Name;
            }

            var byMembers = candidates.FirstOrDefault(candidate => candidate.VisibleMembers.All(member => type.Members.ContainsKey(member.Key)));
            if (byMembers is not null)
            {
                return byMembers.Name;
            }

            return candidates.Count == 1 ? candidates[0].Name : null;
        }

        /// <summary>Follows parent, grandparent... up to the root, guarding against cycles.</summary>
        private static void AddAncestorChain(MergedType type, Dictionary<string, string> parentByName)
        {
            var ancestorName = parentByName.GetValueOrDefault(type.Name);

            while (ancestorName is not null && ancestorName != type.Name && !type.Ancestors.Contains(ancestorName))
            {
                type.Ancestors.Add(ancestorName);
                ancestorName = parentByName.GetValueOrDefault(ancestorName);
            }
        }

        /// <summary>True if the vtable of <paramref name="derived"/> starts with the whole vtable of <paramref name="candidateBase"/>.</summary>
        private static bool IsVTablePrefix(MergedType candidateBase, MergedType derived)
        {
            if (candidateBase.VTable.Count >= derived.VTable.Count)
            {
                return false;
            }

            return derived.VTable.Take(candidateBase.VTable.Count).SequenceEqual(candidateBase.VTable);
        }
    }
}
