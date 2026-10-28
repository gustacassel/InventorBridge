# HelicalCurveDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].HelicalCurves.Item[…].Definition`

```csharp
interface HelicalCurveDefinition
{
    // Properties
    object Application { get; }
    Point AxisEndPoint { get; set; }
    Point AxisStartPoint { get; set; }
    bool Clockwise { get; set; }
    Point CurveStart { get; set; }
    HelicalCurve Parent { get; }
    HelicalShapeDefinitionTypeEnum ShapeDefinitionType { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    HelicalCurveDefinition Copy();
}
```

**Returned by:** [HelicalCurve](../objects/HelicalCurve.md).Definition, [HelicalCurveConstantShapeDefinition](../objects/HelicalCurveConstantShapeDefinition.md).Copy, [HelicalCurveDefinition](../objects/HelicalCurveDefinition.md).Copy, [HelicalCurveProxy](../objects/HelicalCurveProxy.md).Definition, [HelicalCurveVariableShapeDefinition](../objects/HelicalCurveVariableShapeDefinition.md).Copy

**Referenced types:** [HelicalCurve](../objects/HelicalCurve.md), [HelicalShapeDefinitionTypeEnum](../enums/HelicalShapeDefinitionTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

