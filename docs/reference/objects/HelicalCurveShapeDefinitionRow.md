# HelicalCurveShapeDefinitionRow

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].HelicalCurves.Item[…].Definition → (HelicalCurveVariableShapeDefinition).ShapeDefinitionRows.Item[…]`

```csharp
interface HelicalCurveShapeDefinitionRow
{
    // Properties
    object Application { get; }
    object Diameter { get; set; }
    object Height { get; set; }
    int Index { get; }
    HelicalCurveVariableShapeDefinition Parent { get; }
    object Pitch { get; set; }
    object Revolution { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [HelicalCurveShapeDefinitionRows](../objects/HelicalCurveShapeDefinitionRows.md).Add, [HelicalCurveShapeDefinitionRows](../objects/HelicalCurveShapeDefinitionRows.md).Item

**Referenced types:** [HelicalCurveVariableShapeDefinition](../objects/HelicalCurveVariableShapeDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

