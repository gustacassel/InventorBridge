# Sketch3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…]`

```csharp
interface Sketch3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    int CheckSumValue { get; }
    bool Consumed { get; }
    bool DeferUpdates { get; set; }
    ObjectsEnumerator Dependents { get; }
    DimensionConstraints3D DimensionConstraints3D { get; }
    bool DimensionsVisible { get; set; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    bool Exported { get; set; }
    GeometricConstraints3D GeometricConstraints3D { get; }
    bool HasReferenceComponent { get; }
    HealthStatusEnum HealthStatus { get; }
    HelicalCurves HelicalCurves { get; }
    IntersectionCurves IntersectionCurves { get; }
    bool IsOwnedByFeature { get; }
    string Name { get; set; }
    OnFaceCurves OnFaceCurves { get; }
    Color OverrideColor { get; set; }
    PartFeature OwnedBy { get; }
    object Parent { get; }
    Profiles3D Profiles3D { get; }
    ProjectToSurfaceCurves ProjectToSurfaceCurves { get; }
    ReferenceComponent ReferenceComponent { get; }
    Sketch3D ReferencedEntity { get; }
    bool Shared { get; set; }
    SilhouetteCurves SilhouetteCurves { get; }
    SketchArcs3D SketchArcs3D { get; }
    SketchCircles3D SketchCircles3D { get; }
    SketchControlPointSplines3D SketchControlPointSplines3D { get; }
    SketchEllipses3D SketchEllipses3D { get; }
    SketchEllipticalArcs3D SketchEllipticalArcs3D { get; }
    SketchEntities3DEnumerator SketchEntities3D { get; }
    SketchEquationCurves3D SketchEquationCurves3D { get; }
    SketchFixedSplines3D SketchFixedSplines3D { get; }
    SketchLines3D SketchLines3D { get; }
    SketchPoints3D SketchPoints3D { get; }
    SketchSplines3D SketchSplines3D { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete();
    void Edit();
    void ExitEdit();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    SketchEntity3D Include(object Entity);
    void SetEndOfPart(bool Before);
    void Solve();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BendConstraint](../objects/BendConstraint.md).Parent, [BendConstraintProxy](../objects/BendConstraintProxy.md).Parent, [CoincidentConstraint3D](../objects/CoincidentConstraint3D.md).Parent, [CoincidentConstraint3DProxy](../objects/CoincidentConstraint3DProxy.md).Parent, [CollinearConstraint3D](../objects/CollinearConstraint3D.md).Parent, [CollinearConstraint3DProxy](../objects/CollinearConstraint3DProxy.md).Parent, [ConcentricConstraint3D](../objects/ConcentricConstraint3D.md).Parent, [ConcentricConstraint3DProxy](../objects/ConcentricConstraint3DProxy.md).Parent, [CustomConstraint3D](../objects/CustomConstraint3D.md).Parent, [CustomConstraint3DProxy](../objects/CustomConstraint3DProxy.md).Parent, [DimensionConstraint3D](../objects/DimensionConstraint3D.md).Parent, [EqualConstraint3D](../objects/EqualConstraint3D.md).Parent, [EqualConstraint3DProxy](../objects/EqualConstraint3DProxy.md).Parent, [GeometricConstraint3D](../objects/GeometricConstraint3D.md).Parent, [GroundConstraint3D](../objects/GroundConstraint3D.md).Parent, [GroundConstraint3DProxy](../objects/GroundConstraint3DProxy.md).Parent, [HelicalConstraint3D](../objects/HelicalConstraint3D.md).Parent, [HelicalConstraint3DProxy](../objects/HelicalConstraint3DProxy.md).Parent, [HelicalCurve](../objects/HelicalCurve.md).Parent, [HelicalCurveProxy](../objects/HelicalCurveProxy.md).Parent, [IntersectionCurve](../objects/IntersectionCurve.md).Parent, [IntersectionCurveProxy](../objects/IntersectionCurveProxy.md).Parent, [LineLengthDimConstraint3D](../objects/LineLengthDimConstraint3D.md).Parent, [LineLengthDimConstraint3DProxy](../objects/LineLengthDimConstraint3DProxy.md).Parent, [MidpointConstraint3D](../objects/MidpointConstraint3D.md).Parent, [MidpointConstraint3DProxy](../objects/MidpointConstraint3DProxy.md).Parent, [OnFaceConstraint3D](../objects/OnFaceConstraint3D.md).Parent, [OnFaceConstraint3DProxy](../objects/OnFaceConstraint3DProxy.md).Parent, [OnFaceCurve](../objects/OnFaceCurve.md).Parent, [OnFaceCurveProxy](../objects/OnFaceCurveProxy.md).Parent, [ParallelConstraint3D](../objects/ParallelConstraint3D.md).Parent, [ParallelConstraint3DProxy](../objects/ParallelConstraint3DProxy.md).Parent, [ParallelToXAxisConstraint3D](../objects/ParallelToXAxisConstraint3D.md).Parent, [ParallelToXAxisConstraint3DProxy](../objects/ParallelToXAxisConstraint3DProxy.md).Parent, [ParallelToXYPlaneConstraint3D](../objects/ParallelToXYPlaneConstraint3D.md).Parent, [ParallelToXYPlaneConstraint3DProxy](../objects/ParallelToXYPlaneConstraint3DProxy.md).Parent, [ParallelToXZPlaneConstraint3D](../objects/ParallelToXZPlaneConstraint3D.md).Parent, [ParallelToXZPlaneConstraint3DProxy](../objects/ParallelToXZPlaneConstraint3DProxy.md).Parent, [ParallelToYAxisConstraint3D](../objects/ParallelToYAxisConstraint3D.md).Parent, [ParallelToYAxisConstraint3DProxy](../objects/ParallelToYAxisConstraint3DProxy.md).Parent and 63 more (see `members.tsv`)

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [Color](../objects/Color.md), [DimensionConstraints3D](../objects/DimensionConstraints3D.md), [GeometricConstraints3D](../objects/GeometricConstraints3D.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [HelicalCurves](../objects/HelicalCurves.md), [IntersectionCurves](../objects/IntersectionCurves.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [OnFaceCurves](../objects/OnFaceCurves.md), [PartFeature](../objects/PartFeature.md), [Profiles3D](../objects/Profiles3D.md), [ProjectToSurfaceCurves](../objects/ProjectToSurfaceCurves.md), [ReferenceComponent](../objects/ReferenceComponent.md), [SilhouetteCurves](../objects/SilhouetteCurves.md), [SketchArcs3D](../objects/SketchArcs3D.md), [SketchCircles3D](../objects/SketchCircles3D.md), [SketchControlPointSplines3D](../objects/SketchControlPointSplines3D.md), [SketchEllipses3D](../objects/SketchEllipses3D.md), [SketchEllipticalArcs3D](../objects/SketchEllipticalArcs3D.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SketchEntity3D](../objects/SketchEntity3D.md), [SketchEquationCurves3D](../objects/SketchEquationCurves3D.md), [SketchFixedSplines3D](../objects/SketchFixedSplines3D.md), [SketchLines3D](../objects/SketchLines3D.md), [SketchPoints3D](../objects/SketchPoints3D.md), [SketchSplines3D](../objects/SketchSplines3D.md)

