# SimplifyFeatures

Inventor API object · versions: 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SimplifyFeatures`

```csharp
interface SimplifyFeatures
{
    // Properties
    object Application { get; } // since 2026
    int Count { get; } // since 2026
    SimplifyFeature Item[object Index] { get; } // since 2026
    ObjectTypeEnum Type { get; } // since 2026
    // Methods
    SimplifyFeature Add(SimplifyDefinition pDefinition); // since 2026
    SimplifyDefinition CreateDefinition(); // since 2026
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).SimplifyFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).SimplifyFeatures

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SimplifyDefinition](../objects/SimplifyDefinition.md), [SimplifyFeature](../objects/SimplifyFeature.md)

