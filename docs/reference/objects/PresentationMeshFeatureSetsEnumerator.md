# PresentationMeshFeatureSetsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].TopSceneComponent.MeshFeatureSets`

```csharp
interface PresentationMeshFeatureSetsEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    PresentationMeshFeatureSet Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PresentationComponent](../objects/PresentationComponent.md).MeshFeatureSets

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationMeshFeatureSet](../objects/PresentationMeshFeatureSet.md)

