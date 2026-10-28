# ConcentricConstraint

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GeometricConstraint](../objects/GeometricConstraint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].GeometricConstraints.Item[…] → (ConcentricConstraint)`

```csharp
interface ConcentricConstraint
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool CenterPointConstraint { get; }
    bool Deletable { get; }
    SketchEntity EntityOne { get; }
    SketchEntity EntityTwo { get; }
    Sketch Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [ConcentricConstraintProxy](../objects/ConcentricConstraintProxy.md).NativeObject, [GeometricConstraints](../objects/GeometricConstraints.md).AddConcentric

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [SketchEntity](../objects/SketchEntity.md)

