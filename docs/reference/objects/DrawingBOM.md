# DrawingBOM

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).DrawingBOMs.Item[…]`

```csharp
interface DrawingBOM
{
    // Properties
    object Application { get; }
    DrawingBOMColumns DrawingBOMColumns { get; }
    DrawingBOMRows DrawingBOMRows { get; }
    PartsListLevelEnum Level { get; }
    DrawingDocument Parent { get; }
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [DrawingBOMCell](../objects/DrawingBOMCell.md).Parent, [DrawingBOMColumn](../objects/DrawingBOMColumn.md).Parent, [DrawingBOMRow](../objects/DrawingBOMRow.md).Parent, [DrawingBOMs](../objects/DrawingBOMs.md).Item

**Referenced types:** [DocumentDescriptor](../objects/DocumentDescriptor.md), [DrawingBOMColumns](../objects/DrawingBOMColumns.md), [DrawingBOMRows](../objects/DrawingBOMRows.md), [DrawingDocument](../objects/DrawingDocument.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartsListLevelEnum](../enums/PartsListLevelEnum.md)

