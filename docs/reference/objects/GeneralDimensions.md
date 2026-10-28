# GeneralDimensions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingDimensions.GeneralDimensions`

```csharp
interface GeneralDimensions
{
    // Properties
    object Application { get; }
    int Count { get; }
    GeneralDimension Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    AngularGeneralDimension AddAngular(Point2d TextOrigin, GeometryIntent IntentOne, object IntentTwo = Missing, object IntentThree = Missing, bool ArrowheadsInside = true, bool UseQuadrant = true, bool OppositeAngle = false, object DimensionStyle = Missing, object Layer = Missing);
    AngularGeneralDimension AddAngularForeshortened(Point2d TextOrigin, GeometryIntent IntentOne, object IntentTwo = Missing, object IntentThree = Missing, bool HideSecondArrowhead = false, bool UseQuadrant = true, bool OppositeAngle = false, object DimensionStyle = Missing, object Layer = Missing);
    AngularGeneralDimension AddAngularSum(Point2d TextOrigin, AngularGeneralDimension SpacingDimension, GeometryIntent IntentOne, object IntentTwo = Missing, object IntentThree = Missing, bool ArrowheadsInside = true, bool OppositeAngle = false, object DimensionStyle = Missing, object Layer = Missing, object Reserved = Missing); // since 2026
    LinearGeneralDimension AddArcLengthForeshortened(Point2d TextOrigin, GeometryIntent IntentOne, object IntentTwo = Missing, object IntentThree = Missing, object VirtualArcPosition = Missing, bool HideSecondArrowhead = false, bool UseQuadrant = true, bool OppositeAngle = false, object DimensionStyle = Missing, object Layer = Missing);
    DiameterGeneralDimension AddDiameter(Point2d TextOrigin, GeometryIntent Intent, bool ArrowheadsInside = false, bool LeaderFromCenter = false, bool SingleDimensionLine = true, object DimensionStyle = Missing, object Layer = Missing);
    LinearGeneralDimension AddLinear(Point2d TextOrigin, GeometryIntent IntentOne, object IntentTwo = Missing, DimensionTypeEnum DimensionType = DimensionTypeEnum.kAlignedDimensionType, bool ArrowheadsInside = true, object DimensionStyle = Missing, object Layer = Missing);
    LinearGeneralDimension AddLinear2(Point2d TextOrigin, GeometryIntent IntentOne, object IntentTwo = Missing, DimensionTypeEnum DimensionType = DimensionTypeEnum.kAlignedDimensionType, object AlignmentGeometry = Missing, bool ArrowheadsInside = true, object DimensionStyle = Missing, object Layer = Missing);
    LinearGeneralDimension AddLinearForeshortened(Point2d TextOrigin, GeometryIntent IntentOne, GeometryIntent IntentTwo, bool HideSecondArrowhead = false, object DimensionStyle = Missing, object Layer = Missing);
    LinearGeneralDimension AddLinearSum(Point2d TextOrigin, LinearGeneralDimension SpacingDimension, GeometryIntent IntentOne, object IntentTwo = Missing, bool ArrowheadsInside = true, object DimensionStyle = Missing, object Layer = Missing, object Reserved = Missing); // since 2026
    RadiusGeneralDimension AddRadius(Point2d TextOrigin, GeometryIntent Intent, bool ArrowheadsInside = false, bool LeaderFromCenter = false, bool Jogged = false, object DimensionStyle = Missing, object Layer = Missing);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingDimensions](../objects/DrawingDimensions.md).GeneralDimensions

**Referenced types:** [AngularGeneralDimension](../objects/AngularGeneralDimension.md), [DiameterGeneralDimension](../objects/DiameterGeneralDimension.md), [DimensionTypeEnum](../enums/DimensionTypeEnum.md), [GeneralDimension](../objects/GeneralDimension.md), [GeometryIntent](../objects/GeometryIntent.md), [LinearGeneralDimension](../objects/LinearGeneralDimension.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [RadiusGeneralDimension](../objects/RadiusGeneralDimension.md)

