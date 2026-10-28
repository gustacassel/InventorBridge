# FeatureDimension

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…].FeatureDimensions.Item[…]`

```csharp
interface FeatureDimension
{
    // Properties
    ObjectCollection AnchorPoints { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    FeatureDimensionTypeEnum DimensionType { get; }
    Parameter Parameter { get; }
    PartFeature Parent { get; }
    Point TextPoint { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [FeatureDimensionProxy](../objects/FeatureDimensionProxy.md).NativeObject, [FeatureDimensions](../objects/FeatureDimensions.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [FeatureDimensionTypeEnum](../enums/FeatureDimensionTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [PartFeature](../objects/PartFeature.md), [Point](../objects/Point.md)

