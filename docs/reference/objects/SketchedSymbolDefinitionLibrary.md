# SketchedSymbolDefinitionLibrary

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).SketchedSymbolDefinitions.SketchedSymbolDefinitionLibraries.Item[…]`

```csharp
interface SketchedSymbolDefinitionLibrary
{
    // Properties
    object Application { get; }
    LibraryFolders Folders { get; }
    bool IsReadOnly { get; }
    string Name { get; }
    LibrarySketchedSymbolDefinitions SketchedSymbolDefinitions { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [LibraryFolder](../objects/LibraryFolder.md).Parent, [LibrarySketchedSymbolDefinition](../objects/LibrarySketchedSymbolDefinition.md).Parent, [SketchedSymbolDefinitionLibraries](../objects/SketchedSymbolDefinitionLibraries.md).Add, [SketchedSymbolDefinitionLibraries](../objects/SketchedSymbolDefinitionLibraries.md).Item

**Referenced types:** [LibraryFolders](../objects/LibraryFolders.md), [LibrarySketchedSymbolDefinitions](../objects/LibrarySketchedSymbolDefinitions.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

