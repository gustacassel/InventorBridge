# FloatAssetValue

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [AssetValue](../objects/AssetValue.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.FavoriteAssets.Item[…].Item[…] → (FloatAssetValue)`

```csharp
interface FloatAssetValue
{
    // Properties
    object Application { get; }
    AssetTexture ConnectedTexture { get; }
    string DisplayName { get; }
    bool HasConnectedTexture { get; set; }
    bool HasLimits { get; }
    bool HasMultipleValues { get; }
    bool IsPercentage { get; }
    bool IsReadOnly { get; }
    string Name { get; }
    Asset Parent { get; }
    ObjectTypeEnum Type { get; }
    string Units { get; }
    double Value { get; set; }
    AssetValueTypeEnum ValueType { get; }
    double[] Values { get; set; }
    // Methods
    void GetLimits(out bool HasLowLimit, out double LowLimit, out bool HasHighLimit, out double HighLimit);
}
```

**Referenced types:** [Asset](../objects/Asset.md), [AssetTexture](../objects/AssetTexture.md), [AssetValueTypeEnum](../enums/AssetValueTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

