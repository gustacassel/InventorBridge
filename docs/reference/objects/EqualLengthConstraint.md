# EqualLengthConstraint

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GeometricConstraint](../objects/GeometricConstraint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].GeometricConstraints.Item[…] → (EqualLengthConstraint)`

```csharp
interface EqualLengthConstraint
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Deletable { get; }
    SketchLine LineOne { get; }
    SketchLine LineTwo { get; }
    Sketch Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [EqualLengthConstraintProxy](../objects/EqualLengthConstraintProxy.md).NativeObject, [GeometricConstraints](../objects/GeometricConstraints.md).AddEqualLength

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [SketchLine](../objects/SketchLine.md)

