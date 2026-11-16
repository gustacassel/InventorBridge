# SurfaceTextureSymbolDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.SurfaceTextureSymbols.Item[…].Definition`

```csharp
interface SurfaceTextureSymbolDefinition
{
    // Properties
    bool AllAroundSymbol { get; set; }
    object Application { get; }
    bool IsForceTailShown { get; set; }
    bool IsMajority { get; set; }
    Sheet Parent { get; }
    SurfaceTextureStandardReferenceTypeEnum StandardReference { get; } // since 2025
    DraftingStandardEnum StandardReferenceType { get; } // hidden in 2025, 2026, 2027: there, prefer the newer members
    SurfaceTextureTypeEnum SurfaceTextureType { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [SurfaceTextureSymbol](../objects/SurfaceTextureSymbol.md).Definition, [SurfaceTextureSymbols](../objects/SurfaceTextureSymbols.md).CreateDefinition

**Referenced types:** [DraftingStandardEnum](../enums/DraftingStandardEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sheet](../objects/Sheet.md), [SurfaceTextureStandardReferenceTypeEnum](../enums/SurfaceTextureStandardReferenceTypeEnum.md), [SurfaceTextureTypeEnum](../enums/SurfaceTextureTypeEnum.md)

