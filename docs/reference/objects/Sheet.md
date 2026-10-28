# Sheet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet`

```csharp
interface Sheet
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    AutoCADBlocks AutoCADBlocks { get; }
    Balloons Balloons { get; }
    Border Border { get; }
    Centerlines Centerlines { get; }
    Centermarks Centermarks { get; }
    ClientGraphicsCollection ClientGraphicsCollection { get; }
    ClientViews ClientViews { get; }
    CustomTables CustomTables { get; }
    DataIO DataIO { get; }
    DrawingDimensions DrawingDimensions { get; }
    DrawingNotes DrawingNotes { get; }
    DrawingViews DrawingViews { get; }
    EdgeSymbols EdgeSymbols { get; }
    bool ExcludeFromCount { get; set; }
    bool ExcludeFromPrinting { get; set; }
    FeatureControlFrames FeatureControlFrames { get; }
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    double Height { get; set; }
    HoleTables HoleTables { get; }
    bool IsModelSpaceSheet { get; }
    string Name { get; set; }
    PageOrientationTypeEnum Orientation { get; set; }
    object Parent { get; }
    PartsLists PartsLists { get; }
    string Revision { get; set; }
    RevisionClouds RevisionClouds { get; }
    RevisionTables RevisionTables { get; }
    DrawingSheetSizeEnum Size { get; set; }
    SketchedSymbols SketchedSymbols { get; }
    DrawingSketches Sketches { get; }
    DrawingSheetStatusBits Status { get; }
    SurfaceTextureSymbols SurfaceTextureSymbols { get; }
    string TextPropertySource { get; set; }
    TitleBlock TitleBlock { get; }
    TransitionSymbols TransitionSymbols { get; } // since 2025
    ObjectTypeEnum Type { get; }
    DrawingWeldingSymbols WeldingSymbols { get; }
    double Width { get; set; }
    // Methods
    void Activate();
    Border AddBorder(object BorderDefinition, object PromptStrings = Missing);
    DefaultBorder AddDefaultBorder(object HorizontalZoneCount = Missing, object HorizontalZoneLabelMode = Missing, object VerticalZoneCount = Missing, object VerticalZoneLabelMode = Missing, object LabelFromBottomRight = Missing, object DelimitByLines = Missing, object Centermarks = Missing, object TopMargin = Missing, object BottomMargin = Missing, object LeftMargin = Missing, object RightMargin = Missing, object TextStyle = Missing, object TextLayer = Missing, object LineLayer = Missing);
    TitleBlock AddTitleBlock(object TitleBlockDefinition, object TitleBlockLocation = Missing, object PromptStrings = Missing);
    void ChangeLayer(ObjectCollection Objects, Layer Layer);
    Sheet CopyTo(DrawingDocument TargetDocument);
    GeometryIntent CreateGeometryIntent(object Geometry, object Intent = Missing);
    void Delete(bool RetainDependentViews = false);
    ObjectsEnumerator FindUsingPoint(Point2d PointOnSheet, object ProximityTolerance = Missing);
    string[] GetAvailableDesignViewsToRetrieve3DAnnotations(DrawingView View); // since 2025
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    ObjectCollection GetRetrievableAnnotations2(DrawingView View, object SketchAndFeatureDimensions = Missing, object ModelObject = Missing, object DesignView = Missing); // since 2026
    ObjectsEnumerator RetrieveAnnotations2(object ViewOrSketch, object AnnotationsToRetrieve = Missing); // since 2026
    void Update();
}
```

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngularGeneralDimension](../objects/AngularGeneralDimension.md).Parent, [AutoCADBlock](../objects/AutoCADBlock.md).Parent, [Balloon](../objects/Balloon.md).Parent, [BaselineDimensionSet](../objects/BaselineDimensionSet.md).Parent, [BendNote](../objects/BendNote.md).Parent, [Border](../objects/Border.md).Parent, [Centerline](../objects/Centerline.md).Parent, [Centermark](../objects/Centermark.md).Parent, [ChainDimensionSet](../objects/ChainDimensionSet.md).Parent, [ChamferNote](../objects/ChamferNote.md).Parent, [DefaultBorder](../objects/DefaultBorder.md).Parent, [DetailDrawingView](../objects/DetailDrawingView.md).Parent, [DiameterGeneralDimension](../objects/DiameterGeneralDimension.md).Parent, [DrawingDimension](../objects/DrawingDimension.md).Parent, [DrawingDocument](../objects/DrawingDocument.md).ActiveSheet, [DrawingNote](../objects/DrawingNote.md).Parent, [DrawingView](../objects/DrawingView.md).Parent, [DrawingWeldingSymbol](../objects/DrawingWeldingSymbol.md).Parent, [EdgeSymbol](../objects/EdgeSymbol.md).Parent, [FeatureControlFrame](../objects/FeatureControlFrame.md).Parent, [GeneralDimension](../objects/GeneralDimension.md).Parent, [GeneralNote](../objects/GeneralNote.md).Parent, [HoleTable](../objects/HoleTable.md).Parent, [HoleThreadNote](../objects/HoleThreadNote.md).Parent, [LeaderNote](../objects/LeaderNote.md).Parent, [LinearGeneralDimension](../objects/LinearGeneralDimension.md).Parent, [OrdinateDimension](../objects/OrdinateDimension.md).Parent, [OrdinateDimensionSet](../objects/OrdinateDimensionSet.md).Parent, [PartsList](../objects/PartsList.md).Parent, [PunchNote](../objects/PunchNote.md).Parent, [RadiusGeneralDimension](../objects/RadiusGeneralDimension.md).Parent, [RevisionTable](../objects/RevisionTable.md).Parent, [SectionDrawingView](../objects/SectionDrawingView.md).Parent, [Sheet](../objects/Sheet.md).CopyTo, [Sheets](../objects/Sheets.md).Add, [Sheets](../objects/Sheets.md).AddUsingSheetFormat, [Sheets](../objects/Sheets.md).Item, [SketchedSymbol](../objects/SketchedSymbol.md).Parent, [SurfaceTextureANSIDefinition](../objects/SurfaceTextureANSIDefinition.md).Parent, [SurfaceTextureBSIDefinition](../objects/SurfaceTextureBSIDefinition.md).Parent and 9 more (see `members.tsv`)

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [AutoCADBlocks](../objects/AutoCADBlocks.md), [Balloons](../objects/Balloons.md), [Border](../objects/Border.md), [Centerlines](../objects/Centerlines.md), [Centermarks](../objects/Centermarks.md), [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md), [ClientViews](../objects/ClientViews.md), [CustomTables](../objects/CustomTables.md), [DataIO](../objects/DataIO.md), [DefaultBorder](../objects/DefaultBorder.md), [DrawingDimensions](../objects/DrawingDimensions.md), [DrawingDocument](../objects/DrawingDocument.md), [DrawingNotes](../objects/DrawingNotes.md), [DrawingSheetSizeEnum](../enums/DrawingSheetSizeEnum.md), [DrawingSheetStatusBits](../enums/DrawingSheetStatusBits.md), [DrawingSketches](../objects/DrawingSketches.md), [DrawingView](../objects/DrawingView.md), [DrawingViews](../objects/DrawingViews.md), [DrawingWeldingSymbols](../objects/DrawingWeldingSymbols.md), [EdgeSymbols](../objects/EdgeSymbols.md), [FeatureControlFrames](../objects/FeatureControlFrames.md), [GeometryIntent](../objects/GeometryIntent.md), [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md), [HoleTables](../objects/HoleTables.md), [Layer](../objects/Layer.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [PageOrientationTypeEnum](../enums/PageOrientationTypeEnum.md), [PartsLists](../objects/PartsLists.md), [Point2d](../objects/Point2d.md), [RevisionClouds](../objects/RevisionClouds.md), [RevisionTables](../objects/RevisionTables.md), [SketchedSymbols](../objects/SketchedSymbols.md), [SurfaceTextureSymbols](../objects/SurfaceTextureSymbols.md), [TitleBlock](../objects/TitleBlock.md), [TransitionSymbols](../objects/TransitionSymbols.md)

