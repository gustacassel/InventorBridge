# AssetsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.FavoriteAssets`

```csharp
interface AssetsEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    Asset Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).FavoriteAssets, [AssemblyDocument](../objects/AssemblyDocument.md).AppearanceAssets, [AssemblyDocument](../objects/AssemblyDocument.md).MaterialAssets, [AssemblyDocument](../objects/AssemblyDocument.md).PhysicalAssets, [AssetCategory](../objects/AssetCategory.md).Assets, [AssetLibrary](../objects/AssetLibrary.md).AppearanceAssets, [AssetLibrary](../objects/AssetLibrary.md).MaterialAssets, [AssetLibrary](../objects/AssetLibrary.md).PhysicalAssets, [InventorServer](../objects/InventorServer.md).FavoriteAssets, [PartDocument](../objects/PartDocument.md).AppearanceAssets, [PartDocument](../objects/PartDocument.md).MaterialAssets, [PartDocument](../objects/PartDocument.md).PhysicalAssets, [PresentationDocument](../objects/PresentationDocument.md).AppearanceAssets

**Referenced types:** [Asset](../objects/Asset.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

