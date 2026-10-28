# FilenameAssetValue

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [AssetValue](../objects/AssetValue.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.FavoriteAssets.Item[…].Item[…] → (FilenameAssetValue)`

```csharp
interface FilenameAssetValue
{
    // Properties
    object Application { get; }
    string DisplayName { get; }
    bool HasMultipleValues { get; }
    bool IsReadOnly { get; }
    string Name { get; }
    Asset Parent { get; }
    ObjectTypeEnum Type { get; }
    string Value { get; set; }
    AssetValueTypeEnum ValueType { get; }
    string[] Values { get; set; }
}
```

**Referenced types:** [Asset](../objects/Asset.md), [AssetValueTypeEnum](../enums/AssetValueTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

