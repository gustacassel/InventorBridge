# ModelLeaderNode

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelSurfaceTextureSymbols.Item[…].Definition.RootNode`

```csharp
interface ModelLeaderNode
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ModelLeaderNodesEnumerator ChildNodes { get; }
    GeometryIntent Intent { get; set; }
    object Parent { get; }
    Point Position { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddLeader(ObjectCollection Points);
    void Delete(bool RetainDependentNodes = false);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    ModelLeaderNode InsertNode(ModelLeaderNode ChildNode, Point Position);
}
```

**Returned by:** [ModelLeader](../objects/ModelLeader.md).RootNode, [ModelLeaderNode](../objects/ModelLeaderNode.md).InsertNode, [ModelLeaderNodesEnumerator](../objects/ModelLeaderNodesEnumerator.md).Item, [ModelSurfaceTextureSymbolDefinition](../objects/ModelSurfaceTextureSymbolDefinition.md).RootNode

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [GeometryIntent](../objects/GeometryIntent.md), [ModelLeaderNodesEnumerator](../objects/ModelLeaderNodesEnumerator.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

