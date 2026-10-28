# TwoPointDistanceDimConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [TwoPointDistanceDimConstraint](../objects/TwoPointDistanceDimConstraint.md) → [DimensionConstraint](../objects/DimensionConstraint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].DimensionConstraints.Item[…] → (TwoPointDistanceDimConstraint) → (TwoPointDistanceDimConstraintProxy)`

```csharp
interface TwoPointDistanceDimConstraintProxy
{
    // Properties
    ObjectCollection AnchorPoints { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    Point2d DimensionCenterPoint { get; }
    bool Driven { get; set; }
    TwoPointDistanceDimConstraint NativeObject { get; }
    DimensionOrientationEnum Orientation { get; }
    Parameter Parameter { get; }
    Sketch Parent { get; }
    SketchPoint PointOne { get; }
    SketchPoint PointTwo { get; }
    Point2d TextPoint { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void FlipDirection(); // since 2026
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [DimensionOrientationEnum](../enums/DimensionOrientationEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [Point2d](../objects/Point2d.md), [Sketch](../objects/Sketch.md), [SketchPoint](../objects/SketchPoint.md), [TwoPointDistanceDimConstraint](../objects/TwoPointDistanceDimConstraint.md)

