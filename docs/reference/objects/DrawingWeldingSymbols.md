# DrawingWeldingSymbols

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.WeldingSymbols`

```csharp
interface DrawingWeldingSymbols
{
    // Properties
    object Application { get; }
    int Count { get; }
    DrawingWeldingSymbol Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DrawingWeldingSymbol Add(ObjectCollection LeaderPoints, DrawingWeldingSymbolDefinitions Definitions, object WeldSymbolStyle = Missing);
    DrawingWeldingSymbolDefinitions CreateDefinitions();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).WeldingSymbols

**Referenced types:** [DrawingWeldingSymbol](../objects/DrawingWeldingSymbol.md), [DrawingWeldingSymbolDefinitions](../objects/DrawingWeldingSymbolDefinitions.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

