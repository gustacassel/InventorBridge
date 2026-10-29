namespace InventorBridge.Mcp.Reference
{
    /// <summary>One line of members.tsv: a property, method, event or enum value of an API type.</summary>
    public sealed class ReferenceMember
    {
        public required string TypeName { get; init; }

        public required string Name { get; init; }

        /// <summary>property, method, event or enum-value.</summary>
        public required string Kind { get; init; }

        /// <summary>The member in pseudo-C#, as on the reference pages.</summary>
        public required string Signature { get; init; }

        /// <summary>The versions it exists in, as written in the reference: "2024+" or "2025, 2026, 2027".</summary>
        public required string Versions { get; init; }
    }
}
