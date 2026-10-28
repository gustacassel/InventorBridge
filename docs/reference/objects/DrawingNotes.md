# DrawingNotes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingNotes`

```csharp
interface DrawingNotes
{
    // Properties
    object Application { get; }
    BendNotes BendNotes { get; }
    ChamferNotes ChamferNotes { get; }
    int Count { get; }
    GeneralNotes GeneralNotes { get; }
    HoleThreadNotes HoleThreadNotes { get; }
    DrawingNote Item[int Index] { get; }
    LeaderNotes LeaderNotes { get; }
    PunchNotes PunchNotes { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).DrawingNotes

**Referenced types:** [BendNotes](../objects/BendNotes.md), [ChamferNotes](../objects/ChamferNotes.md), [DrawingNote](../objects/DrawingNote.md), [GeneralNotes](../objects/GeneralNotes.md), [HoleThreadNotes](../objects/HoleThreadNotes.md), [LeaderNotes](../objects/LeaderNotes.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PunchNotes](../objects/PunchNotes.md)

