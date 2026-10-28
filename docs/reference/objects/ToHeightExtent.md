# ToHeightExtent

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [PartFeatureExtent](../objects/PartFeatureExtent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CoilFeatures.Item[…].Extent → (ToHeightExtent)`

```csharp
interface ToHeightExtent
{
    // Properties
    object Application { get; }
    Parameter Offset { get; }
    PartFeature Parent { get; }
    object ToEntity { get; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [PartFeature](../objects/PartFeature.md)

