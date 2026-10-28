# RadiusDimConstraint

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [DimensionConstraint](../objects/DimensionConstraint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].DimensionConstraints.Item[…] → (RadiusDimConstraint)`

```csharp
interface RadiusDimConstraint
{
    // Properties
    ObjectCollection AnchorPoints { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Point2d DimensionCenterPoint { get; }
    bool Driven { get; set; }
    SketchEntity Entity { get; }
    Parameter Parameter { get; }
    Sketch Parent { get; }
    Point2d TextPoint { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DimensionConstraints](../objects/DimensionConstraints.md).AddRadius, [RadiusDimConstraintProxy](../objects/RadiusDimConstraintProxy.md).NativeObject

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [Point2d](../objects/Point2d.md), [Sketch](../objects/Sketch.md), [SketchEntity](../objects/SketchEntity.md)

