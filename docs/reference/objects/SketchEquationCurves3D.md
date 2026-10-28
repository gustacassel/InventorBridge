# SketchEquationCurves3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchEquationCurves3D`

```csharp
interface SketchEquationCurves3D
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchEquationCurve3D Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchEquationCurve3D Add(CoordinateSystemTypeEnum CoordinateSystemType, string XValueOrRadius, string YValueOrTheta, string ZValueOrPhi, object MinValue, object MaxValue);
    bool IsValidExpression(string Expression, object Unit);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).SketchEquationCurves3D, [Sketch3DProxy](../objects/Sketch3DProxy.md).SketchEquationCurves3D

**Referenced types:** [CoordinateSystemTypeEnum](../enums/CoordinateSystemTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchEquationCurve3D](../objects/SketchEquationCurve3D.md)

