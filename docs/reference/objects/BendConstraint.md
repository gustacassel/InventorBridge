# BendConstraint

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GeometricConstraint3D](../objects/GeometricConstraint3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].GeometricConstraints3D.Item[…] → (BendConstraint)`

```csharp
interface BendConstraint
{
    // Properties
    object Application { get; }
    SketchArc3D Arc { get; }
    AttributeSets AttributeSets { get; }
    bool Deletable { get; }
    SketchLine3D LineOne { get; }
    SketchLine3D LineTwo { get; }
    Sketch3D Parent { get; }
    Parameter Radius { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [BendConstraintProxy](../objects/BendConstraintProxy.md).NativeObject

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [Sketch3D](../objects/Sketch3D.md), [SketchArc3D](../objects/SketchArc3D.md), [SketchLine3D](../objects/SketchLine3D.md)

