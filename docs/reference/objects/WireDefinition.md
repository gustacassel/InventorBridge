# WireDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientBRep.CreateSurfaceBodyDefinition(…).LumpDefinitions.Item[…].FaceShellDefinitions.Item[…].WireDefinitions.Item[…]`

```csharp
interface WireDefinition
{
    // Properties
    object Application { get; }
    ObjectTypeEnum Type { get; }
    WireEdgeDefinitions WireEdgeDefinitions { get; }
}
```

**Returned by:** [WireDefinitions](../objects/WireDefinitions.md).Add, [WireDefinitions](../objects/WireDefinitions.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WireEdgeDefinitions](../objects/WireEdgeDefinitions.md)

