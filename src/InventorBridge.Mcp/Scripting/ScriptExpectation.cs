using System.ComponentModel;
using System.Text.Json.Serialization;

namespace InventorBridge.Mcp.Scripting
{
    /// <summary>
    /// Values the agent expects the active document to have after a run_csharp script. Every value is optional;
    /// only the ones given are checked.
    /// </summary>
    public sealed class ScriptExpectation
    {
        [JsonPropertyName("volumeMm3")]
        [Description("Volume of the part or assembly, in mm3.")]
        public double? VolumeMm3 { get; set; }

        [JsonPropertyName("sizeMm")]
        [Description("Size of the bounding box along X, Y and Z, in mm: [x, y, z].")]
        public double[]? SizeMm { get; set; }

        [JsonPropertyName("bodies")]
        [Description("Number of solid bodies of a part.")]
        public int? Bodies { get; set; }

        [JsonPropertyName("occurrences")]
        [Description("Number of top-level occurrences of an assembly.")]
        public int? Occurrences { get; set; }

        [JsonPropertyName("freeDegreesOfFreedom")]
        [Description("Free translations plus free rotations left, summed over the occurrences that are not grounded. 0 means fully constrained.")]
        public int? FreeDegreesOfFreedom { get; set; }

        [JsonPropertyName("tolerance")]
        [Description("Relative tolerance for volume and size. Default 0.002 (0.2%); sizes also accept 0.05 mm.")]
        public double? Tolerance { get; set; }

        public bool IsEmpty =>
            VolumeMm3 is null && SizeMm is null && Bodies is null && Occurrences is null && FreeDegreesOfFreedom is null;
    }
}
