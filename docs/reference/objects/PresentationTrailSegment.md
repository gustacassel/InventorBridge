# PresentationTrailSegment

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].SnapshotViews.Item[…].Trails.Item[…].Segments.Item[…]`

```csharp
interface PresentationTrailSegment
{
    // Properties
    object Application { get; }
    object Geometry { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
}
```

**Returned by:** [PresentationTrailSegments](../objects/PresentationTrailSegments.md).Item, [PresentationTrailSegmentsEnumerator](../objects/PresentationTrailSegmentsEnumerator.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

