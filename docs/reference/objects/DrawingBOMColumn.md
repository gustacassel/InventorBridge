# DrawingBOMColumn

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).DrawingBOMs.Item[…].DrawingBOMColumns.Item[…]`

```csharp
interface DrawingBOMColumn
{
    // Properties
    object Application { get; }
    string CustomPropertyName { get; }
    DrawingBOM Parent { get; }
    PropertyTypeEnum PropertyType { get; }
    string Title { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetFilePropertyId(out string PropSetId, out int PropId);
}
```

**Returned by:** [DrawingBOMColumns](../objects/DrawingBOMColumns.md).Item

**Referenced types:** [DrawingBOM](../objects/DrawingBOM.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PropertyTypeEnum](../enums/PropertyTypeEnum.md)

