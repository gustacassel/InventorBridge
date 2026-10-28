# SketchedSymbolDefinitionLibraries

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).SketchedSymbolDefinitions.SketchedSymbolDefinitionLibraries`

```csharp
interface SketchedSymbolDefinitionLibraries
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchedSymbolDefinitionLibrary Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchedSymbolDefinitionLibrary Add(string Name);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SketchedSymbolDefinitions](../objects/SketchedSymbolDefinitions.md).SketchedSymbolDefinitionLibraries

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchedSymbolDefinitionLibrary](../objects/SketchedSymbolDefinitionLibrary.md)

