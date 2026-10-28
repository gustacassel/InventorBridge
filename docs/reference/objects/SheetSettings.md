# SheetSettings

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).SheetSettings`

```csharp
interface SheetSettings
{
    // Properties
    object Application { get; }
    DrawingDocument Parent { get; }
    Color SheetColor { get; set; }
    Color SheetEntityHighlightColor { get; set; }
    Color SheetEntitySelectionColor { get; set; }
    string SheetLabel { get; set; }
    Color SheetOutlineColor { get; set; }
    ObjectTypeEnum Type { get; }
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingDocument](../objects/DrawingDocument.md).SheetSettings

**Referenced types:** [Color](../objects/Color.md), [DrawingDocument](../objects/DrawingDocument.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

