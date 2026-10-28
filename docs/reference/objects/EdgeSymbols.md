# EdgeSymbols

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.EdgeSymbols`

```csharp
interface EdgeSymbols
{
    // Properties
    object Application { get; }
    int Count { get; }
    EdgeSymbol Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    EdgeSymbol Add(ObjectCollection LeaderPoints, EdgeSymbolDefinition EdgeSymbolDefinition);
    EdgeSymbolDefinition CreateDefinition(object ValuePositionType = Missing, object IndicationType = Missing, object SymbolOptions = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).EdgeSymbols

**Referenced types:** [EdgeSymbol](../objects/EdgeSymbol.md), [EdgeSymbolDefinition](../objects/EdgeSymbolDefinition.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

