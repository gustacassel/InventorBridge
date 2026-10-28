# RevisionCloudControlPoint

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.RevisionClouds.Item[…].Definition.ControlPoints.Item[…]`

```csharp
interface RevisionCloudControlPoint
{
    // Properties
    object Application { get; }
    int Index { get; }
    RevisionCloudDefinition Parent { get; }
    Point2d Position { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [RevisionCloudControlPoints](../objects/RevisionCloudControlPoints.md).Add, [RevisionCloudControlPoints](../objects/RevisionCloudControlPoints.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [RevisionCloudDefinition](../objects/RevisionCloudDefinition.md)

