# SketchArcs3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchArcs3D`

```csharp
interface SketchArcs3D
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchArc3D Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchArc3D AddAsBend(SketchLine3D LineOne, SketchLine3D LineTwo, object BendRadius = Missing);
    SketchArc3D AddByCenterStartEndPoint(object CenterPoint, object StartPoint, object EndPoint, object Normal = Missing, bool CounterClockwise = false);
    SketchArc3D AddByCenterStartSweepAngle(object CenterPoint, UnitVector Normal, UnitVector ReferenceVector, double Radius, double StartAngle, double SweepAngle);
    SketchArc3D AddByThreePoints(object StartPoint, object MidPoint, object EndPoint);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).SketchArcs3D, [Sketch3DProxy](../objects/Sketch3DProxy.md).SketchArcs3D

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchArc3D](../objects/SketchArc3D.md), [SketchLine3D](../objects/SketchLine3D.md), [UnitVector](../objects/UnitVector.md)

