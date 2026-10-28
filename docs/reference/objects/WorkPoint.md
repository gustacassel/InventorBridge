# WorkPoint

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.WorkPoints.Item[…]`

```csharp
interface WorkPoint
{
    // Properties
    bool Adaptive { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Construction { get; }
    bool ConsumeInputs { get; set; }
    bool Consumed { get; }
    object Definition { get; }
    WorkPointDefinitionEnum DefinitionType { get; }
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
    string Name { get; set; }
    PartFeature OwnedBy { get; }
    ComponentDefinition Parent { get; }
    Sketch3D ParentSketch { get; }
    Point Point { get; }
    ReferenceComponent ReferenceComponent { get; }
    WorkPoint ReferencedEntity { get; }
    bool Shared { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete(bool RetainDependents = false);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetAtCentroid(object Entities);
    void SetByCurveAndEntity(object Curve, object Entity, object ProximityPoint = Missing);
    void SetByMidPoint(Edge Edge);
    void SetByPoint(object Point);
    void SetBySphereCenterPoint(Face Face);
    void SetByThreePlanes(object Plane1, object Plane2, object Plane3);
    void SetByTorusCenterPoint(Face Face);
    void SetByTwoLines(object Line1, object Line2);
    void SetEndOfPart(bool Before);
    void SetFixed(Point Point);
}
```

**Returned by:** [AssemblyWorkPointDef](../objects/AssemblyWorkPointDef.md).Parent, [CentroidWorkPointDef](../objects/CentroidWorkPointDef.md).Parent, [CurveAndEntityWorkPointDef](../objects/CurveAndEntityWorkPointDef.md).Parent, [FixedWorkPointDef](../objects/FixedWorkPointDef.md).Parent, [MidPointWorkPointDef](../objects/MidPointWorkPointDef.md).Parent, [NonLinearEdgeWorkPointDef](../objects/NonLinearEdgeWorkPointDef.md).Parent, [PointWorkPointDef](../objects/PointWorkPointDef.md).Parent, [SphereCenterPointWorkPointDef](../objects/SphereCenterPointWorkPointDef.md).Parent, [ThreePlanesWorkPointDef](../objects/ThreePlanesWorkPointDef.md).Parent, [TorusCenterPointWorkPointDef](../objects/TorusCenterPointWorkPointDef.md).Parent, [TwoLinesWorkPointDef](../objects/TwoLinesWorkPointDef.md).Parent, [UserCoordinateSystem](../objects/UserCoordinateSystem.md).Origin, [UserCoordinateSystemProxy](../objects/UserCoordinateSystemProxy.md).Origin, [WorkPoint](../objects/WorkPoint.md).ReferencedEntity, [WorkPointProxy](../objects/WorkPointProxy.md).NativeObject, [WorkPointProxy](../objects/WorkPointProxy.md).ReferencedEntity, [WorkPoints](../objects/WorkPoints.md).AddAtCentroid, [WorkPoints](../objects/WorkPoints.md).AddByCurveAndEntity, [WorkPoints](../objects/WorkPoints.md).AddByMidPoint, [WorkPoints](../objects/WorkPoints.md).AddByPoint, [WorkPoints](../objects/WorkPoints.md).AddBySphereCenterPoint, [WorkPoints](../objects/WorkPoints.md).AddByThreePlanes, [WorkPoints](../objects/WorkPoints.md).AddByTorusCenterPoint, [WorkPoints](../objects/WorkPoints.md).AddByTwoLines, [WorkPoints](../objects/WorkPoints.md).AddFixed, [WorkPoints](../objects/WorkPoints.md).Item, [WorkPointsEnumerator](../objects/WorkPointsEnumerator.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [Edge](../objects/Edge.md), [Face](../objects/Face.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md), [Point](../objects/Point.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [WorkPointDefinitionEnum](../enums/WorkPointDefinitionEnum.md)

