# BorderDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).BorderDefinitions.Item[…]`

```csharp
interface BorderDefinition
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool IsDefault { get; }
    bool IsReferenced { get; }
    string Name { get; set; }
    DrawingDocument Parent { get; }
    DrawingSketch Sketch { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BorderDefinition CopyTo(DrawingDocument TargetDocument, bool ReplaceExisting = false);
    void Delete();
    void Edit(out DrawingSketch Sketch);
    void ExitEdit(bool SaveChanges = true, object SaveAsName = Missing);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [Border](../objects/Border.md).Definition, [BorderDefinition](../objects/BorderDefinition.md).CopyTo, [BorderDefinitions](../objects/BorderDefinitions.md).Add, [BorderDefinitions](../objects/BorderDefinitions.md).Item, [DefaultBorder](../objects/DefaultBorder.md).Definition, [SheetFormat](../objects/SheetFormat.md).ReferencedBorderDefinition

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [DrawingDocument](../objects/DrawingDocument.md), [DrawingSketch](../objects/DrawingSketch.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

