# Point

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreatePoint(…)`

```csharp
interface Point
{
    // Properties
    double X { get; set; }
    double Y { get; set; }
    double Z { get; set; }
    // Methods
    Point Copy();
    double DistanceTo(Point Point);
    void GetPointData(out double[] Coords);
    bool IsEqualTo(Point Point, double Tolerance = 0);
    void PutPointData(out double[] Coords);
    void TransformBy(Matrix Matrix);
    void TranslateBy(Vector Vector);
    Vector VectorTo(Point Point);
}
```

**Returned by:** [AngularModelDimensionDefinition](../objects/AngularModelDimensionDefinition.md).TextPosition, [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md).AnnotationPlaneToModel, [AnnotationPlaneDefinition](../objects/AnnotationPlaneDefinition.md).Origin, [Arc3d](../objects/Arc3d.md).Center, [Arc3d](../objects/Arc3d.md).EndPoint, [Arc3d](../objects/Arc3d.md).StartPoint, [AssemblyWorkAxisDef](../objects/AssemblyWorkAxisDef.md).OriginPoint, [AssemblyWorkPlaneDef](../objects/AssemblyWorkPlaneDef.md).OriginPoint, [AssemblyWorkPointDef](../objects/AssemblyWorkPointDef.md).Point, [BIMCableTrayConnectorDefinition](../objects/BIMCableTrayConnectorDefinition.md).Origin, [BIMComponentDescription](../objects/BIMComponentDescription.md).ViewCubeOrientationOrigin, [BIMConduitConnectorDefinition](../objects/BIMConduitConnectorDefinition.md).Origin, [BIMConnectorDefinition](../objects/BIMConnectorDefinition.md).Origin, [BIMDuctConnectorDefinition](../objects/BIMDuctConnectorDefinition.md).Origin, [BIMElectricalConnectorDefinition](../objects/BIMElectricalConnectorDefinition.md).Origin, [BIMPipeConnectorDefinition](../objects/BIMPipeConnectorDefinition.md).Origin, [BSplineCurve](../objects/BSplineCurve.md).PoleAtIndex, [BSplineSurface](../objects/BSplineSurface.md).PoleAtIndex, [Box](../objects/Box.md).MaxPoint, [Box](../objects/Box.md).MinPoint, [Camera](../objects/Camera.md).Eye, [Camera](../objects/Camera.md).Target, [Camera](../objects/Camera.md).ViewToModelSpace, [Circle](../objects/Circle.md).Center, [Cone](../objects/Cone.md).BasePoint, [CosmeticWeld](../objects/CosmeticWeld.md).SymbolAttachPoint, [CosmeticWeld](../objects/CosmeticWeld.md).SymbolBreakPoint, [Cylinder](../objects/Cylinder.md).BasePoint, [DSLoadDefinition](../objects/DSLoadDefinition.md).Location, [DWGArc](../objects/DWGArc.md).Center, [DWGArcProxy](../objects/DWGArcProxy.md).Center, [DWGEllipticalArc](../objects/DWGEllipticalArc.md).Center, [DWGEllipticalArcProxy](../objects/DWGEllipticalArcProxy.md).Center, [DWGEntitySplineSegment](../objects/DWGEntitySplineSegment.md).EndPoint, [DWGEntitySplineSegment](../objects/DWGEntitySplineSegment.md).StartPoint, [DWGEntitySplineSegmentProxy](../objects/DWGEntitySplineSegmentProxy.md).EndPoint, [DWGEntitySplineSegmentProxy](../objects/DWGEntitySplineSegmentProxy.md).StartPoint, [DWGLine](../objects/DWGLine.md).EndPoint, [DWGLine](../objects/DWGLine.md).StartPoint, [DWGLineProxy](../objects/DWGLineProxy.md).EndPoint and 134 more (see `members.tsv`)

**Referenced types:** [Matrix](../objects/Matrix.md), [Vector](../objects/Vector.md)

