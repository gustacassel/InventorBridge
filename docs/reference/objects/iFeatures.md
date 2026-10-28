# iFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.iFeatures`

```csharp
interface iFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    iFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    iFeature Add(iFeatureDefinition Definition);
    iFeatureDefinition CreateiFeatureDefinition(string FullFileName);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPatternFeatures](../objects/FlatPatternFeatures.md).iFeatures, [PartFeatures](../objects/PartFeatures.md).iFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).iFeatures

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iFeature](../objects/iFeature.md), [iFeatureDefinition](../objects/iFeatureDefinition.md)

