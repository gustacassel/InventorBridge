# Box2d

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateBox2d(…)`

```csharp
interface Box2d
{
    // Properties
    Point2d MaxPoint { get; set; }
    Point2d MinPoint { get; set; }
    // Methods
    bool Contains(Point2d Point);
    Box2d Copy();
    void Expand(double Distance);
    void Extend(Point2d Point);
    void GetBoxData(out double[] MinPoint, out double[] MaxPoint);
    bool IsDisjoint(Box2d Box);
    void PutBoxData(out double[] MinPoint, out double[] MaxPoint);
}
```

**Returned by:** [BendNote](../objects/BendNote.md).RangeBox, [Border](../objects/Border.md).RangeBox, [Box2d](../objects/Box2d.md).Copy, [ChamferNote](../objects/ChamferNote.md).RangeBox, [Curve2dEvaluator](../objects/Curve2dEvaluator.md).RangeBox, [CustomTable](../objects/CustomTable.md).RangeBox, [DefaultBorder](../objects/DefaultBorder.md).RangeBox, [DimensionText](../objects/DimensionText.md).RangeBox, [DrawingNote](../objects/DrawingNote.md).RangeBox, [DrawingViewHatchArea](../objects/DrawingViewHatchArea.md).RangeBox, [DrawingViewHatchRegion](../objects/DrawingViewHatchRegion.md).RangeBox, [DrawingViewLabel](../objects/DrawingViewLabel.md).RangeBox, [GeneralNote](../objects/GeneralNote.md).RangeBox, [HoleTable](../objects/HoleTable.md).RangeBox, [HoleTag](../objects/HoleTag.md).RangeBox, [ImportedDWGComponent](../objects/ImportedDWGComponent.md).Crop, [ImportedDWGComponentProxy](../objects/ImportedDWGComponentProxy.md).Crop, [LeaderNote](../objects/LeaderNote.md).RangeBox, [PartsList](../objects/PartsList.md).RangeBox, [PunchNote](../objects/PunchNote.md).RangeBox, [RevisionCloud](../objects/RevisionCloud.md).RangeBox, [RevisionTable](../objects/RevisionTable.md).RangeBox, [SketchArc](../objects/SketchArc.md).RangeBox, [SketchArcProxy](../objects/SketchArcProxy.md).RangeBox, [SketchCircle](../objects/SketchCircle.md).RangeBox, [SketchCircleProxy](../objects/SketchCircleProxy.md).RangeBox, [SketchCircularPattern](../objects/SketchCircularPattern.md).RangeBox, [SketchControlPointSpline](../objects/SketchControlPointSpline.md).RangeBox, [SketchControlPointSplineProxy](../objects/SketchControlPointSplineProxy.md).RangeBox, [SketchEllipse](../objects/SketchEllipse.md).RangeBox, [SketchEllipseProxy](../objects/SketchEllipseProxy.md).RangeBox, [SketchEllipticalArc](../objects/SketchEllipticalArc.md).RangeBox, [SketchEllipticalArcProxy](../objects/SketchEllipticalArcProxy.md).RangeBox, [SketchEntity](../objects/SketchEntity.md).RangeBox, [SketchEquationCurve](../objects/SketchEquationCurve.md).RangeBox, [SketchEquationCurveProxy](../objects/SketchEquationCurveProxy.md).RangeBox, [SketchFixedSpline](../objects/SketchFixedSpline.md).RangeBox, [SketchFixedSplineProxy](../objects/SketchFixedSplineProxy.md).RangeBox, [SketchLine](../objects/SketchLine.md).RangeBox, [SketchLineProxy](../objects/SketchLineProxy.md).RangeBox and 14 more (see `members.tsv`)

**Referenced types:** [Point2d](../objects/Point2d.md)

