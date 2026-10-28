# TextureAssetValue

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [AssetValue](../objects/AssetValue.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.FavoriteAssets.Item[…].Item[…] → (TextureAssetValue)`

```csharp
interface TextureAssetValue
{
    // Properties
    object Application { get; }
    string DisplayName { get; }
    bool IsReadOnly { get; }
    string Name { get; }
    Asset Parent { get; }
    ObjectTypeEnum Type { get; }
    AssetTexture Value { get; }
    AssetValueTypeEnum ValueType { get; }
}
```

**Referenced types:** [Asset](../objects/Asset.md), [AssetTexture](../objects/AssetTexture.md), [AssetValueTypeEnum](../enums/AssetValueTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

