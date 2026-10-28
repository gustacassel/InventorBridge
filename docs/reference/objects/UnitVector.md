# UnitVector

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientGeometry.CreateUnitVector(…)`

```csharp
interface UnitVector
{
    // Properties
    double X { get; set; }
    double Y { get; set; }
    double Z { get; set; }
    // Methods
    double AngleTo(UnitVector Argument);
    Vector AsVector();
    UnitVector Copy();
    UnitVector CrossProduct(UnitVector Argument);
    double DotProduct(UnitVector Argument);
    void GetUnitVectorData(out double[] Coords);
    bool IsEqualTo(UnitVector Argument, double Tolerance = 0);
    bool IsParallelTo(UnitVector Argument, double Tolerance = 0);
    bool IsPerpendicularTo(UnitVector Argument, double Tolerance = 0);
    void PutUnitVectorData(out double[] Coords);
    void TransformBy(Matrix Matrix);
}
```

**Returned by:** [Arc3d](../objects/Arc3d.md).Normal, [Arc3d](../objects/Arc3d.md).ReferenceVector, [AssemblyWorkAxisDef](../objects/AssemblyWorkAxisDef.md).Axis, [AssemblyWorkPlaneDef](../objects/AssemblyWorkPlaneDef.md).XAxis, [AssemblyWorkPlaneDef](../objects/AssemblyWorkPlaneDef.md).YAxis, [BIMCableTrayConnectorDefinition](../objects/BIMCableTrayConnectorDefinition.md).Direction, [BIMCableTrayConnectorDefinition](../objects/BIMCableTrayConnectorDefinition.md).HeightDirection, [BIMCableTrayConnectorDefinition](../objects/BIMCableTrayConnectorDefinition.md).WidthDirection, [BIMConduitConnectorDefinition](../objects/BIMConduitConnectorDefinition.md).Direction, [BIMConnectorDefinition](../objects/BIMConnectorDefinition.md).Direction, [BIMDuctConnectorDefinition](../objects/BIMDuctConnectorDefinition.md).Direction, [BIMDuctConnectorDefinition](../objects/BIMDuctConnectorDefinition.md).HeightDirection, [BIMDuctConnectorDefinition](../objects/BIMDuctConnectorDefinition.md).WidthDirection, [BIMElectricalConnectorDefinition](../objects/BIMElectricalConnectorDefinition.md).Direction, [BIMPipeConnectorDefinition](../objects/BIMPipeConnectorDefinition.md).Direction, [Camera](../objects/Camera.md).UpVector, [Circle](../objects/Circle.md).Normal, [Cone](../objects/Cone.md).AxisVector, [Cylinder](../objects/Cylinder.md).AxisVector, [DWGArc](../objects/DWGArc.md).Normal, [DWGArcProxy](../objects/DWGArcProxy.md).Normal, [DWGEllipticalArc](../objects/DWGEllipticalArc.md).Normal, [DWGEllipticalArcProxy](../objects/DWGEllipticalArcProxy.md).Normal, [DWGLine](../objects/DWGLine.md).Direction, [DWGLineProxy](../objects/DWGLineProxy.md).Direction, [EllipseFull](../objects/EllipseFull.md).Normal, [EllipticalArc](../objects/EllipticalArc.md).MajorAxis, [EllipticalArc](../objects/EllipticalArc.md).MinorAxis, [EllipticalCone](../objects/EllipticalCone.md).AxisVector, [EllipticalCylinder](../objects/EllipticalCylinder.md).AxisVector, [FixedWorkAxisDef](../objects/FixedWorkAxisDef.md).Axis, [FixedWorkPlaneDef](../objects/FixedWorkPlaneDef.md).XAxis, [FixedWorkPlaneDef](../objects/FixedWorkPlaneDef.md).YAxis, [GraphicsNormalSet](../objects/GraphicsNormalSet.md).Normal, [GroundPlaneSettings](../objects/GroundPlaneSettings.md).FrontDirection, [GroundPlaneSettings](../objects/GroundPlaneSettings.md).UpDirection, [Line](../objects/Line.md).Direction, [LineSegment](../objects/LineSegment.md).Direction, [Plane](../objects/Plane.md).Normal, [SketchEllipse3D](../objects/SketchEllipse3D.md).MajorAxisVector and 10 more (see `members.tsv`)

**Referenced types:** [Matrix](../objects/Matrix.md), [Vector](../objects/Vector.md)

