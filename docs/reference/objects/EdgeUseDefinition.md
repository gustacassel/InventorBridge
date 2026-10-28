# EdgeUseDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).EdgeDefinitions.Item[…].FaceOne.EdgeLoopDefinitions.Item[…].EdgeUseDefinitions.Item[…]`

```csharp
interface EdgeUseDefinition
{
    // Properties
    object Application { get; }
    EdgeDefinition EdgeDefinition { get; set; }
    bool IsOpposedToEdge { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [EdgeUseDefinitions](../objects/EdgeUseDefinitions.md).Add, [EdgeUseDefinitions](../objects/EdgeUseDefinitions.md).Item

**Referenced types:** [EdgeDefinition](../objects/EdgeDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

