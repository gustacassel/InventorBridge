# CoincidentConstraint3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [CoincidentConstraint3D](../objects/CoincidentConstraint3D.md) → [GeometricConstraint3D](../objects/GeometricConstraint3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].GeometricConstraints3D.Item[…] → (CoincidentConstraint3D) → (CoincidentConstraint3DProxy)`

```csharp
interface CoincidentConstraint3DProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    object ConnectedEntity { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    object EntityOne { get; }
    object EntityTwo { get; }
    CoincidentConstraint3D NativeObject { get; }
    Sketch3D Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void Disconnect(object Entity);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [CoincidentConstraint3D](../objects/CoincidentConstraint3D.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch3D](../objects/Sketch3D.md)

