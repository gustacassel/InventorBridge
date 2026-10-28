# ComponentDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.PointClouds.Parent`

```csharp
interface ComponentDefinition
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    BOMQuantity BOMQuantity { get; }
    BOMStructureEnum BOMStructure { get; set; }
    ClientGraphicsCollection ClientGraphicsCollection { get; }
    DataIO DataIO { get; }
    object Document { get; }
    string ModelGeometryVersion { get; }
    ComponentOccurrences Occurrences { get; }
    OrientedBox OrientedMinimumRangeBox { get; }
    Box PreciseRangeBox { get; }
    Box RangeBox { get; }
    SurfaceBodies SurfaceBodies { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ObjectsEnumerator FindUsingPoint(Point Point, ref SelectionFilterEnum[] ObjectTypes, object ProximityTolerance = Missing, bool VisibleObjectsOnly = true);
    ObjectsEnumerator FindUsingVector(Point OriginPoint, UnitVector Direction, ref SelectionFilterEnum[] ObjectTypes, bool UseCylinder = true, object ProximityTolerance = Missing, bool VisibleObjectsOnly = true, out object LocationPoints = Missing);
    void GetUnusedGeometries(out ObjectCollection UnusedGeometries);
    void PurgeUnusedGeometries(object UnusedGeometries = Missing);
    void RepositionObject(object TargetObject, bool Before, object StartObject, object EndObject = Missing); // since 2025
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AliasFreeformFeature](../objects/AliasFreeformFeature.md).Parent, [AliasFreeformFeatureProxy](../objects/AliasFreeformFeatureProxy.md).Parent, [AnalysisManager](../objects/AnalysisManager.md).Parent, [AngularModelDimension](../objects/AngularModelDimension.md).Parent, [AngularModelDimensionProxy](../objects/AngularModelDimensionProxy.md).Parent, [AnnotationPlane](../objects/AnnotationPlane.md).Parent, [AnnotationPlaneProxy](../objects/AnnotationPlaneProxy.md).Parent, [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).ComponentDefinition, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).ComponentDefinition, [BIMComponent](../objects/BIMComponent.md).ComponentDefinition, [BOMQuantity](../objects/BOMQuantity.md).Parent, [BendFeature](../objects/BendFeature.md).Parent, [BendFeatureProxy](../objects/BendFeatureProxy.md).Parent, [BendPartFeature](../objects/BendPartFeature.md).Parent, [BendPartFeatureProxy](../objects/BendPartFeatureProxy.md).Parent, [BossFeature](../objects/BossFeature.md).Parent, [BossFeatureProxy](../objects/BossFeatureProxy.md).Parent, [BoundaryPatchFeature](../objects/BoundaryPatchFeature.md).Parent, [BoundaryPatchFeatureProxy](../objects/BoundaryPatchFeatureProxy.md).Parent, [ChamferFeature](../objects/ChamferFeature.md).Parent, [ChamferFeatureProxy](../objects/ChamferFeatureProxy.md).Parent, [CircularPatternFeature](../objects/CircularPatternFeature.md).Parent, [CircularPatternFeatureProxy](../objects/CircularPatternFeatureProxy.md).Parent, [ClientFeature](../objects/ClientFeature.md).Parent, [ClientFeatureProxy](../objects/ClientFeatureProxy.md).Parent, [CoilFeature](../objects/CoilFeature.md).Parent, [CoilFeatureProxy](../objects/CoilFeatureProxy.md).Parent, [CombineFeature](../objects/CombineFeature.md).Parent, [CombineFeatureProxy](../objects/CombineFeatureProxy.md).Parent, [ComponentDefinitions](../objects/ComponentDefinitions.md).Item, [ComponentDefinitionsEnumerator](../objects/ComponentDefinitionsEnumerator.md).Item, [ComponentOccurrence](../objects/ComponentOccurrence.md).ContextDefinition, [ComponentOccurrence](../objects/ComponentOccurrence.md).Definition, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).ContextDefinition, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).Definition, [ContourFlangeFeature](../objects/ContourFlangeFeature.md).Parent, [ContourFlangeFeatureProxy](../objects/ContourFlangeFeatureProxy.md).Parent, [ContourRollFeature](../objects/ContourRollFeature.md).Parent, [ContourRollFeatureProxy](../objects/ContourRollFeatureProxy.md).Parent, [CornerChamferFeature](../objects/CornerChamferFeature.md).Parent and 196 more (see `members.tsv`)

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [BOMQuantity](../objects/BOMQuantity.md), [BOMStructureEnum](../enums/BOMStructureEnum.md), [Box](../objects/Box.md), [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md), [ComponentOccurrences](../objects/ComponentOccurrences.md), [DataIO](../objects/DataIO.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [OrientedBox](../objects/OrientedBox.md), [Point](../objects/Point.md), [SelectionFilterEnum](../enums/SelectionFilterEnum.md), [SurfaceBodies](../objects/SurfaceBodies.md), [UnitVector](../objects/UnitVector.md)

