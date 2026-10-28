# HelicalCurveShapeDefinitionRows

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].HelicalCurves.Item[…].Definition → (HelicalCurveVariableShapeDefinition).ShapeDefinitionRows`

```csharp
interface HelicalCurveShapeDefinitionRows
{
    // Properties
    object Application { get; }
    int Count { get; }
    HelicalCurveShapeDefinitionRow Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    HelicalCurveShapeDefinitionRow Add(object Diameter, object Pitch = Missing, object Revolution = Missing, object Height = Missing, object Index = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [HelicalCurveVariableShapeDefinition](../objects/HelicalCurveVariableShapeDefinition.md).ShapeDefinitionRows

**Referenced types:** [HelicalCurveShapeDefinitionRow](../objects/HelicalCurveShapeDefinitionRow.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

