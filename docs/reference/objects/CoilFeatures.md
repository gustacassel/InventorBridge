# CoilFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.CoilFeatures`

```csharp
interface CoilFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    CoilFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CoilFeature AddByPitchAndHeight(Profile Profile, object AxisEntity, object Pitch, object Height, PartFeatureOperationEnum Operation, bool AxisDirectionReversed = false, bool ClockwiseRotation = false, object TaperAngle = 0, bool FlatStartType = false, object StartTransitionAngle = Missing, object StartFlatAngle = Missing, bool FlatEndType = false, object EndTransitionAngle = Missing, object EndFlatAngle = Missing);
    CoilFeature AddByPitchAndRevolution(Profile Profile, object AxisEntity, object Pitch, object Revolution, PartFeatureOperationEnum Operation, bool AxisDirectionReversed = false, bool ClockwiseRotation = false, object TaperAngle = 0, bool FlatStartType = false, object StartTransitionAngle = Missing, object StartFlatAngle = Missing, bool FlatEndType = false, object EndTransitionAngle = Missing, object EndFlatAngle = Missing);
    CoilFeature AddByRevolutionAndHeight(Profile Profile, object AxisEntity, object Revolution, object Height, PartFeatureOperationEnum Operation, bool AxisDirectionReversed = false, bool ClockwiseRotation = false, object TaperAngle = 0, bool FlatStartType = false, object StartTransitionAngle = Missing, object StartFlatAngle = Missing, bool FlatEndType = false, object EndTransitionAngle = Missing, object EndFlatAngle = Missing);
    CoilFeature AddSpiral(Profile Profile, object AxisEntity, object Pitch, object Revolution, PartFeatureOperationEnum Operation, bool AxisDirectionReversed = false, bool ClockwiseRotation = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).CoilFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).CoilFeatures

**Referenced types:** [CoilFeature](../objects/CoilFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [Profile](../objects/Profile.md)

