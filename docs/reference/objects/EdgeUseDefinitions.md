# EdgeUseDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).EdgeDefinitions.Item[…].FaceOne.EdgeLoopDefinitions.Item[…].EdgeUseDefinitions`

```csharp
interface EdgeUseDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    EdgeUseDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    EdgeUseDefinition Add(EdgeDefinition EdgeDefinition, bool IsOpposedToEdge);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [EdgeLoopDefinition](../objects/EdgeLoopDefinition.md).EdgeUseDefinitions

**Referenced types:** [EdgeDefinition](../objects/EdgeDefinition.md), [EdgeUseDefinition](../objects/EdgeUseDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

