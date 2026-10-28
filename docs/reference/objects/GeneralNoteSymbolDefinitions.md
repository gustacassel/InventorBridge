# GeneralNoteSymbolDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelGeneralNotes.Item[…].Definition.SymbolDefinitions`

```csharp
interface GeneralNoteSymbolDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    GeneralNoteSymbolDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    GeneralNoteSymbolDefinition Add(object SymbolDefinition, object TargetIndex = Missing, object InsertBefore = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelGeneralNoteDefinition](../objects/ModelGeneralNoteDefinition.md).SymbolDefinitions

**Referenced types:** [GeneralNoteSymbolDefinition](../objects/GeneralNoteSymbolDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

