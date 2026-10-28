# PresentationTrail

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].SnapshotViews.Item[…].Trails.Item[…]`

```csharp
interface PresentationTrail
{
    // Properties
    object Application { get; }
    bool Deleted { get; }
    object Parent { get; }
    PresentationComponent PresentationComponent { get; }
    PresentationTrailSegments Segments { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [PresentationTrails](../objects/PresentationTrails.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationComponent](../objects/PresentationComponent.md), [PresentationTrailSegments](../objects/PresentationTrailSegments.md)

