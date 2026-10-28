# LineLengthDimConstraint3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [LineLengthDimConstraint3D](../objects/LineLengthDimConstraint3D.md) → [DimensionConstraint3D](../objects/DimensionConstraint3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].DimensionConstraints3D.Item[…] → (LineLengthDimConstraint3D) → (LineLengthDimConstraint3DProxy)`

```csharp
interface LineLengthDimConstraint3DProxy
{
    // Properties
    ObjectCollection AnchorPoints { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    Plane DimensionPlane { get; }
    bool Driven { get; set; }
    SketchLine3D Line { get; }
    LineLengthDimConstraint3D NativeObject { get; }
    Parameter Parameter { get; }
    Sketch3D Parent { get; }
    Point TextPoint { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [LineLengthDimConstraint3D](../objects/LineLengthDimConstraint3D.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [Plane](../objects/Plane.md), [Point](../objects/Point.md), [Sketch3D](../objects/Sketch3D.md), [SketchLine3D](../objects/SketchLine3D.md)

