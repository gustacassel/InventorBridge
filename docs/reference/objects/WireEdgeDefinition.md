# WireEdgeDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).LumpDefinitions.Item[…].FaceShellDefinitions.Item[…].WireDefinitions.Item[…].WireEdgeDefinitions.Item[…]`

```csharp
interface WireEdgeDefinition
{
    // Properties
    object Application { get; }
    int AssociativeID { get; set; }
    VertexDefinition EndVertex { get; set; }
    bool IsParamReversed { get; set; }
    object ModelSpaceCurve { get; set; }
    VertexDefinition StartVertex { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [WireEdgeDefinitions](../objects/WireEdgeDefinitions.md).Add, [WireEdgeDefinitions](../objects/WireEdgeDefinitions.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [VertexDefinition](../objects/VertexDefinition.md)

