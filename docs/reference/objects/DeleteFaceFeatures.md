# DeleteFaceFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.DeleteFaceFeatures`

```csharp
interface DeleteFaceFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    DeleteFaceFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DeleteFaceFeature Add(object FacesToDelete, bool Heal = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).DeleteFaceFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).DeleteFaceFeatures

**Referenced types:** [DeleteFaceFeature](../objects/DeleteFaceFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

