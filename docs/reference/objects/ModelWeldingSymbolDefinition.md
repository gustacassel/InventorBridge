# ModelWeldingSymbolDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelWeldingSymbols.Item[…].Definitions.Item[…]`

```csharp
interface ModelWeldingSymbolDefinition
{
    // Properties
    bool AllAroundSymbol { get; set; }
    object Application { get; }
    bool ClosedNoteTail { get; set; }
    bool FieldWeldingSymbol { get; set; }
    IdentificationLinePlacementEnum IdentificationLinePlacement { get; set; }
    ModelWeldingSymbol Parent { get; }
    StaggerTypeEnum StaggerType { get; set; }
    bool SwapArrowAndSymbols { get; set; }
    string TailNote { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseSpacer { get; set; }
    WeldSymbol WeldSymbolOne { get; }
    WeldSymbol WeldSymbolTwo { get; }
}
```

**Returned by:** [ModelWeldingSymbolDefinitions](../objects/ModelWeldingSymbolDefinitions.md).Add, [ModelWeldingSymbolDefinitions](../objects/ModelWeldingSymbolDefinitions.md).AddFromWeldBead, [ModelWeldingSymbolDefinitions](../objects/ModelWeldingSymbolDefinitions.md).Item

**Referenced types:** [IdentificationLinePlacementEnum](../enums/IdentificationLinePlacementEnum.md), [ModelWeldingSymbol](../objects/ModelWeldingSymbol.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [StaggerTypeEnum](../enums/StaggerTypeEnum.md), [WeldSymbol](../objects/WeldSymbol.md)

