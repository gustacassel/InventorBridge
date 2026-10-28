# SketchedSymbols

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.SketchedSymbols`

```csharp
interface SketchedSymbols
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchedSymbol Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchedSymbol Add(object SketchedSymbolDefinition, Point2d Position, double Rotation = 0, double Scale = 1, object PromptStrings = Missing);
    SketchedSymbol AddWithLeader(object SketchedSymbolDefinition, ObjectCollection LeaderPoints, double Rotation = 0, double Scale = 1, object PromptStrings = Missing, bool SymbolClipping = true, bool Static = false);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).SketchedSymbols

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [SketchedSymbol](../objects/SketchedSymbol.md)

