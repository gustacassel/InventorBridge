# SculptFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SculptFeatures`

```csharp
interface SculptFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    SculptFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SculptFeature Add(ObjectCollection Surfaces, PartFeatureOperationEnum Operation, object AffectedBody = Missing);
    SculptSurface CreateSculptSurface(object Surface, PartFeatureExtentDirectionEnum Direction = PartFeatureExtentDirectionEnum.kPositiveExtentDirection);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).SculptFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).SculptFeatures

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [SculptFeature](../objects/SculptFeature.md), [SculptSurface](../objects/SculptSurface.md)

