# NonParametricBaseFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.NonParametricBaseFeatures`

```csharp
interface NonParametricBaseFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    NonParametricBaseFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    NonParametricBaseFeature Add(SurfaceBody SurfaceBody, object Transform = Missing);
    NonParametricBaseFeature AddByDefinition(NonParametricBaseFeatureDefinition Definition);
    NonParametricBaseFeatureDefinition CreateDefinition();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).NonParametricBaseFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).NonParametricBaseFeatures

**Referenced types:** [NonParametricBaseFeature](../objects/NonParametricBaseFeature.md), [NonParametricBaseFeatureDefinition](../objects/NonParametricBaseFeatureDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SurfaceBody](../objects/SurfaceBody.md)

