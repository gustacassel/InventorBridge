# ModelDimensionDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDimensions.Item[…].Definition`

```csharp
interface ModelDimensionDefinition
{
    // Properties
    AnnotationPlane AnnotationPlane { get; set; }
    AnnotationPlaneDefinition AnnotationPlaneDefinition { get; set; }
    object Application { get; }
    bool IsInspectionDimension { get; set; }
    bool IsModelValueOverridden { get; set; }
    bool IsValueHidden { get; set; }
    double OverrideModelValue { get; set; }
    ModelDimension Parent { get; }
    int Precision { get; set; }
    ModelAnnotationText Text { get; }
    Point TextPosition { get; set; }
    Tolerance Tolerance { get; }
    int TolerancePrecision { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetInspectionDimensionData(out InspectionDimensionShapeEnum Shape, out string Label, out string Rate);
    bool IsValidAnnotationPlane(object pPlane);
    void SetInspectionDimensionData(InspectionDimensionShapeEnum Shape = InspectionDimensionShapeEnum.kNoInspectionBorder, string Label = "", string Rate = "");
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngularModelDimension](../objects/AngularModelDimension.md).Definition, [AngularModelDimensionProxy](../objects/AngularModelDimensionProxy.md).Definition, [DiameterModelDimension](../objects/DiameterModelDimension.md).Definition, [DiameterModelDimensionProxy](../objects/DiameterModelDimensionProxy.md).Definition, [LinearModelDimension](../objects/LinearModelDimension.md).Definition, [LinearModelDimensionProxy](../objects/LinearModelDimensionProxy.md).Definition, [ModelDimension](../objects/ModelDimension.md).Definition, [RadiusModelDimension](../objects/RadiusModelDimension.md).Definition, [RadiusModelDimensionProxy](../objects/RadiusModelDimensionProxy.md).Definition

**Referenced types:** [AnnotationPlane](../objects/AnnotationPlane.md), [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [InspectionDimensionShapeEnum](../enums/InspectionDimensionShapeEnum.md), [ModelAnnotationText](../objects/ModelAnnotationText.md), [ModelDimension](../objects/ModelDimension.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Tolerance](../objects/Tolerance.md)

