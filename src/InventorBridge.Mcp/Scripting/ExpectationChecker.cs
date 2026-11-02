using System.Globalization;
using Inventor;

namespace InventorBridge.Mcp.Scripting
{
    /// <summary>
    /// Measures the active document after a script and compares it with the <see cref="ScriptExpectation"/>
    /// the agent sent, so a wrong result is caught right away instead of in a later screenshot.
    /// </summary>
    public static class ExpectationChecker
    {
        private const double DefaultRelativeTolerance = 0.002;
        private const double SizeToleranceMm = 0.05;
        private const double MillimetersPerCentimeter = 10.0;
        private const double CubicMillimetersPerCubicCentimeter = 1000.0;

        /// <summary>One line per checked value; <paramref name="allMet"/> is false if any value is off.</summary>
        public static List<string> Check(Application application, ScriptExpectation expectation, out bool allMet)
        {
            var lines = new List<string>();
            allMet = true;

            var document = application.ActiveDocument;
            if (document is null)
            {
                lines.Add("no active document to check");
                allMet = false;
                return lines;
            }

            lines.Add($"checked on {document.DisplayName}");
            var tolerance = expectation.Tolerance ?? DefaultRelativeTolerance;

            if (expectation.VolumeMm3 is double volume)
            {
                var measured = ReadVolumeMm3(document);
                allMet &= AddLine(lines, "volumeMm3", volume, measured, Math.Abs(volume) * tolerance);
            }

            if (expectation.SizeMm is { Length: 3 } size)
            {
                var measured = ReadSizeMm(document);
                var axes = new[] { "X", "Y", "Z" };
                for (var axis = 0; axis < 3; axis++)
                {
                    var allowed = Math.Max(SizeToleranceMm, Math.Abs(size[axis]) * tolerance);
                    allMet &= AddLine(lines, $"size {axes[axis]} (mm)", size[axis], measured?[axis], allowed);
                }
            }
            else if (expectation.SizeMm is not null)
            {
                lines.Add("sizeMm: needs three values [x, y, z]; not checked");
                allMet = false;
            }

            if (expectation.Bodies is int bodies)
            {
                allMet &= AddLine(lines, "bodies", bodies, ReadSolidBodies(document), 0);
            }

            if (expectation.Occurrences is int occurrences)
            {
                var measured = (document as AssemblyDocument)?.ComponentDefinition.Occurrences.Count;
                allMet &= AddLine(lines, "occurrences", occurrences, measured, 0);
            }

            if (expectation.FreeDegreesOfFreedom is int freedom)
            {
                allMet &= AddLine(lines, "freeDegreesOfFreedom", freedom, ReadFreeDegreesOfFreedom(document), 0);
            }

            return lines;
        }

        /// <summary>Adds "name: expected E, measured M (ok | MISMATCH)" and returns whether it matched.</summary>
        private static bool AddLine(List<string> lines, string name, double expected, double? measured, double allowed)
        {
            if (measured is null)
            {
                lines.Add($"{name}: expected {Format(expected)}, but it cannot be measured on this document (MISMATCH)");
                return false;
            }

            var matched = Math.Abs(measured.Value - expected) <= allowed;
            lines.Add($"{name}: expected {Format(expected)}, measured {Format(measured.Value)} ({(matched ? "ok" : "MISMATCH")})");
            return matched;
        }

        private static string Format(double value)
        {
            return Math.Round(value, 3).ToString(CultureInfo.InvariantCulture);
        }

        private static double? ReadVolumeMm3(Document document)
        {
            switch (document)
            {
                case PartDocument part:
                    return part.ComponentDefinition.MassProperties.Volume * CubicMillimetersPerCubicCentimeter;
                case AssemblyDocument assembly:
                    return assembly.ComponentDefinition.MassProperties.Volume * CubicMillimetersPerCubicCentimeter;
                default:
                    return null;
            }
        }

        /// <summary>Size of the union of the bodies' precise range boxes (RangeBox alone can be loose).</summary>
        private static double[]? ReadSizeMm(Document document)
        {
            var bodies = new List<SurfaceBody>();

            switch (document)
            {
                case PartDocument part:
                    foreach (SurfaceBody body in part.ComponentDefinition.SurfaceBodies)
                    {
                        bodies.Add(body);
                    }

                    break;
                case AssemblyDocument assembly:
                    foreach (ComponentOccurrence occurrence in assembly.ComponentDefinition.Occurrences.AllLeafOccurrences)
                    {
                        if (occurrence.Suppressed || !occurrence.Visible)
                        {
                            continue;
                        }

                        foreach (SurfaceBody body in occurrence.SurfaceBodies)
                        {
                            bodies.Add(body);
                        }
                    }

                    break;
            }

            if (bodies.Count == 0)
            {
                return null;
            }

            var box = bodies[0].PreciseRangeBox.Copy();
            foreach (var body in bodies.Skip(1))
            {
                var bodyBox = body.PreciseRangeBox;
                box.Extend(bodyBox.MinPoint);
                box.Extend(bodyBox.MaxPoint);
            }

            return
            [
                (box.MaxPoint.X - box.MinPoint.X) * MillimetersPerCentimeter,
                (box.MaxPoint.Y - box.MinPoint.Y) * MillimetersPerCentimeter,
                (box.MaxPoint.Z - box.MinPoint.Z) * MillimetersPerCentimeter,
            ];
        }

        private static double? ReadSolidBodies(Document document)
        {
            if (document is not PartDocument part)
            {
                return null;
            }

            var count = 0;
            foreach (SurfaceBody body in part.ComponentDefinition.SurfaceBodies)
            {
                if (body.IsSolid)
                {
                    count++;
                }
            }

            return count;
        }

        private static double? ReadFreeDegreesOfFreedom(Document document)
        {
            if (document is not AssemblyDocument assembly)
            {
                return null;
            }

            var total = 0;
            foreach (ComponentOccurrence occurrence in assembly.ComponentDefinition.Occurrences)
            {
                if (occurrence.Grounded || occurrence.Suppressed)
                {
                    continue;
                }

                occurrence.GetDegreesOfFreedom(out var translations, out _, out var rotations, out _, out _);
                total += translations + rotations;
            }

            return total;
        }
    }
}
