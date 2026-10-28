# MeshFeatureEntitiesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.MeshFeatureSets.Item[…].Item[…].Entities`

```csharp
interface MeshFeatureEntitiesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    MeshFeatureEntity Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [MeshFeature](../objects/MeshFeature.md).Entities, [MeshFeatureProxy](../objects/MeshFeatureProxy.md).Entities

**Referenced types:** [MeshFeatureEntity](../objects/MeshFeatureEntity.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

