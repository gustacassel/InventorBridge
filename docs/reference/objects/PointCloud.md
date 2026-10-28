# PointCloud

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.PointClouds.Item[…]`

```csharp
interface PointCloud
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    PointCloudCrops Crops { get; }
    int Density { get; set; }
    int DisplayedPointCount { get; }
    HealthStatusEnum HealthStatus { get; }
    int MaximumPointCount { get; set; }
    string Name { get; }
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

**Returned by:** [PointCloudCrop](../objects/PointCloudCrop.md).Parent, [PointCloudPlane](../objects/PointCloudPlane.md).Parent, [PointCloudPlaneProxy](../objects/PointCloudPlaneProxy.md).Parent, [PointCloudPoint](../objects/PointCloudPoint.md).Parent, [PointCloudPointProxy](../objects/PointCloudPointProxy.md).Parent, [PointCloudProxy](../objects/PointCloudProxy.md).NativeObject, [PointCloudRegion](../objects/PointCloudRegion.md).Parent, [PointCloudScan](../objects/PointCloudScan.md).Parent, [PointClouds](../objects/PointClouds.md).Add, [PointClouds](../objects/PointClouds.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComponentDefinition](../objects/ComponentDefinition.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [PointCloudCrops](../objects/PointCloudCrops.md), [PointCloudRegions](../objects/PointCloudRegions.md), [PointCloudScans](../objects/PointCloudScans.md)

