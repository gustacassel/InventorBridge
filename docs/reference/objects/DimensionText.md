# DimensionText

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingDimensions.Item[…].Text`

```csharp
interface DimensionText
{
    // Properties
    object Application { get; }
    Color BackgroundColor { get; set; } // since 2025
    Color Color { get; set; }
    string FormattedText { get; set; }
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    double LineSpacing { get; set; }
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    Point2d Origin { get; set; }
    DrawingDimension Parent { get; }
    Box2d RangeBox { get; }
    string Text { get; }
    ObjectTypeEnum Type { get; }
    bool UseBackgroundColor { get; set; } // since 2025
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    double WidthScale { get; set; }
}
```

**Returned by:** [AngularGeneralDimension](../objects/AngularGeneralDimension.md).Text, [DiameterGeneralDimension](../objects/DiameterGeneralDimension.md).Text, [DrawingDimension](../objects/DrawingDimension.md).Text, [GeneralDimension](../objects/GeneralDimension.md).Text, [HoleThreadNote](../objects/HoleThreadNote.md).Text, [LinearGeneralDimension](../objects/LinearGeneralDimension.md).Text, [OrdinateDimension](../objects/OrdinateDimension.md).Text, [RadiusGeneralDimension](../objects/RadiusGeneralDimension.md).Text

**Referenced types:** [Box2d](../objects/Box2d.md), [Color](../objects/Color.md), [DrawingDimension](../objects/DrawingDimension.md), [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [TextLineSpacingTypeEnum](../enums/TextLineSpacingTypeEnum.md), [VerticalTextAlignmentEnum](../enums/VerticalTextAlignmentEnum.md)

