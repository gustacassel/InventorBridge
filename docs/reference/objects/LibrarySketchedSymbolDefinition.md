# LibrarySketchedSymbolDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).SketchedSymbolDefinitions.SketchedSymbolDefinitionLibraries.Item[…].SketchedSymbolDefinitions.Item[…]`

```csharp
interface LibrarySketchedSymbolDefinition
{
    // Properties
    object Application { get; }
    string Name { get; }
    SketchedSymbolDefinitionLibrary Parent { get; }
    LibraryFolder ParentFolder { get; }
    IPictureDisp Thumbnail { get; } // since 2025
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [LibrarySketchedSymbolDefinitions](../objects/LibrarySketchedSymbolDefinitions.md).Item

**Referenced types:** [IPictureDisp](../objects/IPictureDisp.md), [LibraryFolder](../objects/LibraryFolder.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchedSymbolDefinitionLibrary](../objects/SketchedSymbolDefinitionLibrary.md)

