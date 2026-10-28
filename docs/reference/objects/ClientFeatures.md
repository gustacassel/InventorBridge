# ClientFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ClientFeatures`

```csharp
interface ClientFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    ClientFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ClientFeature Add(ClientFeatureDefinition Definition, string ClientId);
    ClientFeatureDefinition CreateDefinition(string FeatureType = "", object StartElement = Missing, object EndElement = Missing, object FeatureInputs = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Features](../objects/Features.md).ClientFeatures, [FlatPatternFeatures](../objects/FlatPatternFeatures.md).ClientFeatures, [PartFeatures](../objects/PartFeatures.md).ClientFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).ClientFeatures

**Referenced types:** [ClientFeature](../objects/ClientFeature.md), [ClientFeatureDefinition](../objects/ClientFeatureDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

