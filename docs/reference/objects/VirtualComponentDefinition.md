# VirtualComponentDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ComponentDefinition](../objects/ComponentDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.PointClouds.Parent → (VirtualComponentDefinition)`

```csharp
interface VirtualComponentDefinition
{
    // Properties
    Asset ActiveMaterial { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    BOMQuantity BOMQuantity { get; }
    BOMStructureEnum BOMStructure { get; set; }
    ClientGraphicsCollection ClientGraphicsCollection { get; }
    DataIO DataIO { get; }
    string DisplayName { get; set; }
    object Document { get; }
    string ModelGeometryVersion { get; }
    ComponentOccurrences Occurrences { get; }
    OrientedBox OrientedMinimumRangeBox { get; }
    Box PreciseRangeBox { get; }
    PropertySets PropertySets { get; }
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

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [BOMQuantity](../objects/BOMQuantity.md), [BOMStructureEnum](../enums/BOMStructureEnum.md), [Box](../objects/Box.md), [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md), [ComponentOccurrences](../objects/ComponentOccurrences.md), [DataIO](../objects/DataIO.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [OrientedBox](../objects/OrientedBox.md), [Point](../objects/Point.md), [PropertySets](../objects/PropertySets.md), [SelectionFilterEnum](../enums/SelectionFilterEnum.md), [SurfaceBodies](../objects/SurfaceBodies.md), [UnitVector](../objects/UnitVector.md)

