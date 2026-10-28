# EqualConstraint3D

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GeometricConstraint3D](../objects/GeometricConstraint3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].GeometricConstraints3D.Item[…] → (EqualConstraint3D)`

```csharp
interface EqualConstraint3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Deletable { get; }
    SketchEntity3D EntityOne { get; }
    SketchEntity3D EntityTwo { get; }
    Sketch3D Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [EqualConstraint3DProxy](../objects/EqualConstraint3DProxy.md).NativeObject, [GeometricConstraints3D](../objects/GeometricConstraints3D.md).AddEqual

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch3D](../objects/Sketch3D.md), [SketchEntity3D](../objects/SketchEntity3D.md)

