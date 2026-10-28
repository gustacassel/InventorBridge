# BOMRow

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).DrawingBOMs.Item[…].DrawingBOMRows.Item[…].BOMRow`

```csharp
interface BOMRow
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    BOMStructureEnum BOMStructure { get; set; }
    BOMRowsEnumerator ChildRows { get; }
    ComponentDefinitionsEnumerator ComponentDefinitions { get; }
    ComponentOccurrencesEnumerator ComponentOccurrences { get; }
    string ItemNumber { get; set; }
    bool ItemNumberLocked { get; set; }
    int ItemQuantity { get; }
    bool Merged { get; }
    PropertySets OccurrencePropertySets { get; }
    object Parent { get; }
    bool Promoted { get; }
    FileDescriptor ReferencedFileDescriptor { get; }
    bool RolledUp { get; }
    string TotalQuantity { get; set; }
    bool TotalQuantityOverridden { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [BOMRowsEnumerator](../objects/BOMRowsEnumerator.md).Item, [DrawingBOMRow](../objects/DrawingBOMRow.md).BOMRow

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [BOMRowsEnumerator](../objects/BOMRowsEnumerator.md), [BOMStructureEnum](../enums/BOMStructureEnum.md), [ComponentDefinitionsEnumerator](../objects/ComponentDefinitionsEnumerator.md), [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [FileDescriptor](../objects/FileDescriptor.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PropertySets](../objects/PropertySets.md)

