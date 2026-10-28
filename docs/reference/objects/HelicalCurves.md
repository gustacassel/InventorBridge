# HelicalCurves

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].HelicalCurves`

```csharp
interface HelicalCurves
{
    // Properties
    object Application { get; }
    int Count { get; }
    HelicalCurve Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    HelicalCurve Add(HelicalCurveDefinition HelicalCurveDefinition);
    HelicalCurveConstantShapeDefinition CreateConstantShapeDefinition(HelicalShapeDefinitionTypeEnum ShapeDefinitionType, Point AxisStartPoint, Point AxisEndPoint, Point CurveStartPoint, object Diameter, object Pitch = Missing, object Revolution = Missing, object Height = Missing);
    HelicalCurveVariableShapeDefinition CreateVariableShapeDefinition(HelicalShapeDefinitionTypeEnum ShapeDefinitionType, Point AxisStartPoint, Point AxisEndPoint, Point CurveStartPoint, object Diameter, object Pitch = Missing, object Revolution = Missing, object Height = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).HelicalCurves, [Sketch3DProxy](../objects/Sketch3DProxy.md).HelicalCurves

**Referenced types:** [HelicalCurve](../objects/HelicalCurve.md), [HelicalCurveConstantShapeDefinition](../objects/HelicalCurveConstantShapeDefinition.md), [HelicalCurveDefinition](../objects/HelicalCurveDefinition.md), [HelicalCurveVariableShapeDefinition](../objects/HelicalCurveVariableShapeDefinition.md), [HelicalShapeDefinitionTypeEnum](../enums/HelicalShapeDefinitionTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

