# RuleFilletFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.RuleFilletFeatures`

```csharp
interface RuleFilletFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    RuleFilletFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).RuleFilletFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).RuleFilletFeatures

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RuleFilletFeature](../objects/RuleFilletFeature.md)

