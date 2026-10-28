# WeldmentComponentDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md) → [ComponentDefinition](../objects/ComponentDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition → (WeldmentComponentDefinition)`

```csharp
interface WeldmentComponentDefinition
{
    // Properties
    ComponentOccurrence ActiveOccurrence { get; }
    ObjectsEnumerator AppearanceOverridesObjects { get; }
    object Application { get; }
    AssemblyEvents AssemblyEvents { get; }
    AttributeSets AttributeSets { get; }
    BIMComponent BIMComponent { get; }
    BOM BOM { get; }
    BOMQuantity BOMQuantity { get; }
    BOMStructureEnum BOMStructure { get; set; }
    ClientGraphicsCollection ClientGraphicsCollection { get; }
    AssemblyConstraints Constraints { get; }
    DataIO DataIO { get; }
    Asset DefaultVirtualComponentMaterial { get; set; }
    object Document { get; }
    Document FactoryDocument { get; }
    Features Features { get; }
    ImportedComponents ImportedComponents { get; }
    bool IsModelStateFactory { get; }
    bool IsModelStateMember { get; }
    bool IsiAssemblyFactory { get; }
    bool IsiAssemblyMember { get; }
    AssemblyJoints Joints { get; }
    Machining Machining { get; }
    MassProperties MassProperties { get; }
    ModelAnnotations ModelAnnotations { get; }
    string ModelGeometryVersion { get; }
    ModelStates ModelStates { get; }
    OccurrencePatterns OccurrencePatterns { get; }
    ComponentOccurrences Occurrences { get; }
    OrientedBox OrientedMinimumRangeBox { get; }
    Parameters Parameters { get; }
    AssemblyDocument Parent { get; }
    PointClouds PointClouds { get; }
    Box PreciseRangeBox { get; }
    Preparations Preparations { get; }
    Box RangeBox { get; }
    RepresentationsManager RepresentationsManager { get; }
    RevitExports RevitExports { get; }
    SimulationManager SimulationManager { get; }
    PlanarSketches Sketches { get; }
    SurfaceBodies SurfaceBodies { get; }
    ObjectTypeEnum Type { get; }
    UserCoordinateSystems UserCoordinateSystems { get; }
    Asset WeldBeadAppearance { get; set; }
    AppearanceSourceTypeEnum WeldBeadAppearanceSourceType { get; set; }
    Asset WeldBeadMaterial { get; set; }
    Asset WeldEndFillAppearance { get; set; }
    AppearanceSourceTypeEnum WeldEndFillAppearanceSourceType { get; set; }
    Welds Welds { get; }
    WeldsComponentDefinition WeldsComponentDefinition { get; }
    WorkAxes WorkAxes { get; }
    WorkPlanes WorkPlanes { get; }
    WorkPoints WorkPoints { get; }
    iAssemblyFactory iAssemblyFactory { get; }
    iAssemblyMember iAssemblyMember { get; }
    iMateDefinitions iMateDefinitions { get; }
    iMateResults iMateResults { get; }
    // Methods
    object AdjustProxyContext(object ObjectProxy);
    InterferenceResults AnalyzeInterference(ObjectCollection Set1, object Set2 = Missing);
    void ClearAppearanceOverrides(object AppearanceOverrideObjects = Missing);
    iAssemblyFactory CreateFactory();
    GeometryIntent CreateGeometryIntent(object Geometry, object Intent = Missing);
    VisibleOccurrenceFinder CreateVisibleOccurrenceFinder(bool Visible, double PercentageVisible, bool Compact);
    void ExportObjects(ObjectCollection Objects);
    ObjectsEnumerator FindUsingPoint(Point Point, ref SelectionFilterEnum[] ObjectTypes, object ProximityTolerance = Missing, bool VisibleObjectsOnly = true);
    void FindUsingRay(Point RayStartPoint, UnitVector RayDirection, double Radius, out ObjectsEnumerator FoundEntities, out ObjectsEnumerator LocationPoints, bool FindFirstOnly = false);
    ObjectsEnumerator FindUsingVector(Point OriginPoint, UnitVector Direction, ref SelectionFilterEnum[] ObjectTypes, bool UseCylinder = true, object ProximityTolerance = Missing, bool VisibleObjectsOnly = true, out object LocationPoints = Missing);
    void GetEndOfFeaturesPosition(out object After, out object Before);
    void GetUnusedGeometries(out ObjectCollection UnusedGeometries);
    void HideAllRelationships();
    void PurgeUnusedGeometries(object UnusedGeometries = Missing);
    void RepositionObject(object TargetObject, bool Before, object StartObject, object EndObject = Missing); // since 2025
    void SetEndOfFeaturesToTopOrBottom(bool SetToTop);
    void SetOccurrencesProperty(ObjectCollection pOccurrences, string PropertyName, object Value);
    void SuppressFeatures(ObjectCollection Features);
    void TransformOccurrences(ObjectCollection Occurrences, ObjectCollection Transforms, bool IgnoreConstraints = false);
    void UnsuppressFeatures(ObjectCollection Features);
}
```

14 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [AssemblyConstraints](../objects/AssemblyConstraints.md), [AssemblyDocument](../objects/AssemblyDocument.md), [AssemblyEvents](../objects/AssemblyEvents.md), [AssemblyJoints](../objects/AssemblyJoints.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [BIMComponent](../objects/BIMComponent.md), [BOM](../objects/BOM.md), [BOMQuantity](../objects/BOMQuantity.md), [BOMStructureEnum](../enums/BOMStructureEnum.md), [Box](../objects/Box.md), [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ComponentOccurrences](../objects/ComponentOccurrences.md), [DataIO](../objects/DataIO.md), [Document](../objects/Document.md), [Features](../objects/Features.md), [GeometryIntent](../objects/GeometryIntent.md), [ImportedComponents](../objects/ImportedComponents.md), [InterferenceResults](../objects/InterferenceResults.md), [Machining](../objects/Machining.md), [MassProperties](../objects/MassProperties.md), [ModelAnnotations](../objects/ModelAnnotations.md), [ModelStates](../objects/ModelStates.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [OccurrencePatterns](../objects/OccurrencePatterns.md), [OrientedBox](../objects/OrientedBox.md), [Parameters](../objects/Parameters.md), [PlanarSketches](../objects/PlanarSketches.md), [Point](../objects/Point.md), [PointClouds](../objects/PointClouds.md), [Preparations](../objects/Preparations.md), [RepresentationsManager](../objects/RepresentationsManager.md), [RevitExports](../objects/RevitExports.md), [SelectionFilterEnum](../enums/SelectionFilterEnum.md), [SimulationManager](../objects/SimulationManager.md), [SurfaceBodies](../objects/SurfaceBodies.md), [UnitVector](../objects/UnitVector.md), [UserCoordinateSystems](../objects/UserCoordinateSystems.md), [VisibleOccurrenceFinder](../objects/VisibleOccurrenceFinder.md), [Welds](../objects/Welds.md), [WeldsComponentDefinition](../objects/WeldsComponentDefinition.md), [WorkAxes](../objects/WorkAxes.md), [WorkPlanes](../objects/WorkPlanes.md), [WorkPoints](../objects/WorkPoints.md), [iAssemblyFactory](../objects/iAssemblyFactory.md), [iAssemblyMember](../objects/iAssemblyMember.md), [iMateDefinitions](../objects/iMateDefinitions.md), [iMateResults](../objects/iMateResults.md)

