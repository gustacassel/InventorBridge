# SheetFormat

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).SheetFormats.Item[…]`

```csharp
interface SheetFormat
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool FitViewsToSheet { get; }
    bool HasDrawingViews { get; }
    double Height { get; }
    string Name { get; set; }
    PageOrientationTypeEnum Orientation { get; }
    DrawingDocument Parent { get; }
    AutoCADBlockDefinitionsEnumerator ReferencedAutoCADBlockDefinitions { get; }
    BorderDefinition ReferencedBorderDefinition { get; }
    ObjectsEnumerator ReferencedSymbolDefinitions { get; }
    TitleBlockDefinition ReferencedTitleBlockDefinition { get; }
    DrawingSheetSizeEnum Size { get; }
    TitleBlockLocationEnum TitleBlockLocation { get; }
    ObjectTypeEnum Type { get; }
    double Width { get; }
    // Methods
    SheetFormat CopyTo(DrawingDocument TargetDocument);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [SheetFormat](../objects/SheetFormat.md).CopyTo, [SheetFormats](../objects/SheetFormats.md).Add, [SheetFormats](../objects/SheetFormats.md).AddWithOptions, [SheetFormats](../objects/SheetFormats.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [AutoCADBlockDefinitionsEnumerator](../objects/AutoCADBlockDefinitionsEnumerator.md), [BorderDefinition](../objects/BorderDefinition.md), [DrawingDocument](../objects/DrawingDocument.md), [DrawingSheetSizeEnum](../enums/DrawingSheetSizeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [PageOrientationTypeEnum](../enums/PageOrientationTypeEnum.md), [TitleBlockDefinition](../objects/TitleBlockDefinition.md), [TitleBlockLocationEnum](../enums/TitleBlockLocationEnum.md)

