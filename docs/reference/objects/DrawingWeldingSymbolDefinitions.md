# DrawingWeldingSymbolDefinitions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.WeldingSymbols.Item[…].Definitions`

```csharp
interface DrawingWeldingSymbolDefinitions
{
    // Properties
    object Application { get; }
    int Count { get; }
    DrawingWeldingSymbolDefinition Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DrawingWeldingSymbolDefinition Add(object TargetIndex = Missing);
    DrawingWeldingSymbolDefinitions Copy();
    void Remove(int Index);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingWeldingSymbol](../objects/DrawingWeldingSymbol.md).Definitions, [DrawingWeldingSymbolDefinitions](../objects/DrawingWeldingSymbolDefinitions.md).Copy, [DrawingWeldingSymbols](../objects/DrawingWeldingSymbols.md).CreateDefinitions

**Referenced types:** [DrawingWeldingSymbolDefinition](../objects/DrawingWeldingSymbolDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

