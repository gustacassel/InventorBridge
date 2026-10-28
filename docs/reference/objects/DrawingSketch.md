# DrawingSketch

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Sketch](../objects/Sketch.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).BorderDefinitions.Item[…].Sketch`

```csharp
interface DrawingSketch
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
    Profiles Profiles { get; }
    SketchRectangularPatterns RectangularPatterns { get; } // since 2025
    SketchArcs SketchArcs { get; }
    SketchCircles SketchCircles { get; }
    SketchControlPointSplines SketchControlPointSplines { get; }
    SketchEllipses SketchEllipses { get; }
    SketchEllipticalArcs SketchEllipticalArcs { get; }
    SketchEntitiesEnumerator SketchEntities { get; }
    SketchEquationCurves SketchEquationCurves { get; }
    SketchFillRegions SketchFillRegions { get; }
    SketchFixedSplines SketchFixedSplines { get; }
    SketchHatchRegions SketchHatchRegions { get; }
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
    void GetAutomatedCenterlineSettings(out AutomatedCenterlineSettings AutomatedCenterlineSettings);
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    ObjectsEnumerator MoveSketchObjects(ObjectCollection SketchObjects, Vector2d Vector, bool Copy = false, bool RemoveConstraints = false);
    SketchEntitiesEnumerator OffsetSketchEntitiesUsingDistance(ObjectCollection SketchEntities, double OffsetDistance, bool NaturalOffsetDirection, bool IncludeConnectedEntities = false, bool CreateOffsetConstraints = true);
    SketchEntitiesEnumerator OffsetSketchEntitiesUsingPoint(ObjectCollection SketchEntities, Point2d OffsetPoint, bool IncludeConnectedEntities = false, bool CreateOffsetConstraints = true);
    ObjectsEnumerator RotateSketchObjects(ObjectCollection SketchObjects, Point2d CenterPoint, double Angle, bool Copy = false, bool RemoveConstraints = false);
    ObjectsEnumerator SetAutomatedCenterlineSettings(object AutomatedCenterlineSettings = Missing);
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    Point2d SheetToSketchSpace(Point2d SheetCoordinate);
    Point2d SketchToSheetSpace(Point2d SketchCoordinate);
    void Solve();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BorderDefinition](../objects/BorderDefinition.md).Sketch, [BreakOperation](../objects/BreakOperation.md).BreakLineSketch, [CropOperation](../objects/CropOperation.md).CropBoundarySketch, [DrawingSketches](../objects/DrawingSketches.md).Add, [DrawingSketches](../objects/DrawingSketches.md).Item, [RevisionCloud](../objects/RevisionCloud.md).Sketch, [SectionDrawingView](../objects/SectionDrawingView.md).SectionLineSketch, [SketchHatchRegion](../objects/SketchHatchRegion.md).Parent, [SketchedSymbolDefinition](../objects/SketchedSymbolDefinition.md).Sketch, [TitleBlockDefinition](../objects/TitleBlockDefinition.md).Sketch

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [AutomatedCenterlineSettings](../objects/AutomatedCenterlineSettings.md), [Color](../objects/Color.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [DataIO](../objects/DataIO.md), [DimensionConstraints](../objects/DimensionConstraints.md), [GeometricConstraints](../objects/GeometricConstraints.md), [LineTypeEnum](../enums/LineTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Point2d](../objects/Point2d.md), [Profiles](../objects/Profiles.md), [Sketch](../objects/Sketch.md), [SketchArcs](../objects/SketchArcs.md), [SketchCircles](../objects/SketchCircles.md), [SketchCircularPatterns](../objects/SketchCircularPatterns.md), [SketchControlPointSplines](../objects/SketchControlPointSplines.md), [SketchEllipses](../objects/SketchEllipses.md), [SketchEllipticalArcs](../objects/SketchEllipticalArcs.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md), [SketchEntity](../objects/SketchEntity.md), [SketchEquationCurves](../objects/SketchEquationCurves.md), [SketchFillRegions](../objects/SketchFillRegions.md), [SketchFixedSplines](../objects/SketchFixedSplines.md), [SketchHatchRegions](../objects/SketchHatchRegions.md), [SketchImages](../objects/SketchImages.md), [SketchLines](../objects/SketchLines.md), [SketchOffsetSplines](../objects/SketchOffsetSplines.md), [SketchPoints](../objects/SketchPoints.md), [SketchRectangularPatterns](../objects/SketchRectangularPatterns.md), [SketchSplines](../objects/SketchSplines.md), [TextBoxes](../objects/TextBoxes.md), [Vector2d](../objects/Vector2d.md)

