# LeaderNode

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.SketchedSymbols.Item[…].Leader.RootNode`

```csharp
interface LeaderNode
{
    // Properties
    object Application { get; }
    GeometryIntent AttachedEntity { get; set; }
    AttributeSets AttributeSets { get; }
    LeaderNodesEnumerator ChildNodes { get; }
    object Parent { get; }
    Point2d Position { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddLeader(ObjectCollection Points);
    void Delete(bool RetainDependentNodes = false);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    LeaderNode InsertNode(LeaderNode ChildNode, Point2d Position);
}
```

**Returned by:** [Leader](../objects/Leader.md).RootNode, [LeaderNode](../objects/LeaderNode.md).InsertNode, [LeaderNodesEnumerator](../objects/LeaderNodesEnumerator.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [GeometryIntent](../objects/GeometryIntent.md), [LeaderNodesEnumerator](../objects/LeaderNodesEnumerator.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md)

