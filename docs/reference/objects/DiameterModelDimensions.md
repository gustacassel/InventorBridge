# DiameterModelDimensions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDimensions.DiameterModelDimensions`

```csharp
interface DiameterModelDimensions
{
    // Properties
    object Application { get; }
    int Count { get; }
    DiameterModelDimension Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DiameterModelDimension Add(DiameterModelDimensionDefinition Definition);
    DiameterModelDimensionDefinition CreateDefinition(GeometryIntent Intent, AnnotationPlaneDefinition AnnotationPlaneDefinition, Point LandingPosition);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelDimensions](../objects/ModelDimensions.md).DiameterModelDimensions

**Referenced types:** [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [DiameterModelDimension](../objects/DiameterModelDimension.md), [DiameterModelDimensionDefinition](../objects/DiameterModelDimensionDefinition.md), [GeometryIntent](../objects/GeometryIntent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

