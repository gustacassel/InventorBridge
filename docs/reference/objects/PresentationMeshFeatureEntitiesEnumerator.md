# PresentationMeshFeatureEntitiesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].TopSceneComponent.MeshFeatureSets.Item[…].Item[…].Entities`

```csharp
interface PresentationMeshFeatureEntitiesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    PresentationMeshFeatureEntity Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PresentationMeshFeature](../objects/PresentationMeshFeature.md).Entities

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationMeshFeatureEntity](../objects/PresentationMeshFeatureEntity.md)

