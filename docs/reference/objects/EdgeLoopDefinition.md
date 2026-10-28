# EdgeLoopDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).EdgeDefinitions.Item[…].FaceOne.EdgeLoopDefinitions.Item[…]`

```csharp
interface EdgeLoopDefinition
{
    // Properties
    object Application { get; }
    EdgeUseDefinitions EdgeUseDefinitions { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [EdgeLoopDefinitions](../objects/EdgeLoopDefinitions.md).Add, [EdgeLoopDefinitions](../objects/EdgeLoopDefinitions.md).Item

**Referenced types:** [EdgeUseDefinitions](../objects/EdgeUseDefinitions.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

