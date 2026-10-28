# RevisionClouds

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.RevisionClouds`

```csharp
interface RevisionClouds
{
    // Properties
    object Application { get; }
    int Count { get; }
    RevisionCloud Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RevisionCloud Add(RevisionCloudDefinition Definition, object Name = Missing);
    RevisionCloudDefinition CreateRevisionCloudDefinition(ObjectCollection ControlPoints, object Layer = Missing, bool Inverted = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DetailDrawingView](../objects/DetailDrawingView.md).RevisionClouds, [DrawingView](../objects/DrawingView.md).RevisionClouds, [SectionDrawingView](../objects/SectionDrawingView.md).RevisionClouds, [Sheet](../objects/Sheet.md).RevisionClouds

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RevisionCloud](../objects/RevisionCloud.md), [RevisionCloudDefinition](../objects/RevisionCloudDefinition.md)

