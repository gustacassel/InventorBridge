# FaceShell

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].FaceShells.Item[…]`

```csharp
interface FaceShell
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Edges Edges { get; }
    Faces Faces { get; }
    bool IsClosed { get; }
    ContainmentEnum IsPointInside[out double[] Point, bool UseBox = true] { get; }
    bool IsVoid { get; }
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

**Returned by:** [Face](../objects/Face.md).FaceShell, [FaceProxy](../objects/FaceProxy.md).FaceShell, [FaceShellProxy](../objects/FaceShellProxy.md).NativeObject, [FaceShells](../objects/FaceShells.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ContainmentEnum](../enums/ContainmentEnum.md), [Edges](../objects/Edges.md), [Faces](../objects/Faces.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceBody](../objects/SurfaceBody.md)

