# SketchedSymbolDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).SketchedSymbolDefinitions`

```csharp
interface SketchedSymbolDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchedSymbolDefinition Item[object Index] { get; }
    SketchedSymbolDefinitionLibraries SketchedSymbolDefinitionLibraries { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchedSymbolDefinition Add(string Name);
    SketchedSymbolDefinition AddFromLibrary(object SketchedSymbolDefinitionLibrary, string SketchedSymbolDefinitionName, object ReplaceExisting = Missing);
    void SaveAllToLibrary(object TargetSketchedSymbolDefinitionLibrary, object RetainResourceFolderStructure = Missing, object DestinationFolder = Missing, object ReplaceExisting = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingDocument](../objects/DrawingDocument.md).SketchedSymbolDefinitions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchedSymbolDefinition](../objects/SketchedSymbolDefinition.md), [SketchedSymbolDefinitionLibraries](../objects/SketchedSymbolDefinitionLibraries.md)

