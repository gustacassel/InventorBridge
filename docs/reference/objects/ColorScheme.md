# ColorScheme

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ColorSchemes.Item[…]`

```csharp
interface ColorScheme
{
    // Properties
    object Application { get; }
    Color BottomScreenColor { get; }
    Color BottomScreenColor2D { get; }
    Color CutPreviewColor { get; }
    Color DOFFixedColor { get; }
    Color DOFFreeColor { get; }
    Color DimensionColor { get; }
    ObjectCollection DisplaySeparateColors { get; set; } // since 2025
    Color GripHighlightingColor { get; }
    Color HighlightColor { get; }
    Color HighlightColor2D { get; }
    string ImageFullFileName { get; set; }
    Color IntersectPreviewColor { get; }
    Color JoinPreviewColor { get; }
    string Name { get; }
    Color PrimarySelectColor { get; }
    Color PrimarySelectColor2D { get; }
    string ReflectionEnvironmentFileName { get; set; }
    Color ScreenColor { get; }
    Color ScreenColor2D { get; }
    Color SecondarySelectColor { get; }
    Color TertiarySelectColor { get; }
    Color TopScreenColor { get; }
    Color TopScreenColor2D { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Activate();
}
```

**Returned by:** [Application](../objects/Application.md).ActiveColorScheme, [ColorSchemes](../objects/ColorSchemes.md).Item, [InventorServer](../objects/InventorServer.md).ActiveColorScheme

**Referenced types:** [Color](../objects/Color.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

