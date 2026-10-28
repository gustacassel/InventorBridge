# LibrarySketchedSymbolDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).SketchedSymbolDefinitions.SketchedSymbolDefinitionLibraries.Item[…].SketchedSymbolDefinitions`

```csharp
interface LibrarySketchedSymbolDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    LibrarySketchedSymbolDefinition Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [LibraryFolder](../objects/LibraryFolder.md).SketchedSymbolDefinitions, [SketchedSymbolDefinitionLibrary](../objects/SketchedSymbolDefinitionLibrary.md).SketchedSymbolDefinitions

**Referenced types:** [LibrarySketchedSymbolDefinition](../objects/LibrarySketchedSymbolDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

