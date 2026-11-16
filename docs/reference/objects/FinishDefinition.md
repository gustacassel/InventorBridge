# FinishDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.FinishFeatures.Item[…].Definition`

```csharp
interface FinishDefinition
{
    // Properties
    Asset Appearance { get; set; }
    object Application { get; }
    string Comment { get; set; }
    string Depth { get; set; }
    string Description { get; set; }
    ObjectCollection ExcludedEntities { get; set; } // since 2025
    FinishTypeEnum FinishType { get; set; }
    object Hardness { get; set; }
    ObjectCollection IncludedEntities { get; set; } // since 2025
    FaceCollection InputFaces { get; set; } // hidden in 2025, 2026, 2027: there, prefer the newer members
    FinishFeature Parent { get; }
    string ProcessName { get; set; }
    string ShortDescription { get; set; }
    object Thickness { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    FinishDefinition Copy();
    void DisableProperties(ref string[] PropertyNames, bool Disabled); // since 2025
    bool IsPropertyDisabled(string PropertyName); // since 2025
}
```

**Returned by:** [FinishDefinition](../objects/FinishDefinition.md).Copy, [FinishFeature](../objects/FinishFeature.md).Definition, [FinishFeatureProxy](../objects/FinishFeatureProxy.md).Definition, [FinishFeatures](../objects/FinishFeatures.md).CreateDefinition, [FinishFeatures](../objects/FinishFeatures.md).CreateFinishDefinition

**Referenced types:** [Asset](../objects/Asset.md), [FaceCollection](../objects/FaceCollection.md), [FinishFeature](../objects/FinishFeature.md), [FinishTypeEnum](../enums/FinishTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

