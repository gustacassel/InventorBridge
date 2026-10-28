# AssetCategory

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.FavoriteAssets.Item[…].Category`

```csharp
interface AssetCategory
{
    // Properties
    object Application { get; }
    AssetsEnumerator Assets { get; }
    string DisplayName { get; set; }
    AssetLibrary Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddAsset(Asset Asset);
    void Delete();
}
```

**Returned by:** [Asset](../objects/Asset.md).Category, [AssetCategories](../objects/AssetCategories.md).Add, [AssetCategories](../objects/AssetCategories.md).Item, [MaterialAsset](../objects/MaterialAsset.md).Category

**Referenced types:** [Asset](../objects/Asset.md), [AssetLibrary](../objects/AssetLibrary.md), [AssetsEnumerator](../objects/AssetsEnumerator.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

