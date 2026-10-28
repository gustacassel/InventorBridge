# Color

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.NotebookOptions.TextBackgroundColor`

```csharp
interface Color
{
    // Properties
    byte Blue { get; set; }
    ColorSourceTypeEnum ColorSourceType { get; set; }
    byte Green { get; set; }
    double Opacity { get; set; }
    byte Red { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetColor(out byte Red, out byte Green, out byte Blue);
    void SetColor(byte Red, byte Green, byte Blue);
}
```

**Returned by:** [AutoCADBlock](../objects/AutoCADBlock.md).Color, [BendNote](../objects/BendNote.md).BackgroundColor, [BendNote](../objects/BendNote.md).Color, [ChamferNote](../objects/ChamferNote.md).BackgroundColor, [ChamferNote](../objects/ChamferNote.md).Color, [ColorAssetValue](../objects/ColorAssetValue.md).Value, [ColorAssetValue](../objects/ColorAssetValue.md).Values, [ColorScheme](../objects/ColorScheme.md).BottomScreenColor, [ColorScheme](../objects/ColorScheme.md).BottomScreenColor2D, [ColorScheme](../objects/ColorScheme.md).CutPreviewColor, [ColorScheme](../objects/ColorScheme.md).DOFFixedColor, [ColorScheme](../objects/ColorScheme.md).DOFFreeColor, [ColorScheme](../objects/ColorScheme.md).DimensionColor, [ColorScheme](../objects/ColorScheme.md).GripHighlightingColor, [ColorScheme](../objects/ColorScheme.md).HighlightColor, [ColorScheme](../objects/ColorScheme.md).HighlightColor2D, [ColorScheme](../objects/ColorScheme.md).IntersectPreviewColor, [ColorScheme](../objects/ColorScheme.md).JoinPreviewColor, [ColorScheme](../objects/ColorScheme.md).PrimarySelectColor, [ColorScheme](../objects/ColorScheme.md).PrimarySelectColor2D, [ColorScheme](../objects/ColorScheme.md).ScreenColor, [ColorScheme](../objects/ColorScheme.md).ScreenColor2D, [ColorScheme](../objects/ColorScheme.md).SecondarySelectColor, [ColorScheme](../objects/ColorScheme.md).TertiarySelectColor, [ColorScheme](../objects/ColorScheme.md).TopScreenColor, [ColorScheme](../objects/ColorScheme.md).TopScreenColor2D, [ComponentGraphics](../objects/ComponentGraphics.md).Color, [CurveGraphics](../objects/CurveGraphics.md).Color, [DSJointDefinition](../objects/DSJointDefinition.md).ForceGlyphColor, [DSJointDefinition](../objects/DSJointDefinition.md).LoadGlyphColor, [DSLoadDefinition](../objects/DSLoadDefinition.md).GlyphColor, [DetailDrawingView](../objects/DetailDrawingView.md).GetComponentLineColor, [DimensionStyle](../objects/DimensionStyle.md).Color, [DimensionText](../objects/DimensionText.md).BackgroundColor, [DimensionText](../objects/DimensionText.md).Color, [DisplayOptions](../objects/DisplayOptions.md).EdgeColor, [DisplayOptions](../objects/DisplayOptions.md).InactiveComponentsEdgeColor, [DisplayOptions](../objects/DisplayOptions.md).TransparentComponentsEdgeColor, [DisplaySettings](../objects/DisplaySettings.md).EdgeColor, [DrawingCurve](../objects/DrawingCurve.md).Color and 87 more (see `members.tsv`)

**Referenced types:** [ColorSourceTypeEnum](../enums/ColorSourceTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

