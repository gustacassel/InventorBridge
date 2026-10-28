# WorkAxisProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [WorkAxis](../objects/WorkAxis.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.WorkAxes.Item[…] → (WorkAxisProxy)`

```csharp
interface WorkAxisProxy
{
    // Properties
    bool Adaptive { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool AutoResize { get; set; }
    bool Construction { get; }
    bool ConsumeInputs { get; set; }
    bool Consumed { get; }
    ComponentOccurrence ContainingOccurrence { get; }
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
    WorkAxis NativeObject { get; }
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

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [Edge](../objects/Edge.md), [Face](../objects/Face.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [Line](../objects/Line.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md), [Point](../objects/Point.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [UnitVector](../objects/UnitVector.md), [WorkAxis](../objects/WorkAxis.md), [WorkAxisDefinitionEnum](../enums/WorkAxisDefinitionEnum.md)

