# EdgeSymbolDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.EdgeSymbols.Item[…].Definition`

```csharp
interface EdgeSymbolDefinition
{
    // Properties
    object Application { get; }
    string Edges { get; set; }
    string HorizontalValue { get; set; }
    string HorizontalValueLower { get; set; }
    EdgeSymbolIndicationTypeEnum IndicationType { get; set; }
    Layer Layer { get; set; }
    EdgeSymbol Parent { get; }
    bool RangeOfValues { get; set; }
    bool ReferenceToISO { get; set; }
    bool SidesDefined { get; set; }
    bool StatesOfAllEdgesAroundProfile { get; set; }
    EdgeSymbolStyle Style { get; set; }
    ObjectTypeEnum Type { get; }
    string UndefinedValue { get; set; }
    string UndefinedValueLower { get; set; }
    EdgeSymbolValuePositionTypeEnum ValuePositionType { get; set; }
    string VerticalValue { get; set; }
    string VerticalValueLower { get; set; }
    // Methods
    EdgeSymbolDefinition Copy();
}
```

**Returned by:** [EdgeSymbol](../objects/EdgeSymbol.md).Definition, [EdgeSymbolDefinition](../objects/EdgeSymbolDefinition.md).Copy, [EdgeSymbols](../objects/EdgeSymbols.md).CreateDefinition

**Referenced types:** [EdgeSymbol](../objects/EdgeSymbol.md), [EdgeSymbolIndicationTypeEnum](../enums/EdgeSymbolIndicationTypeEnum.md), [EdgeSymbolStyle](../objects/EdgeSymbolStyle.md), [EdgeSymbolValuePositionTypeEnum](../enums/EdgeSymbolValuePositionTypeEnum.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

