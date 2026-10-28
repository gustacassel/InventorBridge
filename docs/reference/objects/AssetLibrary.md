# AssetLibrary

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.AssetLibraries.Item[…]`

```csharp
interface AssetLibrary
{
    // Properties
    AssetCategories AppearanceAssetCategories { get; }
    AssetsEnumerator AppearanceAssets { get; }
    object Application { get; }
    string DisplayName { get; set; }
    string FullFileName { get; }
    string InternalName { get; }
    bool IsReadOnly { get; }
    AssetCategories MaterialAssetCategories { get; }
    AssetsEnumerator MaterialAssets { get; }
    AssetsEnumerator PhysicalAssets { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Remove();
}
```

**Returned by:** [Application](../objects/Application.md).ActiveAppearanceLibrary, [Application](../objects/Application.md).ActiveMaterialLibrary, [AssetCategory](../objects/AssetCategory.md).Parent, [AssetLibraries](../objects/AssetLibraries.md).Add, [AssetLibraries](../objects/AssetLibraries.md).Item, [AssetLibraries](../objects/AssetLibraries.md).Open, [InventorServer](../objects/InventorServer.md).ActiveAppearanceLibrary, [InventorServer](../objects/InventorServer.md).ActiveMaterialLibrary

**Referenced types:** [AssetCategories](../objects/AssetCategories.md), [AssetsEnumerator](../objects/AssetsEnumerator.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

