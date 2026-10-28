# EdgeDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).EdgeDefinitions`

```csharp
interface EdgeDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    EdgeDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    EdgeDefinition Add(VertexDefinition StartVertex, VertexDefinition EndVertex, object ModelSpaceCurve = Missing, object ParameterSpaceCurveOne = Missing, object FaceOne = Missing, object ParameterSpaceCurveTwo = Missing, object FaceTwo = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SurfaceBodyDefinition](../objects/SurfaceBodyDefinition.md).EdgeDefinitions

**Referenced types:** [EdgeDefinition](../objects/EdgeDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [VertexDefinition](../objects/VertexDefinition.md)

