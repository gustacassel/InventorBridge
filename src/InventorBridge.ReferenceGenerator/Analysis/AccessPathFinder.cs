using InventorBridge.ReferenceGenerator.Model;

namespace InventorBridge.ReferenceGenerator.Analysis
{
    /// <summary>
    /// Computes, for each object, an example path from Application
    /// (e.g. "Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ExtrudeFeatures.Item[…]")
    /// and stores it in <see cref="MergedType.AccessPath"/>.
    /// </summary>
    /// <remarks>
    /// It is a shortest path (Dijkstra) over a graph where each object points to the objects its members
    /// return, plus casts to derived types. The costs make the chosen path look like what a person would
    /// write:
    /// - properties and Item are cheap;
    /// - Create* on TransientGeometry/TransientObjects is medium, since it is the normal way to get
    ///   points, vectors and collections;
    /// - other methods are expensive, since they usually require an object you do not have yet
    ///   (e.g. TransientBRep.Copy, TransientBRep.CreateSilhouetteCurve);
    /// - Active* properties (except ActiveDocument and ActiveSheet) only have a value during an edit;
    /// - casting to PartDocument/AssemblyDocument/DrawingDocument is cheap (in that order of preference),
    ///   but casting to other derived types is expensive, to prefer typed collections
    ///   (Features.ExtrudeFeatures) over "take any item and cast it".
    /// </remarks>
    public static class AccessPathFinder
    {
        private const string RootTypeName = "Application";

        private const double PropertyCost = 1.0;
        private const double IndexedAccessCost = 0.6;
        private const double CheapCreateCost = 2.0;
        private const double MethodCost = 4.0;
        private const double EditOnlyActiveCost = 3.0;
        private const double PreferredCastCost = 0.5;
        private const double PreferredCastStep = 0.01;
        private const double OtherCastCost = 2.0;

        private static readonly string[] PreferredCastTargets = ["PartDocument", "AssemblyDocument", "DrawingDocument"];
        private static readonly string[] StableActiveProperties = ["ActiveDocument", "ActiveSheet"];
        private static readonly string[] CheapCreatorTypes = ["TransientGeometry", "TransientObjects"];

        private readonly record struct Edge(string TargetName, double Cost, string Label);

        public static void Find(MergedApi api)
        {
            var objects = api.VisibleObjectsByName;
            if (!objects.ContainsKey(RootTypeName))
            {
                return;
            }

            var castTargetsByBase = BuildCastTargets(objects);
            var pathByName = FindShortestPaths(objects, castTargetsByBase);

            foreach (var (typeName, path) in pathByName)
            {
                objects[typeName].AccessPath = path;
            }
        }

        /// <summary>
        /// Possible casts: from each direct base to its derived types. Farther ancestors are reached by
        /// chaining.
        /// </summary>
        private static Dictionary<string, List<string>> BuildCastTargets(IReadOnlyDictionary<string, MergedType> objects)
        {
            var castTargetsByBase = new Dictionary<string, List<string>>();

            foreach (var derived in objects.Values.Where(type => type.Ancestors.Count > 0))
            {
                var directBase = derived.Ancestors[0];
                if (!castTargetsByBase.TryGetValue(directBase, out var targets))
                {
                    targets = [];
                    castTargetsByBase[directBase] = targets;
                }

                targets.Add(derived.Name);
            }

            return castTargetsByBase;
        }

        private static Dictionary<string, string> FindShortestPaths(
            IReadOnlyDictionary<string, MergedType> objects,
            Dictionary<string, List<string>> castTargetsByBase)
        {
            var costByName = new Dictionary<string, double> { [RootTypeName] = 0 };
            var pathByName = new Dictionary<string, string> { [RootTypeName] = RootTypeName };
            var queue = new PriorityQueue<string, double>();
            queue.Enqueue(RootTypeName, 0);

            while (queue.TryDequeue(out var currentName, out var currentCost))
            {
                // Stale queue entry: already reached through a cheaper path.
                if (currentCost > costByName[currentName])
                {
                    continue;
                }

                foreach (var edge in GetEdges(objects, castTargetsByBase, currentName))
                {
                    var newCost = currentCost + edge.Cost;
                    if (costByName.TryGetValue(edge.TargetName, out var knownCost) && knownCost <= newCost)
                    {
                        continue;
                    }

                    costByName[edge.TargetName] = newCost;
                    pathByName[edge.TargetName] = pathByName[currentName] + edge.Label;
                    queue.Enqueue(edge.TargetName, newCost);
                }
            }

            return pathByName;
        }

        private static List<Edge> GetEdges(
            IReadOnlyDictionary<string, MergedType> objects,
            Dictionary<string, List<string>> castTargetsByBase,
            string currentName)
        {
            var edges = new List<Edge>();

            foreach (var member in objects[currentName].VisibleMembers.Where(member => member.Kind != ApiMemberKind.Event))
            {
                if (objects.ContainsKey(member.Latest.ReturnType))
                {
                    edges.Add(CreateMemberEdge(currentName, member));
                }
            }

            foreach (var targetName in castTargetsByBase.GetValueOrDefault(currentName) ?? [])
            {
                edges.Add(CreateCastEdge(targetName));
            }

            return edges;
        }

        private static Edge CreateMemberEdge(string ownerName, MergedMember member)
        {
            var isIndexed = member.Latest.Parameters.Count > 0;
            double cost;
            string label;

            if (member.Kind == ApiMemberKind.Property)
            {
                cost = isIndexed ? IndexedAccessCost : PropertyCost;
                label = isIndexed ? $".{member.Name}[…]" : $".{member.Name}";
            }
            else
            {
                if (member.Name == "Item")
                {
                    cost = IndexedAccessCost;
                }
                else if (member.Name.StartsWith("Create") && CheapCreatorTypes.Contains(ownerName))
                {
                    cost = CheapCreateCost;
                }
                else
                {
                    cost = MethodCost;
                }

                label = $".{member.Name}(…)";
            }

            if (member.Name.StartsWith("Active") && !StableActiveProperties.Contains(member.Name))
            {
                cost = EditOnlyActiveCost;
            }

            return new Edge(member.Latest.ReturnType, cost, label);
        }

        private static Edge CreateCastEdge(string targetName)
        {
            var preference = Array.IndexOf(PreferredCastTargets, targetName);
            var cost = preference >= 0
                ? PreferredCastCost + preference * PreferredCastStep
                : OtherCastCost;

            return new Edge(targetName, cost, $" → ({targetName})");
        }
    }
}
