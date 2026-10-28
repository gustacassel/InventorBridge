using DocGen.Model;

namespace DocGen.Analysis
{
    /// <summary>
    /// Builds the reverse indexes: which members return each object (<see cref="MergedType.ReturnedBy"/>)
    /// and which members use each enum (<see cref="MergedType.UsedBy"/>).
    /// </summary>
    public static class ReferenceIndexer
    {
        public static void Index(MergedApi api)
        {
            foreach (var owner in api.VisibleObjectsByName.Values)
            {
                foreach (var member in owner.VisibleMembers)
                {
                    var reference = $"{owner.Name}.{member.Name}";

                    if (member.Kind != ApiMemberKind.Event)
                    {
                        IndexReturnType(api, member, reference);
                    }

                    IndexParameterEnums(api, member, reference);
                }
            }
        }

        private static void IndexReturnType(MergedApi api, MergedMember member, string reference)
        {
            var returnTypeName = TypeNames.WithoutArray(member.Latest.ReturnType);
            if (!api.Types.TryGetValue(returnTypeName, out var returnType))
            {
                return;
            }

            if (returnType.Kind == ApiTypeKind.Object)
            {
                returnType.ReturnedBy.Add(reference);
            }
            else
            {
                returnType.UsedBy.Add(reference);
            }
        }

        private static void IndexParameterEnums(MergedApi api, MergedMember member, string reference)
        {
            foreach (var parameter in member.Latest.Parameters)
            {
                var parameterTypeName = TypeNames.WithoutArray(parameter.Type);
                if (!api.Types.TryGetValue(parameterTypeName, out var parameterType) || parameterType.Kind != ApiTypeKind.Enum)
                {
                    continue;
                }

                if (!parameterType.UsedBy.Contains(reference))
                {
                    parameterType.UsedBy.Add(reference);
                }
            }
        }
    }
}
