# TangentDistanceDimConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [TangentDistanceDimConstraint](../objects/TangentDistanceDimConstraint.md) → [DimensionConstraint](../objects/DimensionConstraint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].DimensionConstraints.Item[…] → (TangentDistanceDimConstraint) → (TangentDistanceDimConstraintProxy)`

```csharp
interface TangentDistanceDimConstraintProxy
{
    // Properties
    ObjectCollection AnchorPoints { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    Point2d DimensionCenterPoint { get; }
    bool Driven { get; set; }
    SketchEntity EntityOne { get; }
    SketchEntity EntityTwo { get; }
    bool LinearDiameter { get; }
    TangentDistanceDimConstraint NativeObject { get; }
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

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [Point2d](../objects/Point2d.md), [Sketch](../objects/Sketch.md), [SketchEntity](../objects/SketchEntity.md), [TangentDistanceDimConstraint](../objects/TangentDistanceDimConstraint.md)

