# SurfaceGraphicsVertex

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…].Item[…].AddSurfaceGraphics(…).DisplayedVertices.Item[…]`

```csharp
interface SurfaceGraphicsVertex
{
    // Properties
    object Application { get; }
    int Index { get; }
    SurfaceGraphics Parent { get; }
    bool Selectable { get; set; }
    ObjectTypeEnum Type { get; }
    Vertex Vertex { get; }
}
```

**Returned by:** [SurfaceGraphicsVertexList](../objects/SurfaceGraphicsVertexList.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceGraphics](../objects/SurfaceGraphics.md), [Vertex](../objects/Vertex.md)

