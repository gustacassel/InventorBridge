# DrawingStylesManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager`

```csharp
interface DrawingStylesManager
{
    // Properties
    DrawingStandardStyle ActiveStandardStyle { get; set; }
    object Application { get; }
    BalloonStylesEnumerator BalloonStyles { get; }
    CentermarkStylesEnumerator CentermarkStyles { get; }
    DimensionStylesEnumerator DimensionStyles { get; }
    EdgeSymbolStylesEnumerator EdgeSymbolStyles { get; }
    FeatureControlFrameStylesEnumerator FeatureControlFrameStyles { get; }
    HoleTableStylesEnumerator HoleTableStyles { get; }
    LayersEnumerator Layers { get; }
    LeaderStylesEnumerator LeaderStyles { get; }
    ObjectDefaultsStylesEnumerator ObjectDefaultsStyles { get; }
    DrawingDocument Parent { get; }
    PartsListStylesEnumerator PartsListStyles { get; }
    RevisionTableStylesEnumerator RevisionTableStyles { get; }
    DrawingStandardStylesEnumerator StandardStyles { get; }
    Styles Styles { get; }
    SurfaceTextureStylesEnumerator SurfaceTextureStyles { get; }
    TableStylesEnumerator TableStyles { get; }
    TextStylesEnumerator TextStyles { get; }
    TransitionSymbolStylesEnumerator TransitionSymbolStyles { get; } // since 2025
    ObjectTypeEnum Type { get; }
    ViewAnnotationStylesEnumerator ViewAnnotationStyles { get; } // since 2025
    WeldSymbolStylesEnumerator WeldSymbolStyles { get; }
    // Methods
    void ReplaceStyles(ObjectCollection ReplacedStyles, Style ReplaceStyle, object PurgeReplacedStyles = Missing);
}
```

**Returned by:** [DrawingDocument](../objects/DrawingDocument.md).StylesManager

**Referenced types:** [BalloonStylesEnumerator](../objects/BalloonStylesEnumerator.md), [CentermarkStylesEnumerator](../objects/CentermarkStylesEnumerator.md), [DimensionStylesEnumerator](../objects/DimensionStylesEnumerator.md), [DrawingDocument](../objects/DrawingDocument.md), [DrawingStandardStyle](../objects/DrawingStandardStyle.md), [DrawingStandardStylesEnumerator](../objects/DrawingStandardStylesEnumerator.md), [EdgeSymbolStylesEnumerator](../objects/EdgeSymbolStylesEnumerator.md), [FeatureControlFrameStylesEnumerator](../objects/FeatureControlFrameStylesEnumerator.md), [HoleTableStylesEnumerator](../objects/HoleTableStylesEnumerator.md), [LayersEnumerator](../objects/LayersEnumerator.md), [LeaderStylesEnumerator](../objects/LeaderStylesEnumerator.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectDefaultsStylesEnumerator](../objects/ObjectDefaultsStylesEnumerator.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartsListStylesEnumerator](../objects/PartsListStylesEnumerator.md), [RevisionTableStylesEnumerator](../objects/RevisionTableStylesEnumerator.md), [Style](../objects/Style.md), [Styles](../objects/Styles.md), [SurfaceTextureStylesEnumerator](../objects/SurfaceTextureStylesEnumerator.md), [TableStylesEnumerator](../objects/TableStylesEnumerator.md), [TextStylesEnumerator](../objects/TextStylesEnumerator.md), [TransitionSymbolStylesEnumerator](../objects/TransitionSymbolStylesEnumerator.md), [ViewAnnotationStylesEnumerator](../objects/ViewAnnotationStylesEnumerator.md), [WeldSymbolStylesEnumerator](../objects/WeldSymbolStylesEnumerator.md)

