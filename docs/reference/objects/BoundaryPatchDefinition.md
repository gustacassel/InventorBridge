# BoundaryPatchDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.BoundaryPatchFeatures.Item[…].Definition`

```csharp
interface BoundaryPatchDefinition
{
    // Properties
    object Application { get; }
    BoundaryPatchLoops BoundaryPatchLoops { get; }
    ObjectCollection GuideRails { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [BoundaryPatchFeature](../objects/BoundaryPatchFeature.md).Definition, [BoundaryPatchFeatureProxy](../objects/BoundaryPatchFeatureProxy.md).Definition, [BoundaryPatchFeatures](../objects/BoundaryPatchFeatures.md).CreateBoundaryPatchDefinition

**Referenced types:** [BoundaryPatchLoops](../objects/BoundaryPatchLoops.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

