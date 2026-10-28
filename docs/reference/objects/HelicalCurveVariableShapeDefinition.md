# HelicalCurveVariableShapeDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [HelicalCurveDefinition](../objects/HelicalCurveDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].HelicalCurves.Item[…].Definition → (HelicalCurveVariableShapeDefinition)`

```csharp
interface HelicalCurveVariableShapeDefinition
{
    // Properties
    object Application { get; }
    Point AxisEndPoint { get; set; }
    Point AxisStartPoint { get; set; }
    bool Clockwise { get; set; }
    Point CurveStart { get; set; }
    HelicalCurve Parent { get; }
    HelicalCurveShapeDefinitionRows ShapeDefinitionRows { get; }
    HelicalShapeDefinitionTypeEnum ShapeDefinitionType { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    HelicalCurveDefinition Copy();
}
```

**Returned by:** [HelicalCurveShapeDefinitionRow](../objects/HelicalCurveShapeDefinitionRow.md).Parent, [HelicalCurves](../objects/HelicalCurves.md).CreateVariableShapeDefinition

**Referenced types:** [HelicalCurve](../objects/HelicalCurve.md), [HelicalCurveDefinition](../objects/HelicalCurveDefinition.md), [HelicalCurveShapeDefinitionRows](../objects/HelicalCurveShapeDefinitionRows.md), [HelicalShapeDefinitionTypeEnum](../enums/HelicalShapeDefinitionTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

