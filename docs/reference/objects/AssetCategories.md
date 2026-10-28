# AssetCategories

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.AssetLibraries.Item[…].AppearanceAssetCategories`

```csharp
interface AssetCategories
{
    // Properties
    object Application { get; }
    int Count { get; }
    AssetCategory Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    AssetCategory Add(string DisplayName, Asset Asset);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssetLibrary](../objects/AssetLibrary.md).AppearanceAssetCategories, [AssetLibrary](../objects/AssetLibrary.md).MaterialAssetCategories

**Referenced types:** [Asset](../objects/Asset.md), [AssetCategory](../objects/AssetCategory.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

