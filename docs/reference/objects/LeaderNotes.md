# LeaderNotes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingNotes.LeaderNotes`

```csharp
interface LeaderNotes
{
    // Properties
    object Application { get; }
    int Count { get; }
    LeaderNote Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    LeaderNote Add(ObjectCollection LeaderPoints, string FormattedText, object DimensionStyle = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingNotes](../objects/DrawingNotes.md).LeaderNotes

**Referenced types:** [LeaderNote](../objects/LeaderNote.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

