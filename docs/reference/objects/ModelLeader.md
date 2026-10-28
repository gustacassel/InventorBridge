# ModelLeader

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelSurfaceTextureSymbols.Item[…].Definition.Leader`

```csharp
interface ModelLeader
{
    // Properties
    ModelLeaderNodesEnumerator AllLeafNodes { get; }
    ModelLeaderNodesEnumerator AllNodes { get; }
    object Application { get; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    AttributeSets AttributeSets { get; }
    bool HasRootNode { get; }
    object Parent { get; }
    ModelLeaderNode RootNode { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddLeader(ObjectCollection Points);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [ModelFeatureControlFrameDefinition](../objects/ModelFeatureControlFrameDefinition.md).Leader, [ModelLeaderNoteDefinition](../objects/ModelLeaderNoteDefinition.md).Leader, [ModelSurfaceTextureSymbolDefinition](../objects/ModelSurfaceTextureSymbolDefinition.md).Leader, [ModelWeldingSymbolDefinitions](../objects/ModelWeldingSymbolDefinitions.md).Leader

**Referenced types:** [ArrowheadTypeEnum](../enums/ArrowheadTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [ModelLeaderNode](../objects/ModelLeaderNode.md), [ModelLeaderNodesEnumerator](../objects/ModelLeaderNodesEnumerator.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

