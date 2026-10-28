# LinearModelDimensions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDimensions.LinearModelDimensions`

```csharp
interface LinearModelDimensions
{
    // Properties
    object Application { get; }
    int Count { get; }
    LinearModelDimension Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    LinearModelDimension Add(LinearModelDimensionDefinition Definition);
    LinearModelDimensionDefinition CreateDefinition(GeometryIntent IntentOne, GeometryIntent IntentTwo, AnnotationPlaneDefinition AnnotationPlaneDefinition, Point TextPosition, DimensionTypeEnum DimensionType);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelDimensions](../objects/ModelDimensions.md).LinearModelDimensions

**Referenced types:** [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [DimensionTypeEnum](../enums/DimensionTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [LinearModelDimension](../objects/LinearModelDimension.md), [LinearModelDimensionDefinition](../objects/LinearModelDimensionDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

