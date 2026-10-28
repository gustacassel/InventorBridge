# PointClouds

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.PointClouds`

```csharp
interface PointClouds
{
    // Properties
    object Application { get; }
    int Count { get; }
    PointCloud Item[object Index] { get; }
    ComponentDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    PointCloud Add(string PointCloudFilename, object Transform = Missing, object Scale = Missing, object Options = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).PointClouds, [PartComponentDefinition](../objects/PartComponentDefinition.md).PointClouds, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).PointClouds, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).PointClouds

**Referenced types:** [ComponentDefinition](../objects/ComponentDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PointCloud](../objects/PointCloud.md)

