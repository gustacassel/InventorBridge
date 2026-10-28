# PointCloudRegions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.PointClouds.Item[…].Regions`

```csharp
interface PointCloudRegions
{
    // Properties
    object Application { get; }
    int Count { get; }
    PointCloudRegion Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PointCloud](../objects/PointCloud.md).Regions, [PointCloudProxy](../objects/PointCloudProxy.md).Regions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PointCloudRegion](../objects/PointCloudRegion.md)

