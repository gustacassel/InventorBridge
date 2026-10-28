# PunchNotes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingNotes.PunchNotes`

```csharp
interface PunchNotes
{
    // Properties
    object Application { get; }
    int Count { get; }
    PunchNote Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    PunchNote Add(Point2d Position, GeometryIntent PunchEdge, object DimensionStyle = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingNotes](../objects/DrawingNotes.md).PunchNotes

**Referenced types:** [GeometryIntent](../objects/GeometryIntent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [PunchNote](../objects/PunchNote.md)

