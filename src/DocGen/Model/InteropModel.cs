using System.Text.Json.Serialization;

namespace DocGen.Model
{
    // Model of ONE API version, as read from one interop DLL.

    public enum ApiTypeKind
    {
        Object,
        Enum,
    }

    public enum ApiMemberKind
    {
        Property,
        Method,
        Event,
    }

    public enum ParameterDirection
    {
        In,
        Ref,
        Out,
    }

    /// <summary>Parameter of a method, an event or an indexed property.</summary>
    public sealed class ApiParameter
    {
        public required string Name { get; init; }
        public required string Type { get; init; }
        public ParameterDirection Direction { get; init; }
        public bool IsOptional { get; init; }

        /// <summary>
        /// Default value already formatted ("true", "PartFeatureExtentDirectionEnum.kPositiveExtentDirection"...).
        /// Null when the parameter is optional without a value, meaning it can be omitted (COM Missing).
        /// </summary>
        public string? DefaultValue { get; init; }
    }

    public sealed class ApiMember
    {
        public required string Name { get; init; }
        public required ApiMemberKind Kind { get; init; }

        /// <summary>Property type or method return type. Events use "void".</summary>
        public required string ReturnType { get; init; }

        public bool CanRead { get; init; }
        public bool CanWrite { get; init; }

        /// <summary>Marked hidden or restricted in the type library: obsolete or internal, must not be used.</summary>
        public bool IsHidden { get; init; }

        /// <summary>Parameters of the method or event, or indexes of the indexed property.</summary>
        public required IReadOnlyList<ApiParameter> Parameters { get; init; }

        /// <summary>Identifies the member within its type. A property and a method can share a name.</summary>
        [JsonIgnore]
        public string Key => $"{Kind}:{Name}";
    }

    public sealed class ApiEnumValue
    {
        public required string Name { get; init; }
        public long Value { get; init; }
    }

    public sealed class ApiType
    {
        public required string Name { get; init; }
        public required ApiTypeKind Kind { get; init; }
        public bool IsHidden { get; init; }

        /// <summary>Members of objects. Empty for enums.</summary>
        public IReadOnlyList<ApiMember> Members { get; init; } = [];

        /// <summary>Values of enums. Empty for objects.</summary>
        public IReadOnlyList<ApiEnumValue> EnumValues { get; init; } = [];

        /// <summary>
        /// Names of the declared methods (including get_/set_) in COM vtable order.
        /// Used to infer inheritance, which the interop does not show.
        /// </summary>
        public IReadOnlyList<string> VTable { get; init; } = [];
    }

    public sealed class ApiVersion
    {
        /// <summary>Name of the version folder, e.g. "2024".</summary>
        public required string Version { get; init; }

        /// <summary>Version of the interop assembly, e.g. "28.3.0.0".</summary>
        public required string AssemblyVersion { get; init; }

        public required IReadOnlyDictionary<string, ApiType> Types { get; init; }
    }
}
