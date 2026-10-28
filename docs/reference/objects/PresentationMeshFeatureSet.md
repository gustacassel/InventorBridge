# PresentationMeshFeatureSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].TopSceneComponent.MeshFeatureSets.Item[…]`

```csharp
interface PresentationMeshFeatureSet
{
    // Properties
    object Application { get; }
    int Count { get; }
    PresentationMeshFeature Item[int Index] { get; }
    string Name { get; }
    PresentationComponent Parent { get; }
    MeshFeaturesSuppressionEnum Suppressed { get; }
    ObjectTypeEnum Type { get; }
    MeshFeaturesVisibilityEnum Visible { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PresentationMeshFeature](../objects/PresentationMeshFeature.md).Parent, [PresentationMeshFeatureSetsEnumerator](../objects/PresentationMeshFeatureSetsEnumerator.md).Item

**Referenced types:** [MeshFeaturesSuppressionEnum](../enums/MeshFeaturesSuppressionEnum.md), [MeshFeaturesVisibilityEnum](../enums/MeshFeaturesVisibilityEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationComponent](../objects/PresentationComponent.md), [PresentationMeshFeature](../objects/PresentationMeshFeature.md)

