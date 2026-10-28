# PresentationTrails

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].SnapshotViews.Item[…].Trails`

```csharp
interface PresentationTrails
{
    // Properties
    int Count { get; }
    PresentationTrail Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PresentationSnapshotView](../objects/PresentationSnapshotView.md).Trails

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationTrail](../objects/PresentationTrail.md)

