# AngularModelDimensionDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ModelDimensionDefinition](../objects/ModelDimensionDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDimensions.Item[…].Definition → (AngularModelDimensionDefinition)`

```csharp
interface AngularModelDimensionDefinition
{
    // Properties
    AnnotationPlane AnnotationPlane { get; set; }
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    object Application { get; }
    bool ArrowheadsInside { get; set; }
    ArrowheadTypeEnum FirstArrowheadType { get; set; }
    GeometryIntent IntentOne { get; set; }
    GeometryIntent IntentThree { get; set; }
    GeometryIntent IntentTwo { get; set; }
    bool IsExtensionLineOneVisible { get; set; }
    bool IsExtensionLineTwoVisible { get; set; }
    bool IsFirstArrowheadInside { get; set; }
    bool IsInspectionDimension { get; set; }
    bool IsModelValueOverridden { get; set; }
    bool IsSecondArrowheadInside { get; set; }
    bool IsValueHidden { get; set; }
    bool OppositeAngle { get; set; }
    double OverrideModelValue { get; set; }
    ModelDimension Parent { get; }
    int Precision { get; set; }
    ArrowheadTypeEnum SecondArrowheadType { get; set; }
    ModelAnnotationText Text { get; }
    Point TextPosition { get; set; }
    Tolerance Tolerance { get; }
    int TolerancePrecision { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseQuadrant { get; set; }
    // Methods
    AngularModelDimensionDefinition Copy();
    void GetInspectionDimensionData(out InspectionDimensionShapeEnum Shape, out string Label, out string Rate);
    bool IsValidAnnotationPlane(object pPlane);
    void SetInspectionDimensionData(InspectionDimensionShapeEnum Shape = InspectionDimensionShapeEnum.kNoInspectionBorder, string Label = "", string Rate = "");
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngularModelDimensionDefinition](../objects/AngularModelDimensionDefinition.md).Copy, [AngularModelDimensions](../objects/AngularModelDimensions.md).CreateDefinition

**Referenced types:** [AnnotationPlane](../objects/AnnotationPlane.md), [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [ArrowheadTypeEnum](../enums/ArrowheadTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [InspectionDimensionShapeEnum](../enums/InspectionDimensionShapeEnum.md), [ModelAnnotationText](../objects/ModelAnnotationText.md), [ModelDimension](../objects/ModelDimension.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Tolerance](../objects/Tolerance.md)

