# PointCloudProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [PointCloud](../objects/PointCloud.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.PointClouds.Item[…] → (PointCloudProxy)`

```csharp
interface PointCloudProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    PointCloudCrops Crops { get; }
    int Density { get; set; }
    int DisplayedPointCount { get; }
    HealthStatusEnum HealthStatus { get; }
    int MaximumPointCount { get; set; }
    string Name { get; }
    PointCloud NativeObject { get; }
    ComponentDefinition Parent { get; }
    Box RangeBox { get; }
    Box RangeBoxInPointCloudSpace { get; }
    PointCloudRegions Regions { get; }
    double Scale { get; set; }
    PointCloudScans Scans { get; }
    string SourceFullFileName { get; }
    int TotalPointCount { get; }
    Matrix Transform { get; set; }
    ObjectTypeEnum Type { get; }
    double UnitsFactor { get; }
    bool Visible { get; set; }
    // Methods
    void Delete(bool RetainDependents = false);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    Point ModelToPointCloudSpace(Point ModelCoordinate);
    Point PointCloudToModelSpace(Point PointCloudCoordinate);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [PointCloud](../objects/PointCloud.md), [PointCloudCrops](../objects/PointCloudCrops.md), [PointCloudRegions](../objects/PointCloudRegions.md), [PointCloudScans](../objects/PointCloudScans.md)

