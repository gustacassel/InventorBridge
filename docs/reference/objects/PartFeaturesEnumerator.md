# PartFeaturesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].AffectedByFeatures`

```csharp
interface PartFeaturesEnumerator
{
    // Properties
    int Count { get; }
    PartFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SurfaceBody](../objects/SurfaceBody.md).AffectedByFeatures, [SurfaceBodyProxy](../objects/SurfaceBodyProxy.md).AffectedByFeatures

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md)

