# LibraryFolder

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).SketchedSymbolDefinitions.SketchedSymbolDefinitionLibraries.Item[…].Folders.Item[…]`

```csharp
interface LibraryFolder
{
    // Properties
    object Application { get; }
    LibraryFolders ChildFolders { get; }
    string Name { get; }
    SketchedSymbolDefinitionLibrary Parent { get; }
    LibraryFolder ParentFolder { get; }
    LibrarySketchedSymbolDefinitions SketchedSymbolDefinitions { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [LibraryFolder](../objects/LibraryFolder.md).ParentFolder, [LibraryFolders](../objects/LibraryFolders.md).Add, [LibraryFolders](../objects/LibraryFolders.md).Item, [LibrarySketchedSymbolDefinition](../objects/LibrarySketchedSymbolDefinition.md).ParentFolder

**Referenced types:** [LibraryFolders](../objects/LibraryFolders.md), [LibrarySketchedSymbolDefinitions](../objects/LibrarySketchedSymbolDefinitions.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchedSymbolDefinitionLibrary](../objects/SketchedSymbolDefinitionLibrary.md)

