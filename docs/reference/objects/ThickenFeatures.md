# ThickenFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ThickenFeatures`

```csharp
interface ThickenFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    ThickenFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ThickenFeature Add(object Faces, object Distance, PartFeatureExtentDirectionEnum ExtentDirection, PartFeatureOperationEnum Operation, bool AutomaticFaceChain = false, bool CreateVerticalSurfaces = false, bool AutomaticBlending = false);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).ThickenFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).ThickenFeatures

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [ThickenFeature](../objects/ThickenFeature.md)

