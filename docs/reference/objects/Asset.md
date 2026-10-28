# Asset

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.FavoriteAssets.Item[…]`

```csharp
interface Asset
{
    // Properties
    object Application { get; }
    AssetTypeEnum AssetType { get; }
    AssetCategory Category { get; set; }
    string CategoryName { get; }
    int Count { get; }
    string Description { get; set; } // since 2027
    string DisplayName { get; set; }
    bool HasTexture { get; }
    bool IsReadOnly { get; }
    bool IsUsed { get; }
    AssetValue Item[object Index] { get; }
    AssetLocalTypeEnum LocalType { get; }
    string Name { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Asset CopyTo(object Target, object ReplaceExisting = Missing);
    void Delete();
    Asset Duplicate(object NewDisplayName = Missing);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AliasFreeformFeature](../objects/AliasFreeformFeature.md).Appearance, [AliasFreeformFeatureProxy](../objects/AliasFreeformFeatureProxy.md).Appearance, [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).DefaultVirtualComponentMaterial, [Asset](../objects/Asset.md).CopyTo, [Asset](../objects/Asset.md).Duplicate, [AssetValue](../objects/AssetValue.md).Parent, [Assets](../objects/Assets.md).Add, [Assets](../objects/Assets.md).Item, [AssetsEnumerator](../objects/AssetsEnumerator.md).Item, [BendFeature](../objects/BendFeature.md).Appearance, [BendFeatureProxy](../objects/BendFeatureProxy.md).Appearance, [BendPartFeature](../objects/BendPartFeature.md).Appearance, [BendPartFeatureProxy](../objects/BendPartFeatureProxy.md).Appearance, [BooleanAssetValue](../objects/BooleanAssetValue.md).Parent, [BossFeature](../objects/BossFeature.md).Appearance, [BossFeatureProxy](../objects/BossFeatureProxy.md).Appearance, [BoundaryPatchFeature](../objects/BoundaryPatchFeature.md).Appearance, [BoundaryPatchFeatureProxy](../objects/BoundaryPatchFeatureProxy.md).Appearance, [ChamferFeature](../objects/ChamferFeature.md).Appearance, [ChamferFeatureProxy](../objects/ChamferFeatureProxy.md).Appearance, [ChoiceAssetValue](../objects/ChoiceAssetValue.md).Parent, [CircularPatternFeature](../objects/CircularPatternFeature.md).Appearance, [CircularPatternFeatureProxy](../objects/CircularPatternFeatureProxy.md).Appearance, [ClientFeature](../objects/ClientFeature.md).Appearance, [ClientFeatureProxy](../objects/ClientFeatureProxy.md).Appearance, [CoilFeature](../objects/CoilFeature.md).Appearance, [CoilFeatureProxy](../objects/CoilFeatureProxy.md).Appearance, [ColorAssetValue](../objects/ColorAssetValue.md).Parent, [CombineFeature](../objects/CombineFeature.md).Appearance, [CombineFeatureProxy](../objects/CombineFeatureProxy.md).Appearance, [ComponentOccurrence](../objects/ComponentOccurrence.md).Appearance, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).Appearance, [ContourFlangeFeature](../objects/ContourFlangeFeature.md).Appearance, [ContourFlangeFeatureProxy](../objects/ContourFlangeFeatureProxy.md).Appearance, [ContourRollFeature](../objects/ContourRollFeature.md).Appearance, [ContourRollFeatureProxy](../objects/ContourRollFeatureProxy.md).Appearance, [CornerChamferFeature](../objects/CornerChamferFeature.md).Appearance, [CornerChamferFeatureProxy](../objects/CornerChamferFeatureProxy.md).Appearance, [CornerFeature](../objects/CornerFeature.md).Appearance, [CornerFeatureProxy](../objects/CornerFeatureProxy.md).Appearance and 140 more (see `members.tsv`)

**Referenced types:** [AssetCategory](../objects/AssetCategory.md), [AssetLocalTypeEnum](../enums/AssetLocalTypeEnum.md), [AssetTypeEnum](../enums/AssetTypeEnum.md), [AssetValue](../objects/AssetValue.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

