# AssetValue

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.FavoriteAssets.Item[…].Item[…]`

```csharp
interface AssetValue
{
    // Properties
    object Application { get; }
    string DisplayName { get; }
    bool IsReadOnly { get; }
    string Name { get; }
    Asset Parent { get; }
    ObjectTypeEnum Type { get; }
    AssetValueTypeEnum ValueType { get; }
}
```

**Returned by:** [Asset](../objects/Asset.md).Item, [AssetTexture](../objects/AssetTexture.md).Item, [MaterialAsset](../objects/MaterialAsset.md).Item

**Referenced types:** [Asset](../objects/Asset.md), [AssetValueTypeEnum](../enums/AssetValueTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

