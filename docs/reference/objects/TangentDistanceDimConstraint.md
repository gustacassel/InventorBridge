# TangentDistanceDimConstraint

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [DimensionConstraint](../objects/DimensionConstraint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].DimensionConstraints.Item[…] → (TangentDistanceDimConstraint)`

```csharp
interface TangentDistanceDimConstraint
{
    // Properties
    ObjectCollection AnchorPoints { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Point2d DimensionCenterPoint { get; }
    bool Driven { get; set; }
    SketchEntity EntityOne { get; }
    SketchEntity EntityTwo { get; }
    bool LinearDiameter { get; }
    Parameter Parameter { get; }
    Sketch Parent { get; }
    Point2d ProximityPointOne { get; }
    Point2d ProximityPointTwo { get; }
    Point2d TextPoint { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void FlipDirection(); // since 2026
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DimensionConstraints](../objects/DimensionConstraints.md).AddTangentDistance, [TangentDistanceDimConstraintProxy](../objects/TangentDistanceDimConstraintProxy.md).NativeObject

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [Point2d](../objects/Point2d.md), [Sketch](../objects/Sketch.md), [SketchEntity](../objects/SketchEntity.md)

