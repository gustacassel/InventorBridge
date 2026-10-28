# PresentationMeshFeature

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].TopSceneComponent.MeshFeatureSets.Item[…].Item[…]`

```csharp
interface PresentationMeshFeature
{
    // Properties
    Asset Appearance { get; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; }
    object Application { get; }
    PresentationMeshFeatureEntitiesEnumerator Entities { get; }
    string Name { get; }
    PresentationMeshFeatureSet Parent { get; }
    bool Suppressed { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; }
}
```

**Returned by:** [PresentationMeshFeatureEntity](../objects/PresentationMeshFeatureEntity.md).Parent, [PresentationMeshFeatureSet](../objects/PresentationMeshFeatureSet.md).Item

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationMeshFeatureEntitiesEnumerator](../objects/PresentationMeshFeatureEntitiesEnumerator.md), [PresentationMeshFeatureSet](../objects/PresentationMeshFeatureSet.md)

