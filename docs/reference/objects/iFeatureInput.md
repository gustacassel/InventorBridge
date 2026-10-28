# iFeatureInput

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.iFeatures.Item[…].iFeatureDefinition.iFeatureInputs.Item[…]`

```csharp
interface iFeatureInput
{
    // Properties
    object Application { get; }
    iFeatureEntityInputTypeEnum EntityType { get; }
    string Name { get; }
    string Prompt { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [iFeatureInputs](../objects/iFeatureInputs.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iFeatureEntityInputTypeEnum](../enums/iFeatureEntityInputTypeEnum.md)

