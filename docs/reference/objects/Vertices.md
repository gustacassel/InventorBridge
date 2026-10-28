# Vertices

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Vertices`

```csharp
interface Vertices
{
    // Properties
    int Count { get; }
    Vertex Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Face](../objects/Face.md).Vertices, [FaceProxy](../objects/FaceProxy.md).Vertices, [SurfaceBody](../objects/SurfaceBody.md).Vertices, [SurfaceBodyProxy](../objects/SurfaceBodyProxy.md).Vertices

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Vertex](../objects/Vertex.md)

