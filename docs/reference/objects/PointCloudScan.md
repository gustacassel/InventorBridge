# PointCloudScan

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.PointClouds.Item[…].Scans.Item[…]`

```csharp
interface PointCloudScan
{
    // Properties
    object Application { get; }
    string DisplayName { get; }
    string InternalName { get; }
    Point Origin { get; }
    PointCloud Parent { get; }
    string SourceFullFileName { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
}
```

**Returned by:** [PointCloudScans](../objects/PointCloudScans.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [PointCloud](../objects/PointCloud.md)

