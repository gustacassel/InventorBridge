# LoftFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.LoftFeatures`

```csharp
interface LoftFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    LoftFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    LoftFeature Add(LoftDefinition Definition);
    LoftDefinition CreateLoftDefinition(ObjectCollection Sections, PartFeatureOperationEnum Operation);
    MapPointCurves CreateMapCurves(ObjectCollection Sections);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).LoftFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).LoftFeatures

**Referenced types:** [LoftDefinition](../objects/LoftDefinition.md), [LoftFeature](../objects/LoftFeature.md), [MapPointCurves](../objects/MapPointCurves.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md)

