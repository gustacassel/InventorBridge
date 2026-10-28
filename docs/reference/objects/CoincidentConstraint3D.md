# CoincidentConstraint3D

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GeometricConstraint3D](../objects/GeometricConstraint3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].GeometricConstraints3D.Item[…] → (CoincidentConstraint3D)`

```csharp
interface CoincidentConstraint3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    object ConnectedEntity { get; }
    bool Deletable { get; }
    object EntityOne { get; }
    object EntityTwo { get; }
    Sketch3D Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void Disconnect(object Entity);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CoincidentConstraint3DProxy](../objects/CoincidentConstraint3DProxy.md).NativeObject, [GeometricConstraints3D](../objects/GeometricConstraints3D.md).AddCoincident

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch3D](../objects/Sketch3D.md)

