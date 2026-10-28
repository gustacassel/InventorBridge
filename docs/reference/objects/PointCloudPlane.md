# PointCloudPlane

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PointCloudPlane
{
    // Properties
    object Application { get; }
    Plane Geometry { get; }
    PointCloud Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetPlaneRectangle(out Plane Plane, out UnitVector LengthDirection, out double Length, out double Height);
}
```

**Returned by:** [PointCloudPlaneProxy](../objects/PointCloudPlaneProxy.md).NativeObject

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Plane](../objects/Plane.md), [PointCloud](../objects/PointCloud.md), [UnitVector](../objects/UnitVector.md)

