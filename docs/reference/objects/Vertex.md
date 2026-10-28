# Vertex

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Vertices.Item[…]`

```csharp
interface Vertex
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Edges Edges { get; }
    Faces Faces { get; }
    bool IsTolerant { get; }
    SurfaceBody Parent { get; }
    Point Point { get; }
    double Tolerance { get; }
    int TransientKey { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetPoint(out double[] Point);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    Vertex GetSourceVertex(bool GetLeafSource = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Edge](../objects/Edge.md).StartVertex, [Edge](../objects/Edge.md).StopVertex, [EdgeProxy](../objects/EdgeProxy.md).StartVertex, [EdgeProxy](../objects/EdgeProxy.md).StopVertex, [FilletSetbackVertex](../objects/FilletSetbackVertex.md).Vertex, [SurfaceGraphicsVertex](../objects/SurfaceGraphicsVertex.md).Vertex, [UnwrapDefinition](../objects/UnwrapDefinition.md).Origin, [Vertex](../objects/Vertex.md).GetSourceVertex, [VertexProxy](../objects/VertexProxy.md).GetSourceVertex, [VertexProxy](../objects/VertexProxy.md).NativeObject, [Vertices](../objects/Vertices.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Edges](../objects/Edges.md), [Faces](../objects/Faces.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [SurfaceBody](../objects/SurfaceBody.md)

