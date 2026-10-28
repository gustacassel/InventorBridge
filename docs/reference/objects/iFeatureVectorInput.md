# iFeatureVectorInput

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [iFeatureInput](../objects/iFeatureInput.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.iFeatures.Item[…].iFeatureDefinition.iFeatureInputs.Item[…] → (iFeatureVectorInput)`

```csharp
interface iFeatureVectorInput
{
    // Properties
    object Application { get; }
    iFeatureEntityInputTypeEnum EntityType { get; }
    bool FlipOption { get; set; }
    object LineInput { get; set; }
    string Name { get; }
    string Prompt { get; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iFeatureEntityInputTypeEnum](../enums/iFeatureEntityInputTypeEnum.md)

