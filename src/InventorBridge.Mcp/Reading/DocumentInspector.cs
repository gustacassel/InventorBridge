using System.Runtime.InteropServices;
using Inventor;

namespace InventorBridge.Mcp.Reading
{
    /// <summary>
    /// Structured summary of the active document, so the agent can check its work without a screenshot:
    /// features and parameters of a part, occurrences and constraints of an assembly, sheets of a drawing.
    /// </summary>
    /// <remarks>
    /// Lengths are reported in millimeters. Each section is read on its own, so one failing section
    /// (reported as "error") does not hide the others.
    /// </remarks>
    public static class DocumentInspector
    {
        private const double MillimetersPerCentimeter = 10.0;
        private const double CubicMillimetersPerCubicCentimeter = 1000.0;

        public static object Inspect(Application application, int maxItems)
        {
            var document = application.ActiveDocument;
            if (document is null)
            {
                return new { activeDocument = (string?)null, note = "No document is open." };
            }

            var summary = new Dictionary<string, object?>
            {
                ["name"] = document.DisplayName,
                ["file"] = document.FullFileName,
                ["type"] = StatusReader.DocumentTypeName(document.DocumentType),
                ["unsavedChanges"] = document.Dirty,
            };

            switch (document)
            {
                case PartDocument part:
                    AddPartSections(summary, part.ComponentDefinition, maxItems);
                    break;
                case AssemblyDocument assembly:
                    AddAssemblySections(summary, assembly.ComponentDefinition, maxItems);
                    break;
                case DrawingDocument drawing:
                    summary["sheets"] = ReadSection(() => ReadSheets(drawing, maxItems));
                    break;
            }

            return summary;
        }

        private static void AddPartSections(Dictionary<string, object?> summary, PartComponentDefinition definition, int maxItems)
        {
            summary["features"] = ReadSection(() => ReadFeatures(definition, maxItems));
            summary["parameters"] = ReadSection(() => ReadParameters(definition.Parameters, maxItems));
            summary["solidBodies"] = ReadSection(() => definition.SurfaceBodies.Count);
            summary["boundingBoxMm"] = ReadSection(() => ReadBox(definition.RangeBox));
            summary["volumeMm3"] = ReadSection(() => Math.Round(definition.MassProperties.Volume * CubicMillimetersPerCubicCentimeter, 3));
        }

        private static void AddAssemblySections(Dictionary<string, object?> summary, AssemblyComponentDefinition definition, int maxItems)
        {
            summary["occurrences"] = ReadSection(() => ReadOccurrences(definition, maxItems));
            summary["constraints"] = ReadSection(() => ReadConstraints(definition, maxItems));
            summary["parameters"] = ReadSection(() => ReadParameters(definition.Parameters, maxItems));
            summary["boundingBoxMm"] = ReadSection(() => ReadBox(definition.RangeBox));
        }

        private static List<object> ReadFeatures(PartComponentDefinition definition, int maxItems)
        {
            var features = new List<object>();

            foreach (PartFeature feature in definition.Features)
            {
                if (features.Count >= maxItems)
                {
                    break;
                }

                features.Add(new
                {
                    name = feature.Name,
                    type = feature.Type.ToString(),
                    suppressed = feature.Suppressed,
                    health = feature.HealthStatus.ToString(),
                });
            }

            return features;
        }

        private static List<object> ReadParameters(Parameters parameters, int maxItems)
        {
            var result = new List<object>();

            foreach (Parameter parameter in parameters)
            {
                if (result.Count >= maxItems)
                {
                    break;
                }

                result.Add(new
                {
                    name = parameter.Name,
                    expression = parameter.Expression,
                    // Units has a string getter but an object setter, which C# cannot use as a property.
                    units = parameter.get_Units(),
                });
            }

            return result;
        }

        private static List<object> ReadOccurrences(AssemblyComponentDefinition definition, int maxItems)
        {
            var occurrences = new List<object>();

            foreach (ComponentOccurrence occurrence in definition.Occurrences)
            {
                if (occurrences.Count >= maxItems)
                {
                    break;
                }

                occurrence.GetDegreesOfFreedom(out var translationCount, out _, out var rotationCount, out _, out _);

                occurrences.Add(new
                {
                    name = occurrence.Name,
                    file = occurrence.ReferencedDocumentDescriptor.FullDocumentName,
                    grounded = occurrence.Grounded,
                    suppressed = occurrence.Suppressed,
                    freeTranslations = translationCount,
                    freeRotations = rotationCount,
                });
            }

            return occurrences;
        }

        private static List<object> ReadConstraints(AssemblyComponentDefinition definition, int maxItems)
        {
            var constraints = new List<object>();

            foreach (AssemblyConstraint constraint in definition.Constraints)
            {
                if (constraints.Count >= maxItems)
                {
                    break;
                }

                constraints.Add(new
                {
                    name = constraint.Name,
                    type = constraint.Type.ToString(),
                    suppressed = constraint.Suppressed,
                    health = constraint.HealthStatus.ToString(),
                });
            }

            return constraints;
        }

        private static List<object> ReadSheets(DrawingDocument drawing, int maxItems)
        {
            var sheets = new List<object>();

            foreach (Sheet sheet in drawing.Sheets)
            {
                if (sheets.Count >= maxItems)
                {
                    break;
                }

                var views = new List<string>();
                foreach (DrawingView view in sheet.DrawingViews)
                {
                    views.Add(view.Name);
                }

                sheets.Add(new { name = sheet.Name, views });
            }

            return sheets;
        }

        private static object ReadBox(Box box)
        {
            return new
            {
                min = ToMillimeters(box.MinPoint),
                max = ToMillimeters(box.MaxPoint),
            };
        }

        private static double[] ToMillimeters(Point point)
        {
            return
            [
                Math.Round(point.X * MillimetersPerCentimeter, 3),
                Math.Round(point.Y * MillimetersPerCentimeter, 3),
                Math.Round(point.Z * MillimetersPerCentimeter, 3),
            ];
        }

        /// <summary>Runs one section; a COM error becomes { error } instead of failing the whole inspection.</summary>
        private static object? ReadSection(Func<object?> read)
        {
            try
            {
                return read();
            }
            catch (COMException exception)
            {
                return new { error = $"0x{exception.HResult:X8}: {exception.Message}" };
            }
        }
    }
}
