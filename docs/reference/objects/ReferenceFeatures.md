# ReferenceFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ReferenceFeatures`

```csharp
interface ReferenceFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    ReferenceFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).ReferenceFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).ReferenceFeatures

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceFeature](../objects/ReferenceFeature.md)

