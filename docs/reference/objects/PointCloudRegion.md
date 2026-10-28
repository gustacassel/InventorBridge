# PointCloudRegion

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.PointClouds.Item[…].Regions.Item[…]`

```csharp
interface PointCloudRegion
{
    // Properties
    object Application { get; }
    Color Color { get; }
    string DisplayName { get; }
    string InternalName { get; }
    PointCloud Parent { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
}
```

**Returned by:** [PointCloudRegions](../objects/PointCloudRegions.md).Item

**Referenced types:** [Color](../objects/Color.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PointCloud](../objects/PointCloud.md)

