# FaceShellProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [FaceShell](../objects/FaceShell.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].FaceShells.Item[…] → (FaceShellProxy)`

```csharp
interface FaceShellProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    Edges Edges { get; }
    Faces Faces { get; }
    bool IsClosed { get; }
    ContainmentEnum IsPointInside[out double[] Point, bool UseBox = true] { get; }
    bool IsVoid { get; }
    FaceShell NativeObject { get; }
    SurfaceBody Parent { get; }
    Box RangeBox { get; }
    SurfaceBody SurfaceBody { get; }
    int TransientKey { get; }
    ObjectTypeEnum Type { get; }
    double Volume[double PrecisionPercent] { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ContainmentEnum](../enums/ContainmentEnum.md), [Edges](../objects/Edges.md), [FaceShell](../objects/FaceShell.md), [Faces](../objects/Faces.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceBody](../objects/SurfaceBody.md)

