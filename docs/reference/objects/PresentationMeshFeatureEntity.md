# PresentationMeshFeatureEntity

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].TopSceneComponent.MeshFeatureSets.Item[…].Item[…].Entities.Item[…]`

```csharp
interface PresentationMeshFeatureEntity
{
    // Properties
    object Application { get; }
    ColorBindingEnum ColorBinding { get; }
    GraphicsIndexSet ColorIndexSet { get; }
    GraphicsColorSet ColorSet { get; }
    GraphicsIndexSet CoordinateIndexSet { get; }
    GraphicsCoordinateSet CoordinateSet { get; }
    NormalBindingEnum NormalBinding { get; }
    GraphicsIndexSet NormalIndexSet { get; }
    GraphicsNormalSet NormalSet { get; }
    PresentationMeshFeature Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [PresentationMeshFeatureEntitiesEnumerator](../objects/PresentationMeshFeatureEntitiesEnumerator.md).Item

**Referenced types:** [ColorBindingEnum](../enums/ColorBindingEnum.md), [GraphicsColorSet](../objects/GraphicsColorSet.md), [GraphicsCoordinateSet](../objects/GraphicsCoordinateSet.md), [GraphicsIndexSet](../objects/GraphicsIndexSet.md), [GraphicsNormalSet](../objects/GraphicsNormalSet.md), [NormalBindingEnum](../enums/NormalBindingEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationMeshFeature](../objects/PresentationMeshFeature.md)

