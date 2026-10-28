# VertexDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).VertexDefinitions.Item[…]`

```csharp
interface VertexDefinition
{
    // Properties
    object Application { get; }
    int AssociativeID { get; set; }
    Point Position { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [EdgeDefinition](../objects/EdgeDefinition.md).EndVertex, [EdgeDefinition](../objects/EdgeDefinition.md).StartVertex, [VertexDefinitions](../objects/VertexDefinitions.md).Add, [VertexDefinitions](../objects/VertexDefinitions.md).Item, [WireEdgeDefinition](../objects/WireEdgeDefinition.md).EndVertex, [WireEdgeDefinition](../objects/WireEdgeDefinition.md).StartVertex

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

