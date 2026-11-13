using System.Runtime.InteropServices;
using Inventor;

namespace InventorBridge.Mcp.Reading
{
    /// <summary>
    /// The bill of materials of the active assembly with quantities rolled up through the levels: the rows as a
    /// tree, and the totals per part number (what to make or buy for one assembly).
    /// </summary>
    /// <remarks>
    /// Reads the Model Data view, which every assembly has, so nothing in the document is changed (enabling the
    /// structured or parts-only view would be). Following the usual BOM rules: a Phantom component is not listed
    /// and its children take its place; a Reference component is left out with its children; the children of a
    /// Purchased component are not expanded, because it is bought whole.
    /// </remarks>
    public static class BomReader
    {
        private const string DesignTracking = "{32853F0F-3444-11D1-9E93-0060B03C1CA6}";

        public static object Read(Application application, int? maxLevels, int maxItems)
        {
            var assembly = application.ActiveDocument as AssemblyDocument
                ?? throw new InvalidOperationException("The bill of materials can only be read from an assembly: activate one first.");

            var view = FindModelDataView(assembly.ComponentDefinition.BOM)
                ?? throw new InvalidOperationException("The assembly has no Model Data BOM view.");

            var walk = new BomWalk(maxLevels, maxItems);
            walk.Visit(view.BOMRows, level: 1, parentTotal: 1, parentPath: "");

            var totals = walk.Totals.Values
                .OrderBy(total => total.PartNumber, StringComparer.OrdinalIgnoreCase)
                .ToList();

            var notes = new List<string>(walk.Notes);
            if (walk.RowsSkippedByLimit > 0)
            {
                notes.Add($"rows: {maxItems} shown, {walk.RowsSkippedByLimit} more; pass a larger maxItems or a smaller maxLevels");
            }

            if (totals.Count > maxItems)
            {
                notes.Add($"totals: {maxItems} of {totals.Count} part numbers shown; pass a larger maxItems");
            }

            return new
            {
                assembly = assembly.DisplayName,
                view = "Model Data, quantities rolled up through the levels",
                rows = walk.Rows,
                totals = totals.Take(maxItems).Select(total => total.ToEntry()).ToList(),
                notes,
            };
        }

        private static BOMView? FindModelDataView(BOM bom)
        {
            foreach (BOMView view in bom.BOMViews)
            {
                if (view.ViewType == BOMViewTypeEnum.kModelDataBOMViewType)
                {
                    return view;
                }
            }

            return null;
        }

        /// <summary>Walks the rows once, filling the listed rows (up to the limits) and the totals (always all).</summary>
        private sealed class BomWalk
        {
            private readonly int? maxLevels;
            private readonly int maxItems;
            private readonly Dictionary<string, ComponentInfo> components = [];

            public BomWalk(int? maxLevels, int maxItems)
            {
                this.maxLevels = maxLevels;
                this.maxItems = maxItems;
            }

            public List<object> Rows { get; } = [];

            public Dictionary<string, BomTotal> Totals { get; } = new(StringComparer.OrdinalIgnoreCase);

            public List<string> Notes { get; } = [];

            public int RowsSkippedByLimit { get; private set; }

            public void Visit(BOMRowsEnumerator rows, int level, double parentTotal, string parentPath)
            {
                foreach (BOMRow row in rows)
                {
                    if (row.ComponentDefinitions.Count == 0)
                    {
                        continue;
                    }

                    var structure = row.BOMStructure;
                    if (structure == BOMStructureEnum.kReferenceBOMStructure)
                    {
                        continue;
                    }

                    var component = Describe(row.ComponentDefinitions[1]);
                    var quantity = row.ItemQuantity;
                    var total = quantity * parentTotal;

                    if (row.Merged)
                    {
                        AddNote($"{component.PartNumber}: merged row (several files with the same part number)");
                    }

                    if (structure == BOMStructureEnum.kPhantomBOMStructure)
                    {
                        // A phantom is not an item: its children take its place, at its level.
                        if (row.ChildRows is { } phantomChildren)
                        {
                            Visit(phantomChildren, level, total, parentPath);
                        }

                        continue;
                    }

                    var path = parentPath.Length == 0 ? component.PartNumber : parentPath + " / " + component.PartNumber;
                    AddRow(level, path, component, structure, quantity, total, row.TotalQuantity);
                    AddTotal(component, structure, total);

                    if (structure != BOMStructureEnum.kPurchasedBOMStructure && row.ChildRows is { } children)
                    {
                        Visit(children, level + 1, total, path);
                    }
                }
            }

