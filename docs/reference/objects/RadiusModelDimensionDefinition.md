# RadiusModelDimensionDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ModelDimensionDefinition](../objects/ModelDimensionDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDimensions.Item[…].Definition → (RadiusModelDimensionDefinition)`

```csharp
interface RadiusModelDimensionDefinition
{
    // Properties
    AnnotationPlane AnnotationPlane { get; set; }
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    object Application { get; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    GeometryIntent Intent { get; set; }
    bool IsArrowheadInside { get; set; }
    bool IsInspectionDimension { get; set; }
    bool IsJogged { get; set; }
    bool IsLeaderFromCenter { get; set; }
    bool IsModelValueOverridden { get; set; }
    bool IsValueHidden { get; set; }
    Point LandingPosition { get; set; }
    double OverrideModelValue { get; set; }
    ModelDimension Parent { get; }
    int Precision { get; set; }
    ModelAnnotationText Text { get; }
    Point TextPosition { get; set; }
    Tolerance Tolerance { get; }
    int TolerancePrecision { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    RadiusModelDimensionDefinition Copy();
    void GetInspectionDimensionData(out InspectionDimensionShapeEnum Shape, out string Label, out string Rate);
    bool IsValidAnnotationPlane(object pPlane);
    void SetInspectionDimensionData(InspectionDimensionShapeEnum Shape = InspectionDimensionShapeEnum.kNoInspectionBorder, string Label = "", string Rate = "");
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [RadiusModelDimensionDefinition](../objects/RadiusModelDimensionDefinition.md).Copy, [RadiusModelDimensions](../objects/RadiusModelDimensions.md).CreateDefinition

**Referenced types:** [AnnotationPlane](../objects/AnnotationPlane.md), [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [ArrowheadTypeEnum](../enums/ArrowheadTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [InspectionDimensionShapeEnum](../enums/InspectionDimensionShapeEnum.md), [ModelAnnotationText](../objects/ModelAnnotationText.md), [ModelDimension](../objects/ModelDimension.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Tolerance](../objects/Tolerance.md)

