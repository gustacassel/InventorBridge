# AssetTexture

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.FavoriteAssets.Item[…].Item[…] → (FloatAssetValue).ConnectedTexture`

```csharp
interface AssetTexture
{
    // Properties
    object Application { get; }
    int Count { get; }
    AssetValue Item[object Index] { get; }
    AssetTextureTypeEnum TextureType { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void ChangeTextureType(AssetTextureTypeEnum TextureType, object ImageFileName = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ColorAssetValue](../objects/ColorAssetValue.md).ConnectedTexture, [FloatAssetValue](../objects/FloatAssetValue.md).ConnectedTexture, [TextureAssetValue](../objects/TextureAssetValue.md).Value

**Referenced types:** [AssetTextureTypeEnum](../enums/AssetTextureTypeEnum.md), [AssetValue](../objects/AssetValue.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

