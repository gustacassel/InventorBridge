# PunchToolFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).PunchToolFeatures`

```csharp
interface PunchToolFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    PunchToolFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    PunchToolFeature Add(ObjectCollection PunchCenterPoints, iFeatureDefinition Definition, object Angle = Missing, bool AcrossBends = false);
    iFeatureDefinition CreateiFeatureDefinition(string FullFileName);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPatternFeatures](../objects/FlatPatternFeatures.md).PunchToolFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).PunchToolFeatures

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PunchToolFeature](../objects/PunchToolFeature.md), [iFeatureDefinition](../objects/iFeatureDefinition.md)

