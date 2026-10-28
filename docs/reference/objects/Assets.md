# Assets

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).Assets`

```csharp
interface Assets
{
    // Properties
    object Application { get; }
    int Count { get; }
    Asset Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Asset Add(AssetTypeEnum AssetType, string LocalType, object Reserved = Missing, object DisplayName = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).Assets, [PartDocument](../objects/PartDocument.md).Assets

**Referenced types:** [Asset](../objects/Asset.md), [AssetTypeEnum](../enums/AssetTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

