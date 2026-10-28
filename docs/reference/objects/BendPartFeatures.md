# BendPartFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.BendPartFeatures`

```csharp
interface BendPartFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    BendPartFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BendPartFeature Add(SketchLine BendLine, BendPartTypeEnum BendPartType, object InputOne, object InputTwo, PartFeatureExtentDirectionEnum BendSide, bool BendInSketchNormalDirection, object Body = Missing, bool BendMinimum = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).BendPartFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).BendPartFeatures

**Referenced types:** [BendPartFeature](../objects/BendPartFeature.md), [BendPartTypeEnum](../enums/BendPartTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [SketchLine](../objects/SketchLine.md)

