# RadiusModelDimensions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDimensions.RadiusModelDimensions`

```csharp
interface RadiusModelDimensions
{
    // Properties
    object Application { get; }
    int Count { get; }
    RadiusModelDimension Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RadiusModelDimension Add(RadiusModelDimensionDefinition Definition);
    RadiusModelDimensionDefinition CreateDefinition(GeometryIntent Intent, AnnotationPlaneDefinition AnnotationPlaneDefinition, Point LandingPosition);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelDimensions](../objects/ModelDimensions.md).RadiusModelDimensions

**Referenced types:** [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [GeometryIntent](../objects/GeometryIntent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [RadiusModelDimension](../objects/RadiusModelDimension.md), [RadiusModelDimensionDefinition](../objects/RadiusModelDimensionDefinition.md)

