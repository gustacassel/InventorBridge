# ParallelToXAxisConstraint3D

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GeometricConstraint3D](../objects/GeometricConstraint3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].GeometricConstraints3D.Item[…] → (ParallelToXAxisConstraint3D)`

```csharp
interface ParallelToXAxisConstraint3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Deletable { get; }
    SketchLine3D Line { get; }
    Sketch3D Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [GeometricConstraints3D](../objects/GeometricConstraints3D.md).AddParallelToXAxis, [ParallelToXAxisConstraint3DProxy](../objects/ParallelToXAxisConstraint3DProxy.md).NativeObject

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch3D](../objects/Sketch3D.md), [SketchLine3D](../objects/SketchLine3D.md)

