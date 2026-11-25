using System.Runtime.InteropServices;
using Inventor;

namespace InventorBridge.Mcp.Reading;

/// <summary>
/// Structured summary of the active document, so the agent can check its work without a screenshot:
/// iProperties and file state of any document; features, parameters, mass and sheet metal of a part;
/// occurrences, constraints and mass of an assembly; sheets, views, parts lists and dimensions of a drawing.
/// </summary>
/// <remarks>
/// Lengths are reported in millimeters and masses in kilograms. Each section is read on its own, so one failing
/// section (reported as "error") does not hide the others. Lists stop at maxItems; "truncated" says which ones
/// were cut and how long they are.
/// </remarks>
public static class DocumentInspector
{
    private const double MillimetersPerCentimeter = 10.0;
    private const double CubicMillimetersPerCubicCentimeter = 1000.0;

    // Property sets by internal name, which does not change with Inventor's language.
    private const string SummaryInformation = "{F29F85E0-4FF9-1068-AB91-08002B27B3D9}";
    private const string DesignTracking = "{32853F0F-3444-11D1-9E93-0060B03C1CA6}";
    private const string UserDefined = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}";

    public static object Inspect(Application application, int maxItems)
    {
        var document = application.ActiveDocument;
        if (document is null)
        {
            return new { activeDocument = (string?)null, note = "No document is open." };
        }

        var truncated = new List<string>();
        var summary = new Dictionary<string, object?>
        {
            ["name"] = document.DisplayName,
            ["file"] = document.FullFileName,
            ["type"] = StatusReader.DocumentTypeName(document.DocumentType),
            ["unsavedChanges"] = document.Dirty,
            ["requiresUpdate"] = ReadSection(() => document.RequiresUpdate),
            ["readOnlyFile"] = IsReadOnlyFile(document.FullFileName),
            ["iProperties"] = ReadSection(() => ReadProperties(document, maxItems, truncated)),
        };

        switch (document)
        {
            case PartDocument part:
                AddPartSections(summary, part, maxItems, truncated);
                break;
            case AssemblyDocument assembly:
                AddAssemblySections(summary, assembly.ComponentDefinition, maxItems, truncated);
                break;
            case DrawingDocument drawing:
                AddDrawingSections(summary, drawing, maxItems, truncated);
                break;
        }

        if (truncated.Count > 0)
        {
            summary["truncated"] = truncated.Select(line => $"{line}; pass a larger maxItems to see more").ToList();
        }

        if (document.Dirty && summary["readOnlyFile"] is true)
        {
            summary["note"] = """
                The document has unsaved changes but its file is read-only (in Vault: not checked out).
                Inventor often updates a document when it opens, which also counts as a change.
                """;
        }

        return summary;
    }

    private static void AddPartSections(Dictionary<string, object?> summary, PartDocument part, int maxItems, List<string> truncated)
    {
        var definition = part.ComponentDefinition;
        summary["modelState"] = ReadSection(() => ReadModelState(definition.ModelStates));
        summary["features"] = ReadSection(() => ReadFeatures(definition, maxItems, truncated));
        summary["featuresWithProblems"] = ReadSection(() => ReadFeatureProblems(definition));
        summary["parameters"] = ReadSection(() => ReadParameters(definition.Parameters, maxItems, truncated));
        summary["solidBodies"] = ReadSection(() => definition.SurfaceBodies.Count);
        summary["boundingBoxMm"] = ReadSection(() => ReadPreciseBox(definition.SurfaceBodies) ?? ReadBox(definition.RangeBox));
        summary["volumeMm3"] = ReadSection(() => Math.Round(definition.MassProperties.Volume * CubicMillimetersPerCubicCentimeter, 3));
        summary["massKg"] = ReadSection(() => Math.Round(definition.MassProperties.Mass, 3));
        summary["material"] = ReadSection(() => part.ActiveMaterial?.DisplayName);

        if (definition is SheetMetalComponentDefinition sheetMetal)
        {
            summary["sheetMetal"] = ReadSection(() => ReadSheetMetal(sheetMetal));
        }
    }

    private static void AddAssemblySections(Dictionary<string, object?> summary, AssemblyComponentDefinition definition, int maxItems, List<string> truncated)
    {
        summary["modelState"] = ReadSection(() => ReadModelState(definition.ModelStates));
        summary["designView"] = ReadSection(() => definition.RepresentationsManager.ActiveDesignViewRepresentation?.Name);
        summary["occurrenceCounts"] = ReadSection(() => new
        {
            topLevel = definition.Occurrences.Count,
            allParts = definition.Occurrences.AllLeafOccurrences.Count,
        });
        summary["occurrences"] = ReadSection(() => ReadOccurrences(definition, maxItems, truncated));
        summary["constraints"] = ReadSection(() => ReadConstraints(definition, maxItems, truncated));
        summary["constraintsWithProblems"] = ReadSection(() => ReadConstraintProblems(definition));
        summary["parameters"] = ReadSection(() => ReadParameters(definition.Parameters, maxItems, truncated));
        summary["boundingBoxMm"] = ReadSection(() => ReadBox(definition.RangeBox));
        summary["boundingBoxNote"] = """
            Inventor's range box: it can be larger than the parts when some are rotated.
            run_csharp's expect sizeMm measures the bodies exactly.
            """;
        summary["massKg"] = ReadSection(() => Math.Round(definition.MassProperties.Mass, 3));
    }

    private static void AddDrawingSections(Dictionary<string, object?> summary, DrawingDocument drawing, int maxItems, List<string> truncated)
    {
        summary["models"] = ReadSection(() => ReadReferencedFiles(drawing, maxItems, truncated));
        summary["sheets"] = ReadSection(() => ReadSheets(drawing, maxItems, truncated));
    }

    /// <summary>The usual iProperties, by internal property set name, and every custom property.</summary>
    private static object ReadProperties(Document document, int maxItems, List<string> truncated)
    {
        var sets = document.PropertySets;
        var summaryInformation = sets[SummaryInformation];
        var designTracking = sets[DesignTracking];

        var custom = new Dictionary<string, object?>();
        var userDefined = sets[UserDefined];
        foreach (Property property in userDefined)
        {
            if (custom.Count >= maxItems)
            {
                truncated.Add($"iProperties.custom: {maxItems} of {userDefined.Count} shown");
                break;
            }

            custom[property.Name] = ReadValue(property);
        }

        return new
        {
            partNumber = ReadValue(designTracking, "Part Number"),
            description = ReadValue(designTracking, "Description"),
            stockNumber = ReadValue(designTracking, "Stock Number"),
            revision = ReadValue(summaryInformation, "Revision Number"),
            title = ReadValue(summaryInformation, "Title"),
            author = ReadValue(summaryInformation, "Author"),
            designer = ReadValue(designTracking, "Designer"),
            project = ReadValue(designTracking, "Project"),
            vendor = ReadValue(designTracking, "Vendor"),
            custom,
        };
    }

    private static object? ReadValue(PropertySet set, string name)
    {
        try
        {
            return ReadValue(set[name]);
        }
        catch (COMException)
        {
            return null;
        }
        catch (ArgumentException)
        {
            return null;
        }
    }

    /// <summary>Strings, numbers, booleans and dates as they are; empty strings as null; anything else as text.</summary>
    private static object? ReadValue(Property property)
    {
        var value = property.Value;
        return value switch
        {
            null => null,
            string text => text.Length == 0 ? null : text,
            double or int or bool or DateTime => value,
            _ => value.ToString(),
        };
    }

    private static object ReadModelState(ModelStates modelStates)
    {
        return new { active = modelStates.ActiveModelState?.Name, count = modelStates.Count };
    }

    private static List<object> ReadFeatures(PartComponentDefinition definition, int maxItems, List<string> truncated)
    {
        var features = new List<object>();
        var all = definition.Features;

        foreach (PartFeature feature in all)
        {
            if (features.Count >= maxItems)
            {
                truncated.Add($"features: {maxItems} of {all.Count} shown");
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

    /// <summary>Features that are not up to date and not suppressed on purpose, across the whole part.</summary>
    private static List<string> ReadFeatureProblems(PartComponentDefinition definition)
    {
        var problems = new List<string>();
        foreach (PartFeature feature in definition.Features)
        {
            var health = feature.HealthStatus;
            if (health is not (HealthStatusEnum.kUpToDateHealth or HealthStatusEnum.kSuppressedHealth or HealthStatusEnum.kBeyondStopNodeHealth))
            {
                problems.Add($"{feature.Name}: {health}");
            }
        }

        return problems;
    }

    private static List<object> ReadParameters(Parameters parameters, int maxItems, List<string> truncated)
    {
        var result = new List<object>();

        foreach (Parameter parameter in parameters)
        {
            if (result.Count >= maxItems)
            {
                truncated.Add($"parameters: {maxItems} of {parameters.Count} shown");
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

    private static object ReadSheetMetal(SheetMetalComponentDefinition sheetMetal)
    {
        var thickness = sheetMetal.Thickness;
        object flatPattern;

        if (!sheetMetal.HasFlatPattern)
        {
            flatPattern = "none";
        }
        else
        {
            var pattern = sheetMetal.FlatPattern;
            var box = pattern.RangeBox;
            var empty = box.MinPoint.DistanceTo(box.MaxPoint) < 1e-9;
            flatPattern = empty
                ? "broken: the flat pattern has no geometry, so unfolding failed"
                : new
                {
                    lengthMm = Math.Round(pattern.Length * MillimetersPerCentimeter, 3),
                    widthMm = Math.Round(pattern.Width * MillimetersPerCentimeter, 3),
                };
        }

        return new
        {
            thicknessMm = Math.Round(Convert.ToDouble(thickness.Value) * MillimetersPerCentimeter, 3),
            thicknessExpression = thickness.Expression,
            flatPattern,
        };
    }

    private static List<object> ReadOccurrences(AssemblyComponentDefinition definition, int maxItems, List<string> truncated)
    {
        var occurrences = new List<object>();
        var all = definition.Occurrences;

        foreach (ComponentOccurrence occurrence in all)
        {
            if (occurrences.Count >= maxItems)
            {
                truncated.Add($"occurrences: {maxItems} of {all.Count} top-level occurrences shown");
                break;
            }

            occurrence.GetDegreesOfFreedom(out var translationCount, out _, out var rotationCount, out _, out _);

            occurrences.Add(new
            {
                name = occurrence.Name,
                file = occurrence.ReferencedDocumentDescriptor.FullDocumentName,
                subassembly = occurrence.DefinitionDocumentType == DocumentTypeEnum.kAssemblyDocumentObject,
                grounded = occurrence.Grounded,
                suppressed = occurrence.Suppressed,
                freeTranslations = translationCount,
                freeRotations = rotationCount,
            });
        }

        return occurrences;
    }

    private static List<object> ReadConstraints(AssemblyComponentDefinition definition, int maxItems, List<string> truncated)
    {
        var constraints = new List<object>();
        var all = definition.Constraints;

        foreach (AssemblyConstraint constraint in all)
        {
            if (constraints.Count >= maxItems)
            {
                truncated.Add($"constraints: {maxItems} of {all.Count} shown");
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

    /// <summary>Constraints of this assembly (not of its subassemblies) that are not up to date or suppressed.</summary>
    private static List<string> ReadConstraintProblems(AssemblyComponentDefinition definition)
    {
        var problems = new List<string>();
        foreach (AssemblyConstraint constraint in definition.Constraints)
        {
            var health = constraint.HealthStatus;
            if (health is not (HealthStatusEnum.kUpToDateHealth or HealthStatusEnum.kSuppressedHealth or HealthStatusEnum.kBeyondStopNodeHealth))
            {
                problems.Add($"{constraint.Name}: {health}");
            }
        }

        return problems;
    }

    private static List<string> ReadReferencedFiles(DrawingDocument drawing, int maxItems, List<string> truncated)
    {
        var files = new List<string>();
        var descriptors = drawing.File.ReferencedFileDescriptors;

        foreach (FileDescriptor descriptor in descriptors)
        {
            if (files.Count >= maxItems)
            {
                truncated.Add($"models: {maxItems} of {descriptors.Count} shown");
                break;
            }

            files.Add(descriptor.FullFileName + (descriptor.ReferenceMissing ? " (MISSING)" : ""));
        }

        return files;
    }

    private static List<object> ReadSheets(DrawingDocument drawing, int maxItems, List<string> truncated)
    {
        var sheets = new List<object>();

        foreach (Sheet sheet in drawing.Sheets)
        {
            if (sheets.Count >= maxItems)
            {
                truncated.Add($"sheets: {maxItems} of {drawing.Sheets.Count} shown");
                break;
            }

            sheets.Add(ReadSheet(sheet, maxItems, truncated));
        }

        return sheets;
    }

    private static object ReadSheet(Sheet sheet, int maxItems, List<string> truncated)
    {
        var views = new List<object?>();
        foreach (DrawingView view in sheet.DrawingViews)
        {
            if (views.Count >= maxItems)
            {
                truncated.Add($"{sheet.Name} views: {maxItems} of {sheet.DrawingViews.Count} shown");
                break;
            }

            views.Add(ReadSection(() => ReadView(view)));
        }

        var partsLists = new List<object?>();
        foreach (PartsList partsList in sheet.PartsLists)
        {
            partsLists.Add(ReadSection(() => new
            {
                rows = partsList.PartsListRows.Count,
                model = System.IO.Path.GetFileName(partsList.ReferencedDocumentDescriptor?.FullDocumentName),
            }));
        }

        var dimensions = sheet.DrawingDimensions;
        var detached = 0;
        foreach (DrawingDimension dimension in dimensions)
        {
            if (!dimension.Attached)
            {
                detached++;
            }
        }

        return new
        {
            name = sheet.Name,
            size = ShortSize(sheet.Size),
            widthMm = Math.Round(sheet.Width * MillimetersPerCentimeter, 1),
            heightMm = Math.Round(sheet.Height * MillimetersPerCentimeter, 1),
            border = ReadSection(() => sheet.Border?.Name),
            titleBlock = ReadSection(() => sheet.TitleBlock?.Name),
            views,
            partsLists,
            balloons = sheet.Balloons.Count,
            dimensions = dimensions.Count,
            detachedDimensions = detached,
            notes = sheet.DrawingNotes.Count,
            weldSymbols = ReadWeldSymbols(sheet, maxItems, truncated),
        };
    }

    /// <summary>
    /// The weld symbols of a sheet: position, and per definition the arrow side and the other side. Which fields a
    /// weld has depends on its type and the drafting standard; the others throw (E_FAIL), so each is read alone and
    /// left out when it fails.
    /// </summary>
    private static List<object?> ReadWeldSymbols(Sheet sheet, int maxItems, List<string> truncated)
    {
        var symbols = new List<object?>();
        foreach (DrawingWeldingSymbol symbol in sheet.WeldingSymbols)
        {
            if (symbols.Count >= maxItems)
            {
                truncated.Add($"{sheet.Name} weld symbols: {maxItems} of {sheet.WeldingSymbols.Count} shown");
                break;
            }

            symbols.Add(ReadSection(() =>
            {
                var definitions = new List<object>();
                foreach (DrawingWeldingSymbolDefinition definition in symbol.Definitions)
                {
                    definitions.Add(new
                    {
                        arrowSide = ReadWeld(definition.WeldSymbolOne),
                        otherSide = ReadWeld(definition.WeldSymbolTwo),
                        allAround = Try<bool?>(() => definition.AllAroundSymbol),
                        fieldWeld = Try<bool?>(() => definition.FieldWeldingSymbol),
                        tail = Try(() => definition.TailNote) is { Length: > 0 } tail ? tail : null,
                    });
                }

                return new
                {
                    positionMm = new[]
                    {
                        Math.Round(symbol.Position.X * MillimetersPerCentimeter, 1),
                        Math.Round(symbol.Position.Y * MillimetersPerCentimeter, 1),
                    },
                    definitions,
                };
            }));
        }

        return symbols;
    }

    private static Dictionary<string, object>? ReadWeld(WeldSymbol? weld)
    {
        if (weld is null)
        {
            return null;
        }

        var type = Try<int?>(() => weld.WeldSymbolType);
        var fields = new Dictionary<string, object>();
        if (type is int value)
        {
            fields["type"] = Enum.IsDefined(typeof(WeldSymbolTypeEnum), value) ? ((WeldSymbolTypeEnum)value).ToString() : value.ToString();
        }

        foreach (var (name, read) in new (string, Func<string>)[]
        {
            ("prefix", () => weld.Prefix), ("sizeOrStrength", () => weld.SizeOrStrength), ("leg1", () => weld.Leg1),
            ("leg2", () => weld.Leg2), ("depth", () => weld.Depth), ("number", () => weld.Number),
            ("length", () => weld.Length), ("pitch", () => weld.Pitch), ("method", () => weld.Method),
        })
        {
            if (Try(read) is { Length: > 0 } text)
            {
                fields[name] = text;
            }
        }

        if (Try<ContourSymbolTypeEnum?>(() => weld.Contour) is ContourSymbolTypeEnum contour)
        {
            fields["contour"] = contour.ToString();
        }

        // A side with no size, length or other value draws nothing, whatever type Inventor keeps for it.
        var values = fields.Keys.Count(key => key is not "type" and not "contour");
        var contoured = fields.TryGetValue("contour", out var shape) && !Equals(shape, nameof(ContourSymbolTypeEnum.kNoContourSymbolType));
        var none = Equals(fields.GetValueOrDefault("type"), nameof(WeldSymbolTypeEnum.kNoneWeldSymbolType));
        return none || (values == 0 && !contoured) ? null : fields;
    }

    private static T? Try<T>(Func<T> read)
    {
        try
        {
            return read();
        }
        catch (COMException)
        {
            return default;
        }
    }

    private static object ReadView(DrawingView view)
    {
        return new
        {
            name = view.Name,
            type = view.ViewType.ToString(),
            scale = view.ScaleString,
            model = System.IO.Path.GetFileName(view.ReferencedDocumentDescriptor?.FullDocumentName),
            style = view.ViewStyle.ToString(),
            centerMm = new[]
            {
                Math.Round(view.Center.X * MillimetersPerCentimeter, 1),
                Math.Round(view.Center.Y * MillimetersPerCentimeter, 1),
            },
        };
    }

    /// <summary>"kA3DrawingSheetSize" -> "A3".</summary>
    private static string ShortSize(DrawingSheetSizeEnum size)
    {
        var name = size.ToString();
        name = name.StartsWith('k') ? name[1..] : name;
        return name.EndsWith("DrawingSheetSize", StringComparison.Ordinal) ? name[..^"DrawingSheetSize".Length] : name;
    }

    /// <summary>The union of the bodies' precise range boxes, or null when there is no body.</summary>
    private static object? ReadPreciseBox(SurfaceBodies bodies)
    {
        Box? union = null;
        foreach (SurfaceBody body in bodies)
        {
            var box = body.PreciseRangeBox;
            if (union is null)
            {
                union = box.Copy();
            }
            else
            {
                union.Extend(box.MinPoint);
                union.Extend(box.MaxPoint);
            }
        }

        return union is null ? null : ReadBox(union);
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

    private static bool? IsReadOnlyFile(string? fullFileName)
    {
        if (string.IsNullOrEmpty(fullFileName) || !System.IO.File.Exists(fullFileName))
        {
            return null;
        }

        return (System.IO.File.GetAttributes(fullFileName) & System.IO.FileAttributes.ReadOnly) != 0;
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
        catch (ArgumentException exception)
        {
            return new { error = exception.Message };
        }
    }
}
