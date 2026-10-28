# SurfaceGraphicsEdgeList

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…].Item[…].AddSurfaceGraphics(…).DisplayedEdges`

```csharp
interface SurfaceGraphicsEdgeList
{
    // Properties
    object Application { get; }
    int Count { get; }
    SurfaceGraphicsEdge Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(object Edges);
    void Clear();
    void Remove(int Index);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ComponentGraphics](../objects/ComponentGraphics.md).DisplayedEdges, [SurfaceGraphics](../objects/SurfaceGraphics.md).DisplayedEdges

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceGraphicsEdge](../objects/SurfaceGraphicsEdge.md)

