# HoleClearanceInfo

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.HoleFeatures.Item[…].ClearanceInfo`

```csharp
interface HoleClearanceInfo
{
    // Properties
    object Application { get; }
    FastenerFitType FastenerFitType { get; set; }
    string FastenerSize { get; set; }
    string FastenerStandard { get; set; }
    string FastenerType { get; set; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void SetClearanceInfo(string FastenerStandard, string FastenerType, string FastenerSize, object FastenerFitType = Missing);
}
```

**Returned by:** [HoleFeature](../objects/HoleFeature.md).ClearanceInfo, [HoleFeatureProxy](../objects/HoleFeatureProxy.md).ClearanceInfo, [HoleFeatures](../objects/HoleFeatures.md).CreateClearanceInfo, [ModelHoleThreadNotes](../objects/ModelHoleThreadNotes.md).CreateClearanceInfo, [SlotDefinition](../objects/SlotDefinition.md).ClearanceInfo, [SlotFeatures](../objects/SlotFeatures.md).CreateClearanceInfo

**Referenced types:** [FastenerFitType](../enums/FastenerFitType.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

