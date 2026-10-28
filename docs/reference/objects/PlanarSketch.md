# PlanarSketch

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Sketch](../objects/Sketch.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…]`

```csharp
interface PlanarSketch
{
    // Properties
    bool Adaptive { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    object AxisEntity { get; set; }
    Line AxisEntityGeometry { get; }
    bool AxisIsX { get; set; }
    int CheckSumValue { get; }
    SketchCircularPatterns CircularPatterns { get; } // since 2025
    Color Color { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    bool Consumed { get; }
    bool CopyToFlatPattern { get; set; }
    DataIO DataIO { get; }
    bool DeferUpdates { get; set; }
    ObjectsEnumerator Dependents { get; }
    DimensionConstraints DimensionConstraints { get; }
    bool DimensionsVisible { get; set; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    bool Exported { get; set; }
    GeometricConstraints GeometricConstraints { get; }
    bool HasReferenceComponent { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsOwnedByFeature { get; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    Matrix ModelToSketchTransform { get; }
    string Name { get; set; }
    bool NaturalAxisDirection { get; set; }
    object OriginPoint { get; set; }
    Point OriginPointGeometry { get; }
    PartFeature OwnedBy { get; }
    object Parent { get; }
    object PlanarEntity { get; set; }
    Plane PlanarEntityGeometry { get; }
    Profiles Profiles { get; }
    ProjectedCuts ProjectedCuts { get; }
    SketchRectangularPatterns RectangularPatterns { get; } // since 2025
    ReferenceComponent ReferenceComponent { get; }
    PlanarSketch ReferencedEntity { get; }
    bool Shared { get; set; }
    SketchArcs SketchArcs { get; }
    SketchBlocks SketchBlocks { get; }
    SketchCircles SketchCircles { get; }
    SketchControlPointSplines SketchControlPointSplines { get; }
    SketchEllipses SketchEllipses { get; }
    SketchEllipticalArcs SketchEllipticalArcs { get; }
    SketchEntitiesEnumerator SketchEntities { get; }
    SketchEquationCurves SketchEquationCurves { get; }
    SketchFixedSplines SketchFixedSplines { get; }
    SketchImages SketchImages { get; }
    SketchLines SketchLines { get; }
    SketchOffsetSplines SketchOffsetSplines { get; }
    SketchPoints SketchPoints { get; }
    SketchSplines SketchSplines { get; }
    Matrix SketchToModelTransform { get; }
    TextBoxes TextBoxes { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    SketchEntitiesEnumerator AddArcSlotByCenterPointArc(object CenterPoint, object StartPoint, double SweepAngle, double Width);
    SketchEntitiesEnumerator AddArcSlotByThreePointArc(object StartPoint, object MidPoint, object EndPoint, double Width);
    SketchEntity AddByProjectingEntity(object Entity);
    SketchEntity AddBySilhouette(Face Face, Point ProximityPoint);
    SketchEntitiesEnumerator AddStraightSlotByCenterToCenter(object StartPoint, object EndPoint, double Width);
    SketchEntitiesEnumerator AddStraightSlotByOverall(object StartPoint, object EndPoint, double Width);
    SketchEntitiesEnumerator AddStraightSlotBySlotCenter(object CenterPoint, object EndPoint, double Width);
    void BreakLink();
    void CopyContentsTo(Sketch TargetSketch);
    void CopyEntitiesTo(ObjectCollection SketchEntities, Sketch TargetSketch, object Position = Missing);
    void Delete();
    void Edit();
    void ExitEdit();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    Point2d ModelToSketchSpace(Point ModelCoordinate);
    ObjectsEnumerator MoveSketchObjects(ObjectCollection SketchObjects, Vector2d Vector, bool Copy = false, bool RemoveConstraints = false);
    SketchEntitiesEnumerator OffsetSketchEntitiesUsingDistance(ObjectCollection SketchEntities, double OffsetDistance, bool NaturalOffsetDirection, bool IncludeConnectedEntities = false, bool CreateOffsetConstraints = true);
    SketchEntitiesEnumerator OffsetSketchEntitiesUsingPoint(ObjectCollection SketchEntities, Point2d OffsetPoint, bool IncludeConnectedEntities = false, bool CreateOffsetConstraints = true);
    ObjectsEnumerator RotateSketchObjects(ObjectCollection SketchObjects, Point2d CenterPoint, double Angle, bool Copy = false, bool RemoveConstraints = false);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    void SetEndOfPart(bool Before);
    Point SketchToModelSpace(Point2d SketchCoordinate);
    void Solve();
    void UpdateProfiles();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [HoleFeature](../objects/HoleFeature.md).Sketch, [HoleFeatureProxy](../objects/HoleFeatureProxy.md).Sketch, [PlanarSketch](../objects/PlanarSketch.md).ReferencedEntity, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).NativeObject, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).ReferencedEntity, [PlanarSketches](../objects/PlanarSketches.md).Add, [PlanarSketches](../objects/PlanarSketches.md).AddWithOrientation, [PlanarSketches](../objects/PlanarSketches.md).Item, [ProjectedCut](../objects/ProjectedCut.md).Parent, [ProjectedCutProxy](../objects/ProjectedCutProxy.md).Parent, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).ReferencedEntity, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).ReferencedEntity, [SlotDefinition](../objects/SlotDefinition.md).Sketch

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [Color](../objects/Color.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [DataIO](../objects/DataIO.md), [DimensionConstraints](../objects/DimensionConstraints.md), [Face](../objects/Face.md), [GeometricConstraints](../objects/GeometricConstraints.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [Line](../objects/Line.md), [LineTypeEnum](../enums/LineTypeEnum.md), [Matrix](../objects/Matrix.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [PartFeature](../objects/PartFeature.md), [Plane](../objects/Plane.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [Profiles](../objects/Profiles.md), [ProjectedCuts](../objects/ProjectedCuts.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch](../objects/Sketch.md), [SketchArcs](../objects/SketchArcs.md), [SketchBlocks](../objects/SketchBlocks.md), [SketchCircles](../objects/SketchCircles.md), [SketchCircularPatterns](../objects/SketchCircularPatterns.md), [SketchControlPointSplines](../objects/SketchControlPointSplines.md), [SketchEllipses](../objects/SketchEllipses.md), [SketchEllipticalArcs](../objects/SketchEllipticalArcs.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md), [SketchEntity](../objects/SketchEntity.md), [SketchEquationCurves](../objects/SketchEquationCurves.md), [SketchFixedSplines](../objects/SketchFixedSplines.md), [SketchImages](../objects/SketchImages.md), [SketchLines](../objects/SketchLines.md), [SketchOffsetSplines](../objects/SketchOffsetSplines.md), [SketchPoints](../objects/SketchPoints.md), [SketchRectangularPatterns](../objects/SketchRectangularPatterns.md), [SketchSplines](../objects/SketchSplines.md), [TextBoxes](../objects/TextBoxes.md), [Vector2d](../objects/Vector2d.md)

