# PresentationSnapshotView

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].SnapshotViews.Item[…]`

```csharp
interface PresentationSnapshotView
{
    // Properties
    object Application { get; }
    string DisplayName { get; set; }
    PresentationScene Parent { get; }
    Camera SavedCamera { get; }
    bool StoryboardAssociative { get; set; }
    PresentationTrails Trails { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Edit();
    void ExitEdit();
    void SetAppearance(ObjectCollection PresentationComponents, Asset Appearance);
    void SetOpacity(ObjectCollection PresentationComponents, double Opacity);
    void SetVisibility(ObjectCollection PresentationComponents, bool Visible);
}
```

**Returned by:** [PresentationScene](../objects/PresentationScene.md).ActiveSnapshotView, [PresentationSnapshotViews](../objects/PresentationSnapshotViews.md).Item

**Referenced types:** [Asset](../objects/Asset.md), [Camera](../objects/Camera.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationScene](../objects/PresentationScene.md), [PresentationTrails](../objects/PresentationTrails.md)

