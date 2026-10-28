# PitchAndHeightCoilExtent

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [PartFeatureExtent](../objects/PartFeatureExtent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CoilFeatures.Item[…].Extent → (PitchAndHeightCoilExtent)`

```csharp
interface PitchAndHeightCoilExtent
{
    // Properties
    object Application { get; }
    Parameter Height { get; }
    PartFeature Parent { get; }
    Parameter Pitch { get; }
    Parameter TaperAngle { get; }
    ObjectTypeEnum Type { get; }
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [PartFeature](../objects/PartFeature.md)

