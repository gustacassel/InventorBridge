# PointCloudCrops

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.PointClouds.Item[…].Crops`

```csharp
interface PointCloudCrops
{
    // Properties
    object Application { get; }
    int Count { get; }
    PointCloudCrop Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    PointCloudCrop Add(OrientedBox BoundingBox, bool KeepInside = true);
    void Clear();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PointCloud](../objects/PointCloud.md).Crops, [PointCloudProxy](../objects/PointCloudProxy.md).Crops

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OrientedBox](../objects/OrientedBox.md), [PointCloudCrop](../objects/PointCloudCrop.md)

