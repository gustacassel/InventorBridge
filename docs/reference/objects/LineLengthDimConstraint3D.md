# LineLengthDimConstraint3D

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [DimensionConstraint3D](../objects/DimensionConstraint3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].DimensionConstraints3D.Item[…] → (LineLengthDimConstraint3D)`

```csharp
interface LineLengthDimConstraint3D
{
    // Properties
    ObjectCollection AnchorPoints { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Plane DimensionPlane { get; }
    bool Driven { get; set; }
    SketchLine3D Line { get; }
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

**Returned by:** [DimensionConstraints3D](../objects/DimensionConstraints3D.md).AddLineLength, [LineLengthDimConstraint3DProxy](../objects/LineLengthDimConstraint3DProxy.md).NativeObject

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [Plane](../objects/Plane.md), [Point](../objects/Point.md), [Sketch3D](../objects/Sketch3D.md), [SketchLine3D](../objects/SketchLine3D.md)

