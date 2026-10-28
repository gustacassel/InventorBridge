# GeneralNotes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingNotes.GeneralNotes`

```csharp
interface GeneralNotes
{
    // Properties
    object Application { get; }
    int Count { get; }
    GeneralNote Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    GeneralNote AddByRectangle(Point2d CornerOne, Point2d CornerTwo, string FormattedText, object TextStyle = Missing);
    GeneralNote AddFitted(Point2d PlacementPoint, string FormattedText, object TextStyle = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingNotes](../objects/DrawingNotes.md).GeneralNotes

**Referenced types:** [GeneralNote](../objects/GeneralNote.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md)

