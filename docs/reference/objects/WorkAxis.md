# WorkAxis

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.WorkAxes.Item[…]`

```csharp
interface WorkAxis
{
    // Properties
    bool Adaptive { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool AutoResize { get; set; }
    bool Construction { get; }
    bool ConsumeInputs { get; set; }
    bool Consumed { get; }
    object Definition { get; }
    WorkAxisDefinitionEnum DefinitionType { get; }
    ObjectCollection Dependents { get; }
    ObjectCollection DrivenBy { get; }
    bool Exported { get; set; }
    bool Grounded { get; set; }
    bool HasReferenceComponent { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsCoordinateSystemElement { get; }
    bool IsOwnedByFeature { get; }
    bool IsParentSketch { get; }
    bool IsPatternElement { get; }
    Line Line { get; }
    string Name { get; set; }
    PartFeature OwnedBy { get; }
    ComponentDefinition Parent { get; }
    Sketch3D ParentSketch { get; }
    ReferenceComponent ReferenceComponent { get; }
    WorkAxis ReferencedEntity { get; }
    bool Shared { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete(bool RetainDependents = false);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void GetSize(out Point Point1, out Point Point2);
    void SetByAnalyticEdge(Edge Edge);
    void SetByLine(object Line);
    void SetByLineAndPlane(object Line, object Plane);
    void SetByLineAndPoint(object Line, object Point);
    void SetByNormalToSurface(object Surface, object Point);
    void SetByRevolvedFace(Face Face);
    void SetByTwoPlanes(object Plane1, object Plane2);
    void SetByTwoPoints(object Point1, object Point2);
    void SetEndOfPart(bool Before);
    void SetFixed(Point Point, UnitVector Axis);
    void SetSize(Point Point1, Point Point2);
}
```

**Returned by:** [AnalyticEdgeWorkAxisDef](../objects/AnalyticEdgeWorkAxisDef.md).Parent, [AssemblyWorkAxisDef](../objects/AssemblyWorkAxisDef.md).Parent, [FixedWorkAxisDef](../objects/FixedWorkAxisDef.md).Parent, [LineAndPlaneWorkAxisDef](../objects/LineAndPlaneWorkAxisDef.md).Parent, [LineAndPointWorkAxisDef](../objects/LineAndPointWorkAxisDef.md).Parent, [LineWorkAxisDef](../objects/LineWorkAxisDef.md).Parent, [NormalToSurfaceWorkAxisDef](../objects/NormalToSurfaceWorkAxisDef.md).Parent, [RevolvedFaceWorkAxisDef](../objects/RevolvedFaceWorkAxisDef.md).Parent, [TwoPlanesWorkAxisDef](../objects/TwoPlanesWorkAxisDef.md).Parent, [TwoPointsWorkAxisDef](../objects/TwoPointsWorkAxisDef.md).Parent, [UserCoordinateSystem](../objects/UserCoordinateSystem.md).XAxis, [UserCoordinateSystem](../objects/UserCoordinateSystem.md).YAxis, [UserCoordinateSystem](../objects/UserCoordinateSystem.md).ZAxis, [UserCoordinateSystemProxy](../objects/UserCoordinateSystemProxy.md).XAxis, [UserCoordinateSystemProxy](../objects/UserCoordinateSystemProxy.md).YAxis, [UserCoordinateSystemProxy](../objects/UserCoordinateSystemProxy.md).ZAxis, [WorkAxes](../objects/WorkAxes.md).AddByAnalyticEdge, [WorkAxes](../objects/WorkAxes.md).AddByLine, [WorkAxes](../objects/WorkAxes.md).AddByLineAndPlane, [WorkAxes](../objects/WorkAxes.md).AddByLineAndPoint, [WorkAxes](../objects/WorkAxes.md).AddByNormalToSurface, [WorkAxes](../objects/WorkAxes.md).AddByRevolvedFace, [WorkAxes](../objects/WorkAxes.md).AddByTwoPlanes, [WorkAxes](../objects/WorkAxes.md).AddByTwoPoints, [WorkAxes](../objects/WorkAxes.md).AddFixed, [WorkAxes](../objects/WorkAxes.md).Item, [WorkAxis](../objects/WorkAxis.md).ReferencedEntity, [WorkAxisProxy](../objects/WorkAxisProxy.md).NativeObject, [WorkAxisProxy](../objects/WorkAxisProxy.md).ReferencedEntity

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [Edge](../objects/Edge.md), [Face](../objects/Face.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [Line](../objects/Line.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md), [Point](../objects/Point.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [UnitVector](../objects/UnitVector.md), [WorkAxisDefinitionEnum](../enums/WorkAxisDefinitionEnum.md)

