# Sketch3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Sketch3D](../objects/Sketch3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…] → (Sketch3DProxy)`

```csharp
interface Sketch3DProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    int CheckSumValue { get; }
    bool Consumed { get; }
    ComponentOccurrence ContainingOccurrence { get; }
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
    Sketch3D NativeObject { get; }
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

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [Color](../objects/Color.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [DimensionConstraints3D](../objects/DimensionConstraints3D.md), [GeometricConstraints3D](../objects/GeometricConstraints3D.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [HelicalCurves](../objects/HelicalCurves.md), [IntersectionCurves](../objects/IntersectionCurves.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [OnFaceCurves](../objects/OnFaceCurves.md), [PartFeature](../objects/PartFeature.md), [Profiles3D](../objects/Profiles3D.md), [ProjectToSurfaceCurves](../objects/ProjectToSurfaceCurves.md), [ReferenceComponent](../objects/ReferenceComponent.md), [SilhouetteCurves](../objects/SilhouetteCurves.md), [Sketch3D](../objects/Sketch3D.md), [SketchArcs3D](../objects/SketchArcs3D.md), [SketchCircles3D](../objects/SketchCircles3D.md), [SketchControlPointSplines3D](../objects/SketchControlPointSplines3D.md), [SketchEllipses3D](../objects/SketchEllipses3D.md), [SketchEllipticalArcs3D](../objects/SketchEllipticalArcs3D.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SketchEntity3D](../objects/SketchEntity3D.md), [SketchEquationCurves3D](../objects/SketchEquationCurves3D.md), [SketchFixedSplines3D](../objects/SketchFixedSplines3D.md), [SketchLines3D](../objects/SketchLines3D.md), [SketchPoints3D](../objects/SketchPoints3D.md), [SketchSplines3D](../objects/SketchSplines3D.md)

