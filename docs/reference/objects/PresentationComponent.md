# PresentationComponent

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].TopSceneComponent`

```csharp
interface PresentationComponent
{
    // Properties
    Asset Appearance { get; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; }
    object Application { get; }
    bool IsLeaf { get; }
    PresentationMeshFeatureSetsEnumerator MeshFeatureSets { get; }
    string Name { get; }
    double Opacity { get; }
    PresentationScene Parent { get; }
    PresentationComponent ParentComponent { get; }
    PresentationComponentsEnumerator SubComponents { get; }
    PresentationBodiesEnumerator SurfaceBodies { get; }
    Matrix Transformation { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; }
}
```

**Returned by:** [PresentationBody](../objects/PresentationBody.md).Parent, [PresentationComponent](../objects/PresentationComponent.md).ParentComponent, [PresentationComponentsEnumerator](../objects/PresentationComponentsEnumerator.md).Item, [PresentationMeshFeatureSet](../objects/PresentationMeshFeatureSet.md).Parent, [PresentationScene](../objects/PresentationScene.md).TopSceneComponent, [PresentationTrail](../objects/PresentationTrail.md).PresentationComponent

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationBodiesEnumerator](../objects/PresentationBodiesEnumerator.md), [PresentationComponentsEnumerator](../objects/PresentationComponentsEnumerator.md), [PresentationMeshFeatureSetsEnumerator](../objects/PresentationMeshFeatureSetsEnumerator.md), [PresentationScene](../objects/PresentationScene.md)

