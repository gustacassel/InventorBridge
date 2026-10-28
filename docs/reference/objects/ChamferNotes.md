# ChamferNotes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingNotes.ChamferNotes`

```csharp
interface ChamferNotes
{
    // Properties
    object Application { get; }
    int Count { get; }
    ChamferNote Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ChamferNote Add(Point2d Position, object ChamferEdgeOne, object ChamferEdgeTwo, object DimensionStyle = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingNotes](../objects/DrawingNotes.md).ChamferNotes

**Referenced types:** [ChamferNote](../objects/ChamferNote.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md)

