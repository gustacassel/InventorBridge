# SurfaceGraphicsVertexList

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…].Item[…].AddSurfaceGraphics(…).DisplayedVertices`

```csharp
interface SurfaceGraphicsVertexList
{
    // Properties
    object Application { get; }
    int Count { get; }
    SurfaceGraphicsVertex Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(object Vertex);
    void Clear();
    void Remove(int Index);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SurfaceGraphics](../objects/SurfaceGraphics.md).DisplayedVertices

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceGraphicsVertex](../objects/SurfaceGraphicsVertex.md)

