# VertexProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Vertex](../objects/Vertex.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Vertices.Item[…] → (VertexProxy)`

```csharp
interface VertexProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    Edges Edges { get; }
    Faces Faces { get; }
    bool IsTolerant { get; }
    Vertex NativeObject { get; }
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

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [Edges](../objects/Edges.md), [Faces](../objects/Faces.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [SurfaceBody](../objects/SurfaceBody.md), [Vertex](../objects/Vertex.md)

