# TransitionSymbols

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.TransitionSymbols`

```csharp
interface TransitionSymbols
{
    // Properties
    object Application { get; } // since 2025
    int Count { get; } // since 2025
    TransitionSymbol Item[int Index] { get; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    // Methods
    TransitionSymbol Add(ObjectCollection LeaderPoints, TransitionSymbolDefinition TransitionSymbolDefinition); // since 2025
    TransitionSymbolDefinition CreateDefinition(object SymbolIndicationType = Missing, object CombinedMaximumAndLeastMaterial = Missing, object Options = Missing); // since 2025
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).TransitionSymbols

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [TransitionSymbol](../objects/TransitionSymbol.md), [TransitionSymbolDefinition](../objects/TransitionSymbolDefinition.md)

