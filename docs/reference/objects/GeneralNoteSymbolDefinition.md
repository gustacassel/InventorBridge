# GeneralNoteSymbolDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelGeneralNotes.Item[…].Definition.SymbolDefinitions.Item[…]`

```csharp
interface GeneralNoteSymbolDefinition
{
    // Properties
    object Application { get; }
    ModelGeneralNoteDefinition Parent { get; }
    object SymbolDefinition { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [GeneralNoteSymbolDefinitions](../objects/GeneralNoteSymbolDefinitions.md).Add, [GeneralNoteSymbolDefinitions](../objects/GeneralNoteSymbolDefinitions.md).Item

**Referenced types:** [ModelGeneralNoteDefinition](../objects/ModelGeneralNoteDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

