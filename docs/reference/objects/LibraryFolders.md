# LibraryFolders

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).SketchedSymbolDefinitions.SketchedSymbolDefinitionLibraries.Item[…].Folders`

```csharp
interface LibraryFolders
{
    // Properties
    object Application { get; }
    int Count { get; }
    LibraryFolder Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    LibraryFolder Add(object Name = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [LibraryFolder](../objects/LibraryFolder.md).ChildFolders, [SketchedSymbolDefinitionLibrary](../objects/SketchedSymbolDefinitionLibrary.md).Folders

**Referenced types:** [LibraryFolder](../objects/LibraryFolder.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

