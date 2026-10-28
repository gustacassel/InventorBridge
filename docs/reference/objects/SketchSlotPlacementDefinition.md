# SketchSlotPlacementDefinition

Inventor API object · versions: 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SlotFeatures.CreateSketchPlacementDefinition(…)`

```csharp
interface SketchSlotPlacementDefinition
{
    // Properties
    object Application { get; } // since 2027
    bool IsRotationFlipped { get; set; } // since 2027
    object Rotation { get; set; } // since 2027
    ObjectCollection SlotCenterPoints { get; set; } // since 2027
    object SlotDirectionEntity { get; set; } // since 2027
    DirectionTypeEnum SlotDirectionType { get; } // since 2027
    ObjectTypeEnum Type { get; } // since 2027
    // Methods
    void SetSlotDirectionType(DirectionTypeEnum DirectionType, object SlotDirectionEntity = Missing); // since 2027
}
```

**Returned by:** [SlotFeatures](../objects/SlotFeatures.md).CreateSketchPlacementDefinition

**Referenced types:** [DirectionTypeEnum](../enums/DirectionTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

