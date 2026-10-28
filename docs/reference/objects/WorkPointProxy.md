# WorkPointProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [WorkPoint](../objects/WorkPoint.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.WorkPoints.Item[…] → (WorkPointProxy)`

```csharp
interface WorkPointProxy
{
    // Properties
    bool Adaptive { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Construction { get; }
    bool ConsumeInputs { get; set; }
    bool Consumed { get; }
    ComponentOccurrence ContainingOccurrence { get; }
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
    WorkPoint NativeObject { get; }
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

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [Edge](../objects/Edge.md), [Face](../objects/Face.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md), [Point](../objects/Point.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [WorkPoint](../objects/WorkPoint.md), [WorkPointDefinitionEnum](../enums/WorkPointDefinitionEnum.md)

