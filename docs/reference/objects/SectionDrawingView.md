# SectionDrawingView

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [DrawingView](../objects/DrawingView.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…] → (SectionDrawingView)`

```csharp
interface SectionDrawingView
{
    // Properties
    string ActiveMemberName { get; set; }
    string ActiveModelState { get; }
    string ActivePositionalRepresentation { get; set; }
    string ActivePresentationView { get; }
    bool Aligned { get; set; }
    AttributeSets AttributeSets { get; }
    DrawingCurve AuxiliaryOrientationEdge { get; }
    bool BitmapAvailable { get; }
    BreakOperations BreakOperations { get; }
    BreakOutOperations BreakOutOperations { get; }
    Camera Camera { get; }
    Point2d Center { get; set; }
    ClientGraphicsCollection ClientGraphicsCollection { get; }
    CropOperations CropOperations { get; } // since 2025
    DataIO DataIO { get; }
    bool DesignViewAssociative { get; }
    string DesignViewRepresentation { get; }
    bool DisplayBendExtents { get; set; }
    bool DisplayDefinitionInBase { get; set; }
    bool DisplayForeshortenedTangentEdges { get; set; }
    bool DisplayHatching { get; set; }
    bool DisplayInterferenceEdges { get; set; }
    bool DisplayTangentEdges { get; set; }
    bool DisplayThreadFeatures { get; set; }
    bool DisplayTrails { get; set; }
    DrawingCurvesEnumerator DrawingCurves[object ModelObject = Missing] { get; }
    DrawingViewEvents DrawingViewEvents { get; }
    Matrix DrawingViewToModelTransform { get; }
    Matrix DrawingViewToSheetTransform { get; }
    bool FullSectionDepth { get; set; }
    GeneralDimensionTypeEnum GeneralDimensionType { get; set; }
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    bool HasOriginIndicator { get; }
    DrawingViewHatchRegions HatchRegions { get; }
    double Height { get; }
    bool HiddenLineCalculationForAllBodies { get; set; }
    bool Include3DAnnotations { get; set; }
    bool IncludeMeshBodies { get; set; }
    bool IncludeSlice { get; set; }
    bool IncludeSurfaceBodies { get; set; }
    bool InheritBreak { get; set; }
    bool InheritBreakOut { get; set; }
    bool InheritSection { get; set; }
    bool InheritSlice { get; set; }
    bool IsBreakLineSmooth { get; set; }
    bool IsFlatPatternView { get; }
    bool IsRasterView { get; set; }
    bool IsTextPropertySource { get; set; }
    bool IsUpdateComplete { get; }
    DrawingViewLabel Label { get; }
    double Left { get; }
    double Margin { get; set; }
    Matrix ModelToDrawingViewTransform { get; }
    Matrix ModelToSheetTransform { get; }
    string Name { get; set; }
    OriginIndicator OriginIndicator { get; }
    Sheet Parent { get; }
    DrawingView ParentView { get; }
    Point2d Position { get; set; }
    bool PresentationViewAssociative { get; set; }
    ReferenceDataDisplayStyleEnum ReferenceDataDisplayStyle { get; set; }
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    RevisionClouds RevisionClouds { get; }
    double Rotation { get; set; }
    double Scale { get; set; }
    bool ScaleFromBase { get; set; }
    string ScaleString { get; set; }
    double SectionDepth { get; set; }
    DrawingSketch SectionLineSketch { get; }
    Matrix SheetToDrawingViewTransform { get; }
    Matrix SheetToModelTransform { get; }
    bool ShowEntireLine { get; set; }
    bool ShowLabel { get; set; }
    bool ShowTrails { get; set; } // since 2026
    DrawingSketches Sketches { get; }
    bool SliceAllParts { get; set; }
    StandardPartsSectionBehaviorEnum StandardPartsSectionBehavior { get; set; }
    bool Suppressed { get; set; }
    double Top { get; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    bool UseAlignedMethod { get; set; }
    DrawingViewAnnotation ViewAnnotation { get; } // since 2026
    ViewJustificationEnum ViewJustification { get; set; }
    bool ViewOrientationFromBase { get; set; }
    DrawingViewStyleEnum ViewStyle { get; set; }
    DrawingViewTypeEnum ViewType { get; }
    double Width { get; }
    // Methods
    void Align(DrawingView DrawingView, DrawingViewAlignmentEnum AlignmentType);
    void AlignAuxiliary(DrawingCurve DrawingCurve, Point2d Position);
    DrawingView CopyTo(Sheet TargetSheet);
    void CreateOriginIndicator(GeometryIntent Intent);
    void Delete();
    Line DrawingViewToModelSpace(Point2d ViewCoordinate);
    Point2d DrawingViewToSheetSpace(Point2d ViewCoordinate);
    void GetAutomatedCenterlineSettings(out AutomatedCenterlineSettings AutomatedCenterlineSettings);
    Color GetComponentLineColor(object Component); // since 2025
    HiddenLinesStatusEnum GetHiddenLinesStatus(object Component);
    bool GetIncludeStatus(object Object);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    bool GetVisibility(object Object);
    void GetWeldmentState(out WeldmentStateEnum WeldmentState, out object Component);
    void InsertInModelSpace();
    Point2d ModelToDrawingViewSpace(Point ModelCoordinate);
    Point2d ModelToSheetSpace(Point ModelCoordinate);
    DrawingView MoveTo(Sheet TargetSheet);
    void ReverseDirection();
    void RotateByAngle(double Angle, bool Clockwise = true);
    void SetActiveModelState(string ModelState, bool UpdatePartsList = true, bool KeepOverrides = true);
    ObjectsEnumerator SetAutomatedCenterlineSettings(object AutomatedCenterlineSettings = Missing);
    void SetComponentLineColor(object Component, Color Color); // since 2025
    void SetDesignViewRepresentation(string Representation, bool Associative = false);
    void SetHiddenLinesStatus(object Component, HiddenLinesStatusEnum visibleStatus);
    void SetIncludeStatus(object Object, bool Include);
    void SetVisibility(object Object, bool Visible);
    void SetWeldmentState(WeldmentStateEnum WeldmentState, object Component = Missing);
    Point2d SheetToDrawingViewSpace(Point2d SheetCoordinate);
    Line SheetToModelSpace(Point2d SheetCoordinate);
    void ShowHiddenAnnotations();
    void ShowHiddenCurves();
}
```

7 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingViews](../objects/DrawingViews.md).AddSectionView, [DrawingViews](../objects/DrawingViews.md).AddSectionView2

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [AutomatedCenterlineSettings](../objects/AutomatedCenterlineSettings.md), [BreakOperations](../objects/BreakOperations.md), [BreakOutOperations](../objects/BreakOutOperations.md), [Camera](../objects/Camera.md), [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md), [Color](../objects/Color.md), [CropOperations](../objects/CropOperations.md), [DataIO](../objects/DataIO.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [DrawingCurve](../objects/DrawingCurve.md), [DrawingCurvesEnumerator](../objects/DrawingCurvesEnumerator.md), [DrawingSketch](../objects/DrawingSketch.md), [DrawingSketches](../objects/DrawingSketches.md), [DrawingView](../objects/DrawingView.md), [DrawingViewAlignmentEnum](../enums/DrawingViewAlignmentEnum.md), [DrawingViewAnnotation](../objects/DrawingViewAnnotation.md), [DrawingViewEvents](../objects/DrawingViewEvents.md), [DrawingViewHatchRegions](../objects/DrawingViewHatchRegions.md), [DrawingViewLabel](../objects/DrawingViewLabel.md), [DrawingViewStyleEnum](../enums/DrawingViewStyleEnum.md), [DrawingViewTypeEnum](../enums/DrawingViewTypeEnum.md), [GeneralDimensionTypeEnum](../enums/GeneralDimensionTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md), [HiddenLinesStatusEnum](../enums/HiddenLinesStatusEnum.md), [Line](../objects/Line.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [OriginIndicator](../objects/OriginIndicator.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [ReferenceDataDisplayStyleEnum](../enums/ReferenceDataDisplayStyleEnum.md), [RevisionClouds](../objects/RevisionClouds.md), [Sheet](../objects/Sheet.md), [StandardPartsSectionBehaviorEnum](../enums/StandardPartsSectionBehaviorEnum.md), [ViewJustificationEnum](../enums/ViewJustificationEnum.md), [WeldmentStateEnum](../enums/WeldmentStateEnum.md)

