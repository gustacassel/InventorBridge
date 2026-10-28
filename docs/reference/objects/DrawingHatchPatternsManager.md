# DrawingHatchPatternsManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).DrawingHatchPatternsManager`

```csharp
interface DrawingHatchPatternsManager
{
    // Properties
    object Application { get; }
    int Count { get; }
    DrawingHatchPattern Item[object Index] { get; }
    DrawingDocument Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void ExportHatchPatterns(object DrawingHatchPatterns, string FullFileName);
    void GetHatchPatternDefinitions(string FullFileName, out string[] PatternDefinitionNames, out string[] Descriptions);
    void LoadHatchPatterns(string FullFileName, ref string[] PatternDefinitionNames);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingDocument](../objects/DrawingDocument.md).DrawingHatchPatternsManager, [DrawingHatchPattern](../objects/DrawingHatchPattern.md).Parent

**Referenced types:** [DrawingDocument](../objects/DrawingDocument.md), [DrawingHatchPattern](../objects/DrawingHatchPattern.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

