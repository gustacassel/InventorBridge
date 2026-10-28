# BendNotes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingNotes.BendNotes`

```csharp
interface BendNotes
{
    // Properties
    object Application { get; }
    int Count { get; }
    BendNote Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BendNote Add(DrawingCurve BendEdge, object DimensionStyle = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingNotes](../objects/DrawingNotes.md).BendNotes

**Referenced types:** [BendNote](../objects/BendNote.md), [DrawingCurve](../objects/DrawingCurve.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

