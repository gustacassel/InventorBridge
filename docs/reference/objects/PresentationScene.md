# PresentationScene

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…]`

```csharp
interface PresentationScene
{
    // Properties
    string ActiveModelState { get; set; } // since 2025
    PresentationSnapshotView ActiveSnapshotView { get; }
    object Application { get; }
    ClientGraphicsCollection ClientGraphicsCollection { get; }
    bool DesignViewAssociative { get; set; }
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    string Name { get; set; }
    PresentationDocument Parent { get; }
    PresentationSnapshotViews SnapshotViews { get; }
    PresentationComponent TopSceneComponent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Activate();
}
```

**Returned by:** [PresentationComponent](../objects/PresentationComponent.md).Parent, [PresentationDocument](../objects/PresentationDocument.md).ActiveScene, [PresentationScenes](../objects/PresentationScenes.md).Item, [PresentationSnapshotView](../objects/PresentationSnapshotView.md).Parent, [PublisherServer](../objects/PublisherServer.md).GetActivePresentationScene

**Referenced types:** [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md), [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationComponent](../objects/PresentationComponent.md), [PresentationDocument](../objects/PresentationDocument.md), [PresentationSnapshotView](../objects/PresentationSnapshotView.md), [PresentationSnapshotViews](../objects/PresentationSnapshotViews.md)

