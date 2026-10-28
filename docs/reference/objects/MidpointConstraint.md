# MidpointConstraint

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GeometricConstraint](../objects/GeometricConstraint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].GeometricConstraints.Item[…] → (MidpointConstraint)`

```csharp
interface MidpointConstraint
{
    // Properties
    object Application { get; }
    SketchArc Arc { get; }
    AttributeSets AttributeSets { get; }
    bool Deletable { get; }
    SketchLine Line { get; }
    Sketch Parent { get; }
    SketchPoint Point { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [GeometricConstraints](../objects/GeometricConstraints.md).AddMidPointToArc, [GeometricConstraints](../objects/GeometricConstraints.md).AddMidpoint, [MidpointConstraintProxy](../objects/MidpointConstraintProxy.md).NativeObject

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [SketchArc](../objects/SketchArc.md), [SketchLine](../objects/SketchLine.md), [SketchPoint](../objects/SketchPoint.md)

