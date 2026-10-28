# WireEdgeDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).LumpDefinitions.Item[…].FaceShellDefinitions.Item[…].WireDefinitions.Item[…].WireEdgeDefinitions`

```csharp
interface WireEdgeDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    WireEdgeDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    WireEdgeDefinition Add(VertexDefinition StartVertex, VertexDefinition EndVertex, object ModelSpaceCurve);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [WireDefinition](../objects/WireDefinition.md).WireEdgeDefinitions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [VertexDefinition](../objects/VertexDefinition.md), [WireEdgeDefinition](../objects/WireEdgeDefinition.md)

