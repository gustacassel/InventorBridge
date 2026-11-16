using InventorBridge.ReferenceGenerator.Model;

namespace InventorBridge.ReferenceGenerator.Output
{
    /// <summary>
    /// Formats members as pseudo-C# declarations, for example:
    /// <c>ExtrudeFeature AddByDistanceExtent(Profile Profile, object Distance, object TaperAngle = Missing);</c>
    /// </summary>
    public static class SignatureFormatter
    {
        public static string Format(ApiMember member)
        {
            var parameters = FormatParameters(member.Parameters);

            switch (member.Kind)
            {
                // C# rejects a property whose getter and setter types differ: show the accessors it accepts instead.
                case ApiMemberKind.Property when member.SetterType is not null && member.Parameters.Count == 0:
                    return $"{member.ReturnType} get_{member.Name}(); void set_{member.Name}({member.SetterType} value); " +
                        "// not usable as a property in C#";

                case ApiMemberKind.Property when member.SetterType is not null:
                    return $"{member.ReturnType} get_{member.Name}({parameters}); void set_{member.Name}({parameters}, " +
                        $"{member.SetterType} value); // not usable as a property in C#";

                case ApiMemberKind.Property when member.Parameters.Count == 0:
                    return $"{member.ReturnType} {member.Name} {{ {FormatAccessors(member)} }}";

                case ApiMemberKind.Property:
                    return $"{member.ReturnType} {member.Name}[{parameters}] {{ {FormatAccessors(member)} }}";

                case ApiMemberKind.Event:
                    return $"event {member.Name}({parameters});";

                default:
                    return $"{member.ReturnType} {member.Name}({parameters});";
            }
        }

        private static string FormatAccessors(ApiMember member)
        {
            if (member.CanRead && member.CanWrite)
            {
                return "get; set;";
            }

            return member.CanWrite ? "set;" : "get;";
        }

        private static string FormatParameters(IEnumerable<ApiParameter> parameters)
        {
            return string.Join(", ", parameters.Select(FormatParameter));
        }

        /// <summary>"ref double[] Coords", "object TaperAngle = Missing", "bool Visible = true"...</summary>
        private static string FormatParameter(ApiParameter parameter)
        {
            var prefix = parameter.Direction switch
            {
                ParameterDirection.Ref => "ref ",
                ParameterDirection.Out => "out ",
                _ => "",
            };

            var declaration = $"{prefix}{parameter.Type} {parameter.Name}";
            if (!parameter.IsOptional)
            {
                return declaration;
            }

            return $"{declaration} = {parameter.DefaultValue ?? "Missing"}";
        }
    }
}
