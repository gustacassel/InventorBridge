# RevisionCloudControlPoints

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.RevisionClouds.Item[…].Definition.ControlPoints`

```csharp
interface RevisionCloudControlPoints
{
    // Properties
    object Application { get; }
    int Count { get; }
    RevisionCloudControlPoint Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RevisionCloudControlPoint Add(Point2d Position, object TargetIndex = Missing, bool After = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [RevisionCloudDefinition](../objects/RevisionCloudDefinition.md).ControlPoints

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [RevisionCloudControlPoint](../objects/RevisionCloudControlPoint.md)

