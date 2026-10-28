# Sketch

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SketchBlockDefinitions.Item[…].InsertionPoint.Parent`

```csharp
interface Sketch
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    SketchCircularPatterns CircularPatterns { get; } // since 2025
    Color Color { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    DataIO DataIO { get; }
    bool DeferUpdates { get; set; }
    DimensionConstraints DimensionConstraints { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    GeometricConstraints GeometricConstraints { get; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    string Name { get; set; }
    object Parent { get; }
    SketchRectangularPatterns RectangularPatterns { get; } // since 2025
    SketchArcs SketchArcs { get; }
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
    TextBoxes TextBoxes { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    SketchEntitiesEnumerator AddArcSlotByCenterPointArc(object CenterPoint, object StartPoint, double SweepAngle, double Width);
    SketchEntitiesEnumerator AddArcSlotByThreePointArc(object StartPoint, object MidPoint, object EndPoint, double Width);
    SketchEntity AddByProjectingEntity(object Entity);
    SketchEntitiesEnumerator AddStraightSlotByCenterToCenter(object StartPoint, object EndPoint, double Width);
    SketchEntitiesEnumerator AddStraightSlotByOverall(object StartPoint, object EndPoint, double Width);
    SketchEntitiesEnumerator AddStraightSlotBySlotCenter(object CenterPoint, object EndPoint, double Width);
    void CopyContentsTo(Sketch TargetSketch);
    void CopyEntitiesTo(ObjectCollection SketchEntities, Sketch TargetSketch, object Position = Missing);
    void Delete();
    void Edit();
    void ExitEdit();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    ObjectsEnumerator MoveSketchObjects(ObjectCollection SketchObjects, Vector2d Vector, bool Copy = false, bool RemoveConstraints = false);
    SketchEntitiesEnumerator OffsetSketchEntitiesUsingDistance(ObjectCollection SketchEntities, double OffsetDistance, bool NaturalOffsetDirection, bool IncludeConnectedEntities = false, bool CreateOffsetConstraints = true);
    SketchEntitiesEnumerator OffsetSketchEntitiesUsingPoint(ObjectCollection SketchEntities, Point2d OffsetPoint, bool IncludeConnectedEntities = false, bool CreateOffsetConstraints = true);
    ObjectsEnumerator RotateSketchObjects(ObjectCollection SketchObjects, Point2d CenterPoint, double Angle, bool Copy = false, bool RemoveConstraints = false);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    void Solve();
}
```

**Returned by:** [ArcLengthDimConstraint](../objects/ArcLengthDimConstraint.md).Parent, [ArcLengthDimConstraintProxy](../objects/ArcLengthDimConstraintProxy.md).Parent, [CoincidentConstraint](../objects/CoincidentConstraint.md).Parent, [CoincidentConstraintProxy](../objects/CoincidentConstraintProxy.md).Parent, [CollinearConstraint](../objects/CollinearConstraint.md).Parent, [CollinearConstraintProxy](../objects/CollinearConstraintProxy.md).Parent, [ConcentricConstraint](../objects/ConcentricConstraint.md).Parent, [ConcentricConstraintProxy](../objects/ConcentricConstraintProxy.md).Parent, [DiameterDimConstraint](../objects/DiameterDimConstraint.md).Parent, [DiameterDimConstraintProxy](../objects/DiameterDimConstraintProxy.md).Parent, [DimensionConstraint](../objects/DimensionConstraint.md).Parent, [EllipseRadiusDimConstraint](../objects/EllipseRadiusDimConstraint.md).Parent, [EllipseRadiusDimConstraintProxy](../objects/EllipseRadiusDimConstraintProxy.md).Parent, [EqualLengthConstraint](../objects/EqualLengthConstraint.md).Parent, [EqualLengthConstraintProxy](../objects/EqualLengthConstraintProxy.md).Parent, [EqualRadiusConstraint](../objects/EqualRadiusConstraint.md).Parent, [EqualRadiusConstraintProxy](../objects/EqualRadiusConstraintProxy.md).Parent, [GeometricConstraint](../objects/GeometricConstraint.md).Parent, [GroundConstraint](../objects/GroundConstraint.md).Parent, [GroundConstraintProxy](../objects/GroundConstraintProxy.md).Parent, [HorizontalAlignConstraint](../objects/HorizontalAlignConstraint.md).Parent, [HorizontalAlignConstraintProxy](../objects/HorizontalAlignConstraintProxy.md).Parent, [HorizontalConstraint](../objects/HorizontalConstraint.md).Parent, [HorizontalConstraintProxy](../objects/HorizontalConstraintProxy.md).Parent, [MidpointConstraint](../objects/MidpointConstraint.md).Parent, [MidpointConstraintProxy](../objects/MidpointConstraintProxy.md).Parent, [OffsetConstraint](../objects/OffsetConstraint.md).Parent, [OffsetConstraintProxy](../objects/OffsetConstraintProxy.md).Parent, [OffsetDimConstraint](../objects/OffsetDimConstraint.md).Parent, [OffsetDimConstraintProxy](../objects/OffsetDimConstraintProxy.md).Parent, [OffsetSplineDimConstraint](../objects/OffsetSplineDimConstraint.md).Parent, [OffsetSplineDimConstraintProxy](../objects/OffsetSplineDimConstraintProxy.md).Parent, [ParallelConstraint](../objects/ParallelConstraint.md).Parent, [ParallelConstraintProxy](../objects/ParallelConstraintProxy.md).Parent, [PatternConstraint](../objects/PatternConstraint.md).Parent, [PatternConstraintProxy](../objects/PatternConstraintProxy.md).Parent, [PerpendicularConstraint](../objects/PerpendicularConstraint.md).Parent, [PerpendicularConstraintProxy](../objects/PerpendicularConstraintProxy.md).Parent, [Profile](../objects/Profile.md).Parent, [ProfileProxy](../objects/ProfileProxy.md).Parent and 57 more (see `members.tsv`)

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [Color](../objects/Color.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [DataIO](../objects/DataIO.md), [DimensionConstraints](../objects/DimensionConstraints.md), [GeometricConstraints](../objects/GeometricConstraints.md), [LineTypeEnum](../enums/LineTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Point2d](../objects/Point2d.md), [SketchArcs](../objects/SketchArcs.md), [SketchCircles](../objects/SketchCircles.md), [SketchCircularPatterns](../objects/SketchCircularPatterns.md), [SketchControlPointSplines](../objects/SketchControlPointSplines.md), [SketchEllipses](../objects/SketchEllipses.md), [SketchEllipticalArcs](../objects/SketchEllipticalArcs.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md), [SketchEntity](../objects/SketchEntity.md), [SketchEquationCurves](../objects/SketchEquationCurves.md), [SketchFixedSplines](../objects/SketchFixedSplines.md), [SketchImages](../objects/SketchImages.md), [SketchLines](../objects/SketchLines.md), [SketchOffsetSplines](../objects/SketchOffsetSplines.md), [SketchPoints](../objects/SketchPoints.md), [SketchRectangularPatterns](../objects/SketchRectangularPatterns.md), [SketchSplines](../objects/SketchSplines.md), [TextBoxes](../objects/TextBoxes.md), [Vector2d](../objects/Vector2d.md)

