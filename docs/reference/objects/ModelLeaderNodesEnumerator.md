# ModelLeaderNodesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelSurfaceTextureSymbols.Item[…].Definition.AllLeafNodes`

```csharp
interface ModelLeaderNodesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    ModelLeaderNode Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelLeader](../objects/ModelLeader.md).AllLeafNodes, [ModelLeader](../objects/ModelLeader.md).AllNodes, [ModelLeaderNode](../objects/ModelLeaderNode.md).ChildNodes, [ModelSurfaceTextureSymbolDefinition](../objects/ModelSurfaceTextureSymbolDefinition.md).AllLeafNodes, [ModelSurfaceTextureSymbolDefinition](../objects/ModelSurfaceTextureSymbolDefinition.md).AllNodes

**Referenced types:** [ModelLeaderNode](../objects/ModelLeaderNode.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