            private void AddRow(int level, string path, ComponentInfo component, BOMStructureEnum structure, int quantity,
                double total, string inventorQuantity)
            {
                if ((maxLevels is int limit && level > limit) || Rows.Count >= maxItems)
                {
                    if (Rows.Count >= maxItems)
                    {
                        RowsSkippedByLimit++;
                    }

                    return;
                }

                Rows.Add(new
                {
                    level,
                    path,
                    partNumber = component.PartNumber,
                    description = component.Description,
                    structure = ShortStructure(structure),
                    quantity,
                    totalQuantity = total,
                    inventorQuantity,
                    file = component.FileName,
                    @virtual = component.IsVirtual ? true : (bool?)null,
                });
            }

            private void AddTotal(ComponentInfo component, BOMStructureEnum structure, double total)
            {
                if (!Totals.TryGetValue(component.PartNumber, out var entry))
                {
                    entry = new BomTotal(component.PartNumber, component.Description, ShortStructure(structure), component.FileName);
                    Totals[component.PartNumber] = entry;
                }

                entry.Quantity += total;
            }

            private void AddNote(string note)
            {
                if (Notes.Count < maxItems && !Notes.Contains(note))
                {
                    Notes.Add(note);
                }
            }

            /// <summary>Part number, description and file of a component, read once per file.</summary>
            private ComponentInfo Describe(ComponentDefinition definition)
            {
                if (definition is VirtualComponentDefinition virtualComponent)
                {
                    var properties = virtualComponent.PropertySets[DesignTracking];
                    return new ComponentInfo(
                        Read(properties, "Part Number") ?? virtualComponent.DisplayName,
                        Read(properties, "Description"),
                        "",
                        IsVirtual: true);
                }

                var document = (Document)definition.Document;
                var key = document.FullDocumentName;
                if (components.TryGetValue(key, out var known))
                {
                    return known;
                }

                var tracking = document.PropertySets[DesignTracking];
                var fileName = System.IO.Path.GetFileName(document.FullFileName);
                var info = new ComponentInfo(
                    Read(tracking, "Part Number") ?? System.IO.Path.GetFileNameWithoutExtension(fileName),
                    Read(tracking, "Description"),
                    fileName,
                    IsVirtual: false);

                components[key] = info;
                return info;
            }

            private static string? Read(PropertySet set, string name)
            {
                try
                {
                    var text = set[name].Value?.ToString()?.Trim();
                    return string.IsNullOrEmpty(text) ? null : text;
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
        }

        /// <summary>"kPurchasedBOMStructure" -> "purchased".</summary>
        private static string ShortStructure(BOMStructureEnum structure)
        {
            var name = structure.ToString();
            name = name.StartsWith('k') ? name[1..] : name;
            name = name.EndsWith("BOMStructure", StringComparison.Ordinal) ? name[..^"BOMStructure".Length] : name;
            return name.Length == 0 ? structure.ToString() : char.ToLowerInvariant(name[0]) + name[1..];
        }

        private sealed record ComponentInfo(string PartNumber, string? Description, string FileName, bool IsVirtual);

        private sealed class BomTotal
        {
            public BomTotal(string partNumber, string? description, string structure, string fileName)
            {
                PartNumber = partNumber;
                Description = description;
                Structure = structure;
                FileName = fileName;
            }

            public string PartNumber { get; }

            public string? Description { get; }

            public string Structure { get; }

            public string FileName { get; }

            public double Quantity { get; set; }

            public object ToEntry()
            {
                return new { partNumber = PartNumber, description = Description, structure = Structure, quantity = Quantity, file = FileName };
            }
        }
    }
}
