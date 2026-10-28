# ModelFeatureControlFrames

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelFeatureControlFrames`

```csharp
interface ModelFeatureControlFrames
{
    // Properties
    object Application { get; }
    int Count { get; }
    ModelFeatureControlFrame Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelFeatureControlFrame Add(ModelFeatureControlFrameDefinition Definition);
    ModelFeatureControlFrameDefinition CreateDefinition(GeometryIntent Intent, AnnotationPlaneDefinition AnnotationPlaneDefinition, Point LandingPosition);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelAnnotations](../objects/ModelAnnotations.md).ModelFeatureControlFrames

**Referenced types:** [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md), [GeometryIntent](../objects/GeometryIntent.md), [ModelFeatureControlFrame](../objects/ModelFeatureControlFrame.md), [ModelFeatureControlFrameDefinition](../objects/ModelFeatureControlFrameDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

