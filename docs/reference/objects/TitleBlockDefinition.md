# TitleBlockDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).TitleBlockDefinitions.Item[…]`

```csharp
interface TitleBlockDefinition
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool IsReferenced { get; }
    string Name { get; set; }
    DrawingDocument Parent { get; }
    DrawingSketch Sketch { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    TitleBlockDefinition CopyTo(DrawingDocument TargetDocument, bool ReplaceExisting = false);
    void Delete();
    void Edit(out DrawingSketch Result);
    void ExitEdit(bool SaveChanges = true, object SaveAsName = Missing);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [SheetFormat](../objects/SheetFormat.md).ReferencedTitleBlockDefinition, [TitleBlock](../objects/TitleBlock.md).Definition, [TitleBlockDefinition](../objects/TitleBlockDefinition.md).CopyTo, [TitleBlockDefinitions](../objects/TitleBlockDefinitions.md).Add, [TitleBlockDefinitions](../objects/TitleBlockDefinitions.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [DrawingDocument](../objects/DrawingDocument.md), [DrawingSketch](../objects/DrawingSketch.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

