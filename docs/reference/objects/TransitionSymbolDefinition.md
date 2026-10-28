# TransitionSymbolDefinition

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.TransitionSymbols.Item[…].Definition`

```csharp
interface TransitionSymbolDefinition
{
    // Properties
    object Application { get; } // since 2025
    string CenterMainIndicationArea { get; set; } // since 2025
    string CenterMainIndicationArea2 { get; set; } // since 2025
    bool CombinedMaximumAndLeastMaterial { get; set; } // since 2025
    TransitionSymbolIndicationTypeEnum IndicationType { get; set; } // since 2025
    Layer Layer { get; set; } // since 2025
    string LowerMainIndicationArea { get; set; } // since 2025
    string LowerMainIndicationArea2 { get; set; } // since 2025
    TransitionSymbol Parent { get; } // since 2025
    int SeveralTolerancedFeaturesIndication { get; set; } // since 2025
    TransitionSymbolStyle Style { get; set; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
    string UpperMainIndicationArea { get; set; } // since 2025
    string UpperMainIndicationArea2 { get; set; } // since 2025
    // Methods
    TransitionSymbolDefinition Copy(); // since 2025
}
```

**Returned by:** [TransitionSymbol](../objects/TransitionSymbol.md).Definition, [TransitionSymbolDefinition](../objects/TransitionSymbolDefinition.md).Copy, [TransitionSymbols](../objects/TransitionSymbols.md).CreateDefinition

**Referenced types:** [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [TransitionSymbol](../objects/TransitionSymbol.md), [TransitionSymbolIndicationTypeEnum](../enums/TransitionSymbolIndicationTypeEnum.md), [TransitionSymbolStyle](../objects/TransitionSymbolStyle.md)

