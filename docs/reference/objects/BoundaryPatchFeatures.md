# BoundaryPatchFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.BoundaryPatchFeatures`

```csharp
interface BoundaryPatchFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    BoundaryPatchFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BoundaryPatchFeature Add(BoundaryPatchDefinition Definition);
    BoundaryPatchDefinition CreateBoundaryPatchDefinition();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).BoundaryPatchFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).BoundaryPatchFeatures

**Referenced types:** [BoundaryPatchDefinition](../objects/BoundaryPatchDefinition.md), [BoundaryPatchFeature](../objects/BoundaryPatchFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

