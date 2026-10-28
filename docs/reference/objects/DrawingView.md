# DrawingView

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingViews.Item[…]`

```csharp
interface DrawingView
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
    GeneralDimensionTypeEnum GeneralDimensionType { get; set; }
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    bool HasOriginIndicator { get; }
    DrawingViewHatchRegions HatchRegions { get; }
    double Height { get; }
    bool HiddenLineCalculationForAllBodies { get; set; }
    bool Include3DAnnotations { get; set; }
    bool IncludeMeshBodies { get; set; }
    bool IncludeSurfaceBodies { get; set; }
    bool InheritBreak { get; set; }
    bool InheritBreakOut { get; set; }
    bool InheritSection { get; set; }
    bool InheritSlice { get; set; }
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
    Matrix SheetToDrawingViewTransform { get; }
    Matrix SheetToModelTransform { get; }
    bool ShowLabel { get; set; }
    bool ShowTrails { get; set; } // since 2026
    DrawingSketches Sketches { get; }
    StandardPartsSectionBehaviorEnum StandardPartsSectionBehavior { get; set; }
    bool Suppressed { get; set; }
    double Top { get; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
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

**Returned by:** [Balloon](../objects/Balloon.md).ParentView, [BreakOperation](../objects/BreakOperation.md).Parent, [BreakOutOperation](../objects/BreakOutOperation.md).Parent, [CropOperation](../objects/CropOperation.md).Parent, [DetailDrawingView](../objects/DetailDrawingView.md).CopyTo, [DetailDrawingView](../objects/DetailDrawingView.md).MoveTo, [DetailDrawingView](../objects/DetailDrawingView.md).ParentView, [DrawingCurve](../objects/DrawingCurve.md).Parent, [DrawingView](../objects/DrawingView.md).CopyTo, [DrawingView](../objects/DrawingView.md).MoveTo, [DrawingView](../objects/DrawingView.md).ParentView, [DrawingViewAnnotation](../objects/DrawingViewAnnotation.md).Parent, [DrawingViewEvents](../objects/DrawingViewEvents.md).Parent, [DrawingViewHatchRegion](../objects/DrawingViewHatchRegion.md).Parent, [DrawingViewLabel](../objects/DrawingViewLabel.md).Parent, [DrawingViews](../objects/DrawingViews.md).AddAssociativeDraftView, [DrawingViews](../objects/DrawingViews.md).AddAuxiliaryView, [DrawingViews](../objects/DrawingViews.md).AddBaseView, [DrawingViews](../objects/DrawingViews.md).AddDraftView, [DrawingViews](../objects/DrawingViews.md).AddOverlayView, [DrawingViews](../objects/DrawingViews.md).AddOverlayView2, [DrawingViews](../objects/DrawingViews.md).AddProjectedView, [DrawingViews](../objects/DrawingViews.md).Item, [HoleTable](../objects/HoleTable.md).ParentView, [SectionDrawingView](../objects/SectionDrawingView.md).CopyTo, [SectionDrawingView](../objects/SectionDrawingView.md).MoveTo, [SectionDrawingView](../objects/SectionDrawingView.md).ParentView

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [AutomatedCenterlineSettings](../objects/AutomatedCenterlineSettings.md), [BreakOperations](../objects/BreakOperations.md), [BreakOutOperations](../objects/BreakOutOperations.md), [Camera](../objects/Camera.md), [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md), [Color](../objects/Color.md), [CropOperations](../objects/CropOperations.md), [DataIO](../objects/DataIO.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [DrawingCurve](../objects/DrawingCurve.md), [DrawingCurvesEnumerator](../objects/DrawingCurvesEnumerator.md), [DrawingSketches](../objects/DrawingSketches.md), [DrawingViewAlignmentEnum](../enums/DrawingViewAlignmentEnum.md), [DrawingViewAnnotation](../objects/DrawingViewAnnotation.md), [DrawingViewEvents](../objects/DrawingViewEvents.md), [DrawingViewHatchRegions](../objects/DrawingViewHatchRegions.md), [DrawingViewLabel](../objects/DrawingViewLabel.md), [DrawingViewStyleEnum](../enums/DrawingViewStyleEnum.md), [DrawingViewTypeEnum](../enums/DrawingViewTypeEnum.md), [GeneralDimensionTypeEnum](../enums/GeneralDimensionTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md), [HiddenLinesStatusEnum](../enums/HiddenLinesStatusEnum.md), [Line](../objects/Line.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [OriginIndicator](../objects/OriginIndicator.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [ReferenceDataDisplayStyleEnum](../enums/ReferenceDataDisplayStyleEnum.md), [RevisionClouds](../objects/RevisionClouds.md), [Sheet](../objects/Sheet.md), [StandardPartsSectionBehaviorEnum](../enums/StandardPartsSectionBehaviorEnum.md), [ViewJustificationEnum](../enums/ViewJustificationEnum.md), [WeldmentStateEnum](../enums/WeldmentStateEnum.md)

