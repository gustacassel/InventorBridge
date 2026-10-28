# ColorAssetValue

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [AssetValue](../objects/AssetValue.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.FavoriteAssets.Item[…].Item[…] → (ColorAssetValue)`

```csharp
interface ColorAssetValue
{
    // Properties
    object Application { get; }
    AssetTexture ConnectedTexture { get; }
    string DisplayName { get; }
    bool HasConnectedTexture { get; set; }
    bool HasMultipleValues { get; }
    bool IsReadOnly { get; }
    string Name { get; }
    Asset Parent { get; }
    ObjectTypeEnum Type { get; }
    Color Value { get; set; }
    AssetValueTypeEnum ValueType { get; }
    Color[] Values { get; set; }
}
```

**Referenced types:** [Asset](../objects/Asset.md), [AssetTexture](../objects/AssetTexture.md), [AssetValueTypeEnum](../enums/AssetValueTypeEnum.md), [Color](../objects/Color.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

