# SimplifyDefinition

Inventor API object · versions: 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.SimplifyFeatures.Item[…].Definition`

```csharp
interface SimplifyDefinition
{
    // Properties
    object Application { get; } // since 2026
    BoundingTypeEnum EnvelopeBoundingType { get; set; } // since 2026
    ObjectCollection EnvelopesReplaceBodies { get; set; } // since 2026
    EnvelopesReplaceStyleEnum EnvelopesReplaceStyle { get; set; } // since 2026
    SimplifyFeature Parent { get; } // since 2026
    ObjectCollection PreservedBodies { get; set; } // since 2026
    ObjectCollection PreservedFeatures { get; set; } // since 2026
    bool RemoveBodiesBySize { get; set; } // since 2026
    double RemoveBodiesSize { get; set; } // since 2026
    double RemoveChamfersMaxDistanceRange { get; set; } // since 2026
    SimplificationRemoveStyleEnum RemoveChamfersStyle { get; set; } // since 2026
    double RemoveEmbossMaxHeightRange { get; set; } // since 2026
    SimplificationRemoveStyleEnum RemoveEmbossesStyle { get; set; } // since 2026
    double RemoveFilletsMaxRadiusRange { get; set; } // since 2026
    SimplificationRemoveStyleEnum RemoveFilletsStyle { get; set; } // since 2026
    double RemoveHolesMaxDiameterRange { get; set; } // since 2026
    SimplificationRemoveStyleEnum RemoveHolesStyle { get; set; } // since 2026
    bool RemoveInternalBodies { get; set; } // since 2026
    bool RemoveInternalVoids { get; set; } // since 2026
    double RemovePocketsMaxDepthRange { get; set; } // since 2026
    SimplificationRemoveStyleEnum RemovePocketsStyle { get; set; } // since 2026
    SimplificationRemoveStyleEnum RemoveTunnelsStyle { get; set; } // since 2026
    ObjectCollection RemovedBodies { get; set; } // since 2026
    ObjectTypeEnum Type { get; } // since 2026
    // Methods
    SimplifyDefinition Copy(); // since 2026
}
```

**Returned by:** [SimplifyDefinition](../objects/SimplifyDefinition.md).Copy, [SimplifyFeature](../objects/SimplifyFeature.md).Definition, [SimplifyFeatureProxy](../objects/SimplifyFeatureProxy.md).Definition, [SimplifyFeatures](../objects/SimplifyFeatures.md).CreateDefinition

**Referenced types:** [BoundingTypeEnum](../enums/BoundingTypeEnum.md), [EnvelopesReplaceStyleEnum](../enums/EnvelopesReplaceStyleEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SimplificationRemoveStyleEnum](../enums/SimplificationRemoveStyleEnum.md), [SimplifyFeature](../objects/SimplifyFeature.md)

