# PartComponentDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ComponentDefinition](../objects/ComponentDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition`

```csharp
interface PartComponentDefinition
{
    // Properties
    AnalysisManager AnalysisManager { get; }
    AnnotationPlanes AnnotationPlanes { get; }
    ObjectsEnumerator AppearanceOverridesObjects { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    BIMComponent BIMComponent { get; }
    BOMQuantity BOMQuantity { get; }
    BOMStructureEnum BOMStructure { get; set; }
    ClientGraphicsCollection ClientGraphicsCollection { get; }
    bool CompactModelHistoryOnNextSave { get; set; }
    DataIO DataIO { get; }
    object Document { get; }
    Document FactoryDocument { get; }
    PartFeatures Features { get; }
    bool HasMultipleSolidBodies { get; }
    bool IsContentMember { get; }
    bool IsModelStateFactory { get; }
    bool IsModelStateMember { get; }
    bool IsiPartFactory { get; }
    bool IsiPartMember { get; }
    MassProperties MassProperties { get; }
    MeshFeatureSets MeshFeatureSets { get; }
    ModelAnnotations ModelAnnotations { get; }
    string ModelGeometryVersion { get; }
    ModelStates ModelStates { get; }
    ModelToleranceFeatures ModelToleranceFeatures { get; }
    ComponentOccurrences Occurrences { get; }
    OrientedBox OrientedMinimumRangeBox { get; }
    Parameters Parameters { get; }
    PartEvents PartEvents { get; }
    PointClouds PointClouds { get; }
    Box PreciseRangeBox { get; }
    Box RangeBox { get; }
    ReferenceComponents ReferenceComponents { get; }
    RepresentationsManager RepresentationsManager { get; }
    bool RolledBackForEdit { get; }
    SketchBlockDefinitions SketchBlockDefinitions { get; }
    PlanarSketches Sketches { get; }
    Sketches3D Sketches3D { get; }
    SurfaceBodies SurfaceBodies { get; }
    ObjectTypeEnum Type { get; }
    UserCoordinateSystems UserCoordinateSystems { get; }
    WorkAxes WorkAxes { get; }
    WorkPlanes WorkPlanes { get; }
    WorkPoints WorkPoints { get; }
    WorkSurfaces WorkSurfaces { get; }
    iMateDefinitions iMateDefinitions { get; }
    iPartFactory iPartFactory { get; }
    iPartMember iPartMember { get; }
    // Methods
    void ClearAppearanceOverrides(object AppearanceOverrideObjects = Missing);
    iPartFactory CreateFactory();
    GeometryIntent CreateGeometryIntent(object Geometry, object Intent = Missing);
    void DeleteObjects(ObjectCollection Objects, bool RetainConsumedSketches = false, bool RetainDepFeatsAndSketches = false, bool RetainDepWorkFeats = false);
    void ExportObjects(ObjectCollection Objects);
    ObjectsEnumerator FindUsingPoint(Point Point, ref SelectionFilterEnum[] ObjectTypes, object ProximityTolerance = Missing, bool VisibleObjectsOnly = true);
    void FindUsingRay(Point RayStartPoint, UnitVector RayDirection, double Radius, out ObjectsEnumerator FoundEntities, out ObjectsEnumerator LocationPoints, bool FindFirstOnly = false);
    ObjectsEnumerator FindUsingVector(Point OriginPoint, UnitVector Direction, ref SelectionFilterEnum[] ObjectTypes, bool UseCylinder = true, object ProximityTolerance = Missing, bool VisibleObjectsOnly = true, out object LocationPoints = Missing);
    void GetEndOfPartPosition(out object After, out object Before);
    void GetUnusedGeometries(out ObjectCollection UnusedGeometries);
    void PurgeUnusedGeometries(object UnusedGeometries = Missing);
    void RepositionObject(object TargetObject, bool Before, object StartObject, object EndObject = Missing); // since 2025
    void SetEndOfPartToTopOrBottom(bool SetToTop);
    void SuppressFeatures(ObjectCollection Features);
    void UnsuppressFeatures(ObjectCollection Features);
}
```

8 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartComponentDefinitions](../objects/PartComponentDefinitions.md).Item, [PartDocument](../objects/PartDocument.md).ComponentDefinition

**Referenced types:** [AnalysisManager](../objects/AnalysisManager.md), [AnnotationPlanes](../objects/AnnotationPlanes.md), [AttributeSets](../objects/AttributeSets.md), [BIMComponent](../objects/BIMComponent.md), [BOMQuantity](../objects/BOMQuantity.md), [BOMStructureEnum](../enums/BOMStructureEnum.md), [Box](../objects/Box.md), [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md), [ComponentOccurrences](../objects/ComponentOccurrences.md), [DataIO](../objects/DataIO.md), [Document](../objects/Document.md), [GeometryIntent](../objects/GeometryIntent.md), [MassProperties](../objects/MassProperties.md), [MeshFeatureSets](../objects/MeshFeatureSets.md), [ModelAnnotations](../objects/ModelAnnotations.md), [ModelStates](../objects/ModelStates.md), [ModelToleranceFeatures](../objects/ModelToleranceFeatures.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [OrientedBox](../objects/OrientedBox.md), [Parameters](../objects/Parameters.md), [PartEvents](../objects/PartEvents.md), [PartFeatures](../objects/PartFeatures.md), [PlanarSketches](../objects/PlanarSketches.md), [Point](../objects/Point.md), [PointClouds](../objects/PointClouds.md), [ReferenceComponents](../objects/ReferenceComponents.md), [RepresentationsManager](../objects/RepresentationsManager.md), [SelectionFilterEnum](../enums/SelectionFilterEnum.md), [SketchBlockDefinitions](../objects/SketchBlockDefinitions.md), [Sketches3D](../objects/Sketches3D.md), [SurfaceBodies](../objects/SurfaceBodies.md), [UnitVector](../objects/UnitVector.md), [UserCoordinateSystems](../objects/UserCoordinateSystems.md), [WorkAxes](../objects/WorkAxes.md), [WorkPlanes](../objects/WorkPlanes.md), [WorkPoints](../objects/WorkPoints.md), [WorkSurfaces](../objects/WorkSurfaces.md), [iMateDefinitions](../objects/iMateDefinitions.md), [iPartFactory](../objects/iPartFactory.md), [iPartMember](../objects/iPartMember.md)

