# FeatureDimensionProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface FeatureDimensionProxy
{
    // Properties
    ObjectCollection AnchorPoints { get; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    FeatureDimensionTypeEnum DimensionType { get; }
    FeatureDimension NativeObject { get; }
    Parameter Parameter { get; }
    PartFeature Parent { get; }
    Point TextPoint { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [FeatureDimension](../objects/FeatureDimension.md), [FeatureDimensionTypeEnum](../enums/FeatureDimensionTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [PartFeature](../objects/PartFeature.md), [Point](../objects/Point.md)

