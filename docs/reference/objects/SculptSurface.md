# SculptSurface

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SculptFeatures.CreateSculptSurface(…)`

```csharp
interface SculptSurface
{
    // Properties
    PartFeatureExtentDirectionEnum Direction { get; set; }
    object Surface { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [SculptFeatures](../objects/SculptFeatures.md).CreateSculptSurface

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md)

