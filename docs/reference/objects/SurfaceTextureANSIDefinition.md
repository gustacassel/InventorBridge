# SurfaceTextureANSIDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SurfaceTextureSymbolDefinition](../objects/SurfaceTextureSymbolDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.SurfaceTextureSymbols.Item[…].Definition → (SurfaceTextureANSIDefinition)`

```csharp
interface SurfaceTextureANSIDefinition
{
    // Properties
    string AdditionalMaxRoughness { get; set; }
    string AdditionalMinRoughness { get; set; }
    bool AllAroundSymbol { get; set; }
    object Application { get; }
    string Cutoff { get; set; }
    bool IsForceTailShown { get; set; }
    bool IsMajority { get; set; }
    LayDirectionTypeEnum LayDirection { get; set; }
    string MachiningAllowance { get; set; }
    string MaximumRoughness { get; set; }
    string MinimumRoughness { get; set; }
    Sheet Parent { get; }
    string ProcessNote { get; set; }
    string SamplingLength { get; set; }
    SurfaceTextureStandardReferenceTypeEnum StandardReference { get; } // since 2025
    SurfaceTextureTypeEnum SurfaceTextureType { get; set; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [LayDirectionTypeEnum](../enums/LayDirectionTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sheet](../objects/Sheet.md), [SurfaceTextureStandardReferenceTypeEnum](../enums/SurfaceTextureStandardReferenceTypeEnum.md), [SurfaceTextureTypeEnum](../enums/SurfaceTextureTypeEnum.md)

