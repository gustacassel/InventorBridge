# EdgeDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).EdgeDefinitions.Item[…]`

```csharp
interface EdgeDefinition
{
    // Properties
    object Application { get; }
    int AssociativeID { get; set; }
    VertexDefinition EndVertex { get; set; }
    FaceDefinition FaceOne { get; set; }
    FaceDefinition FaceTwo { get; set; }
    bool IsParamReversed { get; set; }
    object ModelSpaceCurve { get; set; }
    object ParameterSpaceCurveOne { get; set; }
    object ParameterSpaceCurveTwo { get; set; }
    VertexDefinition StartVertex { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [EdgeDefinitions](../objects/EdgeDefinitions.md).Add, [EdgeDefinitions](../objects/EdgeDefinitions.md).Item, [EdgeUseDefinition](../objects/EdgeUseDefinition.md).EdgeDefinition

**Referenced types:** [FaceDefinition](../objects/FaceDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [VertexDefinition](../objects/VertexDefinition.md)

