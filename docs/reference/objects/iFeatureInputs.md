# iFeatureInputs

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.iFeatures.Item[…].iFeatureDefinition.iFeatureInputs`

```csharp
interface iFeatureInputs
{
    // Properties
    object Application { get; }
    int Count { get; }
    iFeatureInput Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [iFeatureDefinition](../objects/iFeatureDefinition.md).iFeatureInputs

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iFeatureInput](../objects/iFeatureInput.md)

