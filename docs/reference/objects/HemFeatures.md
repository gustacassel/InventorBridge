# HemFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).HemFeatures`

```csharp
interface HemFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    HemFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    HemFeature Add(HemDefinition HemDefinition);
    HemDefinition CreateHemDefinition(EdgeCollection Edges);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SheetMetalFeatures](../objects/SheetMetalFeatures.md).HemFeatures

**Referenced types:** [EdgeCollection](../objects/EdgeCollection.md), [HemDefinition](../objects/HemDefinition.md), [HemFeature](../objects/HemFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

