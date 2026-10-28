# ColorSchemes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ColorSchemes`

```csharp
interface ColorSchemes
{
    // Properties
    object Application { get; }
    BackgroundTypeEnum BackgroundType { get; set; }
    int Count { get; }
    bool EnableEnhancedHighlighting { get; set; }
    bool EnablePrehighlight { get; set; }
    bool HighlightHiddenFaces { get; set; } // since 2025
    IconsColorTypeEnum IconsColor { get; set; }
    ColorScheme Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).ColorSchemes, [InventorServer](../objects/InventorServer.md).ColorSchemes

**Referenced types:** [BackgroundTypeEnum](../enums/BackgroundTypeEnum.md), [ColorScheme](../objects/ColorScheme.md), [IconsColorTypeEnum](../enums/IconsColorTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

