# FaceDraftFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.FaceDraftFeatures`

```csharp
interface FaceDraftFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    FaceDraftFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    FaceDraftFeature Add(FaceDraftDefinition FaceDraftDefinition);
    FaceDraftDefinition CreateFaceDraftDefinition();
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).FaceDraftFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).FaceDraftFeatures

**Referenced types:** [FaceDraftDefinition](../objects/FaceDraftDefinition.md), [FaceDraftFeature](../objects/FaceDraftFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

