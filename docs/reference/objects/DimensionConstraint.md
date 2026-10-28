# DimensionConstraint

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].DimensionConstraints.Item[…]`

```csharp
interface DimensionConstraint
{
    // Properties
    ObjectCollection AnchorPoints { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Point2d DimensionCenterPoint { get; }
    bool Driven { get; set; }
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

**Returned by:** [AngularGeneralDimension](../objects/AngularGeneralDimension.md).PromoteToSketch, [DiameterGeneralDimension](../objects/DiameterGeneralDimension.md).PromoteToSketch, [DimensionConstraints](../objects/DimensionConstraints.md).Item, [GeneralDimension](../objects/GeneralDimension.md).PromoteToSketch, [HoleThreadNote](../objects/HoleThreadNote.md).PromoteToSketch, [LinearGeneralDimension](../objects/LinearGeneralDimension.md).PromoteToSketch, [RadiusGeneralDimension](../objects/RadiusGeneralDimension.md).PromoteToSketch

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [Point2d](../objects/Point2d.md), [Sketch](../objects/Sketch.md)

