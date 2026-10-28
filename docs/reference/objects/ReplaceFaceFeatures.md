# ReplaceFaceFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ReplaceFaceFeatures`

```csharp
interface ReplaceFaceFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    ReplaceFaceFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ReplaceFaceFeature Add(ReplaceFaceDefinition Definition);
    ReplaceFaceDefinition CreateDefinition(FaceCollection ExistingFaces, ObjectCollection NewFaces);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).ReplaceFaceFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).ReplaceFaceFeatures

**Referenced types:** [FaceCollection](../objects/FaceCollection.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReplaceFaceDefinition](../objects/ReplaceFaceDefinition.md), [ReplaceFaceFeature](../objects/ReplaceFaceFeature.md)

