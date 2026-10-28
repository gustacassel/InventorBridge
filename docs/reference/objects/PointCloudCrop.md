# PointCloudCrop

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.PointClouds.Item[…].Crops.Item[…]`

```csharp
interface PointCloudCrop
{
    // Properties
    object Application { get; }
    OrientedBox BoundingBox { get; }
    bool KeepInside { get; }
    PointCloud Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [PointCloudCrops](../objects/PointCloudCrops.md).Add, [PointCloudCrops](../objects/PointCloudCrops.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OrientedBox](../objects/OrientedBox.md), [PointCloud](../objects/PointCloud.md)

