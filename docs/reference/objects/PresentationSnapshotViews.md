# PresentationSnapshotViews

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].SnapshotViews`

```csharp
interface PresentationSnapshotViews
{
    // Properties
    object Application { get; }
    int Count { get; }
    PresentationSnapshotView Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PresentationScene](../objects/PresentationScene.md).SnapshotViews

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationSnapshotView](../objects/PresentationSnapshotView.md)

