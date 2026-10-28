# MaterialAsset

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Asset](../objects/Asset.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.FavoriteAssets.Item[…] → (MaterialAsset)`

```csharp
interface MaterialAsset
{
    // Properties
    Asset AppearanceAsset { get; set; }
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
    Asset PhysicalPropertiesAsset { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    Asset CopyTo(object Target, object ReplaceExisting = Missing);
    void Delete();
    Asset Duplicate(object NewDisplayName = Missing);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [Asset](../objects/Asset.md), [AssetCategory](../objects/AssetCategory.md), [AssetLocalTypeEnum](../enums/AssetLocalTypeEnum.md), [AssetTypeEnum](../enums/AssetTypeEnum.md), [AssetValue](../objects/AssetValue.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

