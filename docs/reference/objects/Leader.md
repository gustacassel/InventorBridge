# Leader

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.SketchedSymbols.Item[…].Leader`

```csharp
interface Leader
{
    // Properties
    LeaderNodesEnumerator AllLeafNodes { get; }
    LeaderNodesEnumerator AllNodes { get; }
    object Application { get; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    AttributeSets AttributeSets { get; }
    bool HasRootNode { get; }
    object Parent { get; }
    LeaderNode RootNode { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddLeader(ObjectCollection Points);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [Balloon](../objects/Balloon.md).Leader, [BendNote](../objects/BendNote.md).Leader, [ChamferNote](../objects/ChamferNote.md).Leader, [DrawingWeldingSymbol](../objects/DrawingWeldingSymbol.md).Leader, [FeatureControlFrame](../objects/FeatureControlFrame.md).Leader, [HoleTag](../objects/HoleTag.md).Leader, [LeaderNote](../objects/LeaderNote.md).Leader, [PunchNote](../objects/PunchNote.md).Leader, [SketchedSymbol](../objects/SketchedSymbol.md).Leader, [SurfaceTextureSymbol](../objects/SurfaceTextureSymbol.md).Leader, [TransitionSymbol](../objects/TransitionSymbol.md).Leader

**Referenced types:** [ArrowheadTypeEnum](../enums/ArrowheadTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [LeaderNode](../objects/LeaderNode.md), [LeaderNodesEnumerator](../objects/LeaderNodesEnumerator.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

