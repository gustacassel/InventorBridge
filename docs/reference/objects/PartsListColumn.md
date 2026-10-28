# PartsListColumn

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.PartsLists.Item[…].PartsListColumns.Item[…]`

```csharp
interface PartsListColumn
{
    // Properties
    object Application { get; }
    string CustomPropertyName { get; }
    PartsList Parent { get; }
    PropertyTypeEnum PropertyType { get; }
    string Title { get; set; }
    HorizontalTextAlignmentEnum TitleHorizontalJustification { get; set; }
    ObjectTypeEnum Type { get; }
    HorizontalTextAlignmentEnum ValueHorizontalJustification { get; set; }
    double Width { get; set; }
    // Methods
    void GetFilePropertyId(out string PropertySetId, out int PropId);
    void Remove();
    void Reposition(int TargetIndex = 0, bool InsertBefore = true);
}
```

**Returned by:** [PartsListColumns](../objects/PartsListColumns.md).Add, [PartsListColumns](../objects/PartsListColumns.md).Item

**Referenced types:** [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartsList](../objects/PartsList.md), [PropertyTypeEnum](../enums/PropertyTypeEnum.md)

