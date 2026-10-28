# NotebookOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.NotebookOptions`

```csharp
interface NotebookOptions
{
    // Properties
    object Application { get; }
    Color ArrowColor { get; set; }
    bool DisplayNoteIcons { get; set; }
    bool DisplayNoteText { get; set; }
    bool KeepNotesOnDeletedObjects { get; set; }
    Color NoteHighlightColor { get; set; }
    Color TextBackgroundColor { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [Application](../objects/Application.md).NotebookOptions, [InventorServer](../objects/InventorServer.md).NotebookOptions

**Referenced types:** [Color](../objects/Color.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

