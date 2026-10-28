# RevisionCloud

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.RevisionClouds.Item[…]`

```csharp
interface RevisionCloud
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    RevisionCloudDefinition Definition { get; set; }
    string Name { get; set; }
    object Parent { get; }
    Point2d Position { get; set; }
    Box2d RangeBox { get; }
    DrawingSketch Sketch { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RevisionCloud CopyTo(Sheet TargetSheet, object NewName = Missing, object Position = Missing);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [RevisionCloud](../objects/RevisionCloud.md).CopyTo, [RevisionCloudDefinition](../objects/RevisionCloudDefinition.md).Parent, [RevisionClouds](../objects/RevisionClouds.md).Add, [RevisionClouds](../objects/RevisionClouds.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [DrawingSketch](../objects/DrawingSketch.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [RevisionCloudDefinition](../objects/RevisionCloudDefinition.md), [Sheet](../objects/Sheet.md)

