# HelicalCurveConstantShapeDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [HelicalCurveDefinition](../objects/HelicalCurveDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].HelicalCurves.Item[…].Definition → (HelicalCurveConstantShapeDefinition)`

```csharp
interface HelicalCurveConstantShapeDefinition
{
    // Properties
    object Application { get; }
    Point AxisEndPoint { get; set; }
    Point AxisStartPoint { get; set; }
    bool Clockwise { get; set; }
    Point CurveStart { get; set; }
    object Diameter { get; set; }
    object Height { get; set; }
    HelixEndTypeEnum HelixEndEndType { get; set; }
    object HelixEndFlatAngle { get; set; }
    object HelixEndTransitionAngle { get; set; }
    HelixEndTypeEnum HelixStartEndType { get; set; }
    object HelixStartFlatAngle { get; set; }
    object HelixStartTransitionAngle { get; set; }
    HelicalCurve Parent { get; }
    object Pitch { get; set; }
    object Revolution { get; set; }
    HelicalShapeDefinitionTypeEnum ShapeDefinitionType { get; set; }
    object Taper { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    HelicalCurveDefinition Copy();
}
```

**Returned by:** [HelicalCurves](../objects/HelicalCurves.md).CreateConstantShapeDefinition

**Referenced types:** [HelicalCurve](../objects/HelicalCurve.md), [HelicalCurveDefinition](../objects/HelicalCurveDefinition.md), [HelicalShapeDefinitionTypeEnum](../enums/HelicalShapeDefinitionTypeEnum.md), [HelixEndTypeEnum](../enums/HelixEndTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

