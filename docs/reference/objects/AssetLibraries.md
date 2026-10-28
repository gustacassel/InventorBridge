# AssetLibraries

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.AssetLibraries`

```csharp
interface AssetLibraries
{
    // Properties
    object Application { get; }
    int Count { get; }
    AssetLibrary Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    AssetLibrary Add(string FullFileName);
    void MigrateInventorStyle(string InventorLibraryPath, bool ImportMaterialStyles, string TargetLibrary);
    AssetLibrary Open(string FullFileName);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).AssetLibraries, [InventorServer](../objects/InventorServer.md).AssetLibraries

**Referenced types:** [AssetLibrary](../objects/AssetLibrary.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

