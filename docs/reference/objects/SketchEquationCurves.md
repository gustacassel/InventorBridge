# SketchEquationCurves

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchEquationCurves`

```csharp
interface SketchEquationCurves
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchEquationCurve Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchEquationCurve Add(CurveEquationTypeEnum EquationType, CoordinateSystemTypeEnum CoordinateSystemType, string XValueOrRadius, string YValueOrTheta, object MinValue, object MaxValue);
    bool IsValidExpression(string Expression, object Unit);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).SketchEquationCurves, [PlanarSketch](../objects/PlanarSketch.md).SketchEquationCurves, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).SketchEquationCurves, [Sketch](../objects/Sketch.md).SketchEquationCurves, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).SketchEquationCurves, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).SketchEquationCurves

**Referenced types:** [CoordinateSystemTypeEnum](../enums/CoordinateSystemTypeEnum.md), [CurveEquationTypeEnum](../enums/CurveEquationTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchEquationCurve](../objects/SketchEquationCurve.md)

