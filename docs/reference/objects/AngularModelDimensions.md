# AngularModelDimensions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDimensions.AngularModelDimensions`

```csharp
interface AngularModelDimensions
{
    // Properties
    object Application { get; }
    int Count { get; }
    AngularModelDimension Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    AngularModelDimension Add(AngularModelDimensionDefinition Definition);
    AngularModelDimensionDefinition CreateDefinition(GeometryIntent IntentOne, GeometryIntent IntentTwo, GeometryIntent IntentThree, AnnotationPlaneDefinition AnnotationPlaneDefinition, Point TextPosition);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelDimensions](../objects/ModelDimensions.md).AngularModelDimensions

**Referenced types:** [AngularModelDimension](../objects/AngularModelDimension.md), [AngularModelDimensionDefinition](../objects/AngularModelDimensionDefinition.md), [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [GeometryIntent](../objects/GeometryIntent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

