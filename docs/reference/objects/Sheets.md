# Sheets

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Sheets`

```csharp
interface Sheets
{
    // Properties
    object Application { get; }
    int Count { get; }
    Sheet Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Sheet Add(DrawingSheetSizeEnum Size = DrawingSheetSizeEnum.kCDrawingSheetSize, PageOrientationTypeEnum Orientation = PageOrientationTypeEnum.kLandscapePageOrientation, string SheetName = "", object Width = Missing, object Height = Missing);
    Sheet AddUsingSheetFormat(SheetFormat SheetFormat, object Model = Missing, string SheetName = "", object AdditionalOptions = Missing, object TitleBlockPromptStrings = Missing, object BorderPromptStrings = Missing);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).Sheets, [DrawingDocument](../objects/DrawingDocument.md).Sheets

**Referenced types:** [DrawingSheetSizeEnum](../enums/DrawingSheetSizeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PageOrientationTypeEnum](../enums/PageOrientationTypeEnum.md), [Sheet](../objects/Sheet.md), [SheetFormat](../objects/SheetFormat.md)

