# FlatPattern

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ComponentDefinition](../objects/ComponentDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).FlatPattern`

```csharp
interface FlatPattern
{
    // Properties
    ASideDefinition ASideFace { get; }
    AnnotationPlanes AnnotationPlanes { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    BOMQuantity BOMQuantity { get; }
    BOMStructureEnum BOMStructure { get; set; }
    Face BaseFace { get; }
    BendAngleTypeEnum BendAngleReportType { get; set; }
    SurfaceBody Body { get; }
    Face BottomFace { get; }
    ClientGraphicsCollection ClientGraphicsCollection { get; }
    DataIO DataIO { get; }
    object Document { get; }
    FlatPatternFeatures Features { get; }
    FlatBendResults FlatBendResults { get; }
    FlatPatternOrientations FlatPatternOrientations { get; }
    FlatPunchResults FlatPunchResults { get; }
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    bool IgnorePunchToolFeaturesRepresentationOverrides { get; set; }
    double Length { get; }
    MassProperties MassProperties { get; }
    ModelAnnotations ModelAnnotations { get; }
    string ModelGeometryVersion { get; }
    ModelToleranceFeatures ModelToleranceFeatures { get; }
    ComponentOccurrences Occurrences { get; }
    OrientedBox OrientedMinimumRangeBox { get; }
    Parameters Parameters { get; }
    SheetMetalComponentDefinition Parent { get; }
    PartEvents PartEvents { get; }
    Box PreciseRangeBox { get; }
    PunchRepresentationTypeEnum PunchRepresentationType { get; set; }
    Box RangeBox { get; }
    RepresentationsManager RepresentationsManager { get; }
    bool RolledBackForEdit { get; }
    SketchBlockDefinitions SketchBlockDefinitions { get; }
    PlanarSketches Sketches { get; }
    Sketches3D Sketches3D { get; }
    SurfaceBodies SurfaceBodies { get; }
    Face TopFace { get; }
    ObjectTypeEnum Type { get; }
    UserCoordinateSystems UserCoordinateSystems { get; }
    double Width { get; }
    WorkAxes WorkAxes { get; }
    WorkPlanes WorkPlanes { get; }
    WorkPoints WorkPoints { get; }
    // Methods
    GeometryIntent CreateGeometryIntent(object Geometry, object Intent = Missing);
    void Delete();
    void DeleteObjects(ObjectCollection Objects, bool RetainConsumedSketches = false, bool RetainDepFeatsAndSketches = false, bool RetainDepWorkFeats = false);
    void Edit();
    void ExitEdit();
    ObjectsEnumerator FindUsingPoint(Point Point, ref SelectionFilterEnum[] ObjectTypes, object ProximityTolerance = Missing, bool VisibleObjectsOnly = true);
    void FindUsingRay(Point RayStartPoint, UnitVector RayDirection, double Radius, out ObjectsEnumerator FoundEntities, out ObjectsEnumerator LocationPoints, bool FindFirstOnly = false);
    ObjectsEnumerator FindUsingVector(Point OriginPoint, UnitVector Direction, ref SelectionFilterEnum[] ObjectTypes, bool UseCylinder = true, object ProximityTolerance = Missing, bool VisibleObjectsOnly = true, out object LocationPoints = Missing);
    Edges GetEdgesOfType(FlatPatternEdgeTypeEnum EdgeType, bool TopFaceEdges = true);
    void GetEndOfPartPosition(out object After, out object Before);
    object GetFlatPatternEntity(object SheetMetalEntity);
    object GetSheetMetalEntity(object FlatPatternEntity);
    void GetUnusedGeometries(out ObjectCollection UnusedGeometries);
    void PurgeUnusedGeometries(object UnusedGeometries = Missing);
    void RepositionObject(object TargetObject, bool Before, object StartObject, object EndObject = Missing); // since 2025
    void SetEndOfPartToTopOrBottom(bool SetToTop);
    void SuppressFeatures(ObjectCollection Features);
    void UnsuppressFeatures(ObjectCollection Features);
}
```

17 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatBendResult](../objects/FlatBendResult.md).Parent, [FlatPatternOrientation](../objects/FlatPatternOrientation.md).Parent, [FlatPunchResult](../objects/FlatPunchResult.md).Parent, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).FlatPattern

**Referenced types:** [ASideDefinition](../objects/ASideDefinition.md), [AnnotationPlanes](../objects/AnnotationPlanes.md), [AttributeSets](../objects/AttributeSets.md), [BOMQuantity](../objects/BOMQuantity.md), [BOMStructureEnum](../enums/BOMStructureEnum.md), [BendAngleTypeEnum](../enums/BendAngleTypeEnum.md), [Box](../objects/Box.md), [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md), [ComponentOccurrences](../objects/ComponentOccurrences.md), [DataIO](../objects/DataIO.md), [Edges](../objects/Edges.md), [Face](../objects/Face.md), [FlatBendResults](../objects/FlatBendResults.md), [FlatPatternEdgeTypeEnum](../enums/FlatPatternEdgeTypeEnum.md), [FlatPatternFeatures](../objects/FlatPatternFeatures.md), [FlatPatternOrientations](../objects/FlatPatternOrientations.md), [FlatPunchResults](../objects/FlatPunchResults.md), [GeometryIntent](../objects/GeometryIntent.md), [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md), [MassProperties](../objects/MassProperties.md), [ModelAnnotations](../objects/ModelAnnotations.md), [ModelToleranceFeatures](../objects/ModelToleranceFeatures.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [OrientedBox](../objects/OrientedBox.md), [Parameters](../objects/Parameters.md), [PartEvents](../objects/PartEvents.md), [PlanarSketches](../objects/PlanarSketches.md), [Point](../objects/Point.md), [PunchRepresentationTypeEnum](../enums/PunchRepresentationTypeEnum.md), [RepresentationsManager](../objects/RepresentationsManager.md), [SelectionFilterEnum](../enums/SelectionFilterEnum.md), [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md), [SketchBlockDefinitions](../objects/SketchBlockDefinitions.md), [Sketches3D](../objects/Sketches3D.md), [SurfaceBodies](../objects/SurfaceBodies.md), [SurfaceBody](../objects/SurfaceBody.md), [UnitVector](../objects/UnitVector.md), [UserCoordinateSystems](../objects/UserCoordinateSystems.md), [WorkAxes](../objects/WorkAxes.md), [WorkPlanes](../objects/WorkPlanes.md), [WorkPoints](../objects/WorkPoints.md)

