# PointCloudPlaneProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PointCloudPlaneProxy
{
    // Properties
    object Application { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    Plane Geometry { get; }
    PointCloudPlane NativeObject { get; }
    PointCloud Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetPlaneRectangle(out Plane Plane, out UnitVector LengthDirection, out double Length, out double Height);
}
```

**Referenced types:** [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Plane](../objects/Plane.md), [PointCloud](../objects/PointCloud.md), [PointCloudPlane](../objects/PointCloudPlane.md), [UnitVector](../objects/UnitVector.md)

