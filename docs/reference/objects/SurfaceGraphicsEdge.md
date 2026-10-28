# SurfaceGraphicsEdge

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…].Item[…].AddSurfaceGraphics(…).DisplayedEdges.Item[…]`

```csharp
interface SurfaceGraphicsEdge
{
    // Properties
    object Application { get; }
    Color Color { get; set; }
    Edge Edge { get; }
    int Index { get; }
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    double LineScale { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    SurfaceGraphics Parent { get; }
    bool Selectable { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
}
```

**Returned by:** [SurfaceGraphicsEdgeList](../objects/SurfaceGraphicsEdgeList.md).Item

**Referenced types:** [Color](../objects/Color.md), [Edge](../objects/Edge.md), [LineDefinitionSpaceEnum](../enums/LineDefinitionSpaceEnum.md), [LineTypeEnum](../enums/LineTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceGraphics](../objects/SurfaceGraphics.md)

