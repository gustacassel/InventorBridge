using System.Runtime.InteropServices;
using Inventor;

namespace InventorBridge.Mcp.Reading;

/// <summary>
/// Where a part or subassembly is used in an assembly: every occurrence, at any depth, with its path and its BOM
/// structure, and whether it counts in the bill of materials.
/// </summary>
/// <remarks>
/// Finds the documents among the ones the assembly references (by part number or file name) and asks Inventor for
/// their occurrences with AllReferencedOccurrences, instead of walking the tree and reading each occurrence's
/// iProperties: on a large assembly the walk took about 10 minutes, this takes under a second. An occurrence is
/// left out of the BOM when it, or an occurrence above it, is Reference, or when it is suppressed or excluded.
/// </remarks>
public static class WhereUsedReader
{
    private const string DesignTracking = "{32853F0F-3444-11D1-9E93-0060B03C1CA6}";

    public static object Read(Application application, string item, string? documentName, int maxItems)
    {
        if (string.IsNullOrWhiteSpace(item))
        {
            throw new ArgumentException("Give a part number or a file name, such as '21260' or '21260.ipt'.");
        }

        var assembly = AssemblyOf(application, documentName);
        var wanted = item.Trim();
        var documents = new List<Document>();
        foreach (Document referenced in assembly.AllReferencedDocuments)
        {
            if (Matches(referenced, wanted))
            {
                documents.Add(referenced);
            }
        }

        if (documents.Count == 0)
        {
            return new
            {
                assembly = assembly.DisplayName,
                item = wanted,
                found = false,
                note = $"{assembly.DisplayName} references no document with part number or file name '{wanted}'.",
            };
        }

        var results = new List<object>();
        foreach (var document in documents)
        {
            var occurrences = new List<object>();
            int inBom = 0, total = 0;
            var byStructure = new Dictionary<string, int>();
            foreach (ComponentOccurrence occurrence in assembly.ComponentDefinition.Occurrences.AllReferencedOccurrences[document])
            {
                total++;
                var (structure, counted, why) = Describe(occurrence);
                byStructure[structure] = byStructure.GetValueOrDefault(structure) + 1;
                if (counted)
                {
                    inBom++;
                }

                if (occurrences.Count < maxItems)
                {
                    occurrences.Add(new { path = PathOf(occurrence), structure, inBom = counted, outOfBomBecause = why });
                }
            }

            results.Add(new
            {
                file = document.FullFileName,
                partNumber = PartNumber(document),
                documentStructure = StructureName(DocumentStructure(document)),
                occurrences = total,
                countedInBom = inBom,
                byStructure,
                list = occurrences,
                truncated = total > occurrences.Count ? $"{occurrences.Count} of {total} occurrences listed; pass a larger maxItems" : null,
            });
        }

        return new
        {
            assembly = assembly.DisplayName,
            item = wanted,
            found = true,
            documents = results,
            note = """
                countedInBom leaves out occurrences that are Reference, inside a Reference occurrence, suppressed or
                excluded; a Phantom occurrence counts through its children. structure is the occurrence's own (it can
                differ from documentStructure when set on the occurrence).
                """,
        };
    }

    private static AssemblyDocument AssemblyOf(Application application, string? documentName)
    {
        var document = OpenDocuments.Find(application, documentName);
        if (document is AssemblyDocument assembly)
        {
            return assembly;
        }

        if (document is DrawingDocument drawing && ModelOf(drawing) is AssemblyDocument model)
        {
            return model;
        }

        throw new InvalidOperationException($"{document.DisplayName} is not an assembly: activate the assembly, or pass its name in 'document'.");
    }

    /// <summary>The model of a drawing's first view, or null for a drawing without views.</summary>
    internal static Document? ModelOf(DrawingDocument drawing)
    {
        foreach (Sheet sheet in drawing.Sheets)
        {
            foreach (DrawingView view in sheet.DrawingViews)
            {
                return view.ReferencedDocumentDescriptor?.ReferencedDocument as Document;
            }
        }

        return null;
    }

    private static bool Matches(Document document, string wanted)
    {
        var file = System.IO.Path.GetFileName(document.FullFileName);
        var stem = System.IO.Path.GetFileNameWithoutExtension(document.FullFileName);
        return string.Equals(file, wanted, StringComparison.OrdinalIgnoreCase)
            || string.Equals(stem, wanted, StringComparison.OrdinalIgnoreCase)
            || string.Equals(PartNumber(document), wanted, StringComparison.OrdinalIgnoreCase);
    }

    private static string PartNumber(Document document)
    {
        try
        {
            return document.PropertySets[DesignTracking]["Part Number"].Value?.ToString() ?? "";
        }
        catch (COMException)
        {
            return "";
        }
    }

    private static (string Structure, bool Counted, string? Why) Describe(ComponentOccurrence occurrence)
    {
        var structure = StructureName(occurrence.BOMStructure);
        if (occurrence.Suppressed)
        {
            return (structure, false, "suppressed");
        }

        if (occurrence.Excluded)
        {
            return (structure, false, "excluded");
        }

        for (var current = occurrence; current is not null; current = current.ParentOccurrence)
        {
            if (current.BOMStructure == BOMStructureEnum.kReferenceBOMStructure)
            {
                return (structure, false, ReferenceEquals(current, occurrence) ? "Reference" : $"inside Reference {current.Name}");
            }
        }

        return (structure, true, null);
    }

    private static BOMStructureEnum DocumentStructure(Document document)
    {
        return document switch
        {
            PartDocument part => part.ComponentDefinition.BOMStructure,
            AssemblyDocument assembly => assembly.ComponentDefinition.BOMStructure,
            _ => BOMStructureEnum.kDefaultBOMStructure,
        };
    }

    private static string StructureName(BOMStructureEnum structure)
    {
        return structure switch
        {
            BOMStructureEnum.kNormalBOMStructure => "Normal",
            BOMStructureEnum.kReferenceBOMStructure => "Reference",
            BOMStructureEnum.kPhantomBOMStructure => "Phantom",
            BOMStructureEnum.kPurchasedBOMStructure => "Purchased",
            BOMStructureEnum.kInseparableBOMStructure => "Inseparable",
            _ => structure.ToString(),
        };
    }

    /// <summary>"Frame:1/Bracket:2/21260:1", from the top assembly down.</summary>
    private static string PathOf(ComponentOccurrence occurrence)
    {
        var names = new List<string>();
        foreach (ComponentOccurrence step in occurrence.OccurrencePath)
        {
            names.Add(step.Name);
        }

        return string.Join("/", names);
    }
}
