# HoleThreadNotes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingNotes.HoleThreadNotes`

```csharp
interface HoleThreadNotes
{
    // Properties
    object Application { get; }
    int Count { get; }
    HoleThreadNote Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    HoleThreadNote Add(Point2d Position, object HoleOrThreadEdge, bool LinearDiameterType = false, object DimensionStyle = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingNotes](../objects/DrawingNotes.md).HoleThreadNotes

**Referenced types:** [HoleThreadNote](../objects/HoleThreadNote.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md)

