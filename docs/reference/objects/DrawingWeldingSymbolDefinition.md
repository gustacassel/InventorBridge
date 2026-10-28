# DrawingWeldingSymbolDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.WeldingSymbols.Item[…].Definitions.Item[…]`

```csharp
interface DrawingWeldingSymbolDefinition
{
    // Properties
    bool AllAroundSymbol { get; set; }
    object Application { get; }
    bool ClosedNoteTail { get; set; }
    bool FieldWeldingSymbol { get; set; }
    IdentificationLinePlacementEnum IdentificationLinePlacement { get; set; }
    DrawingWeldingSymbol Parent { get; }
    StaggerTypeEnum StaggerType { get; set; }
    bool SwapArrowAndSymbols { get; set; }
    string TailNote { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseSpacer { get; set; }
    WeldSymbol WeldSymbolOne { get; }
    WeldSymbol WeldSymbolTwo { get; }
}
```

**Returned by:** [DrawingWeldingSymbolDefinitions](../objects/DrawingWeldingSymbolDefinitions.md).Add, [DrawingWeldingSymbolDefinitions](../objects/DrawingWeldingSymbolDefinitions.md).Item

**Referenced types:** [DrawingWeldingSymbol](../objects/DrawingWeldingSymbol.md), [IdentificationLinePlacementEnum](../enums/IdentificationLinePlacementEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [StaggerTypeEnum](../enums/StaggerTypeEnum.md), [WeldSymbol](../objects/WeldSymbol.md)

