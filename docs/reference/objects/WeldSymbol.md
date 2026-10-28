# WeldSymbol

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.WeldingSymbols.Item[…].Definitions.Item[…].WeldSymbolOne`

```csharp
interface WeldSymbol
{
    // Properties
    string Angle { get; set; }
    object Application { get; }
    bool Brazing { get; set; }
    string Clearance { get; set; }
    ContourSymbolTypeEnum Contour { get; set; }
    string CountersinkAngle { get; set; }
    string Depth { get; set; }
    string Diameter { get; set; }
    string EitherSide { get; set; }
    bool EnableSecondaryFilletWeld { get; set; }
    string FillingDepth { get; set; }
    string Gap { get; set; }
    string Height { get; set; }
    string IncludedAngle { get; set; }
    string Leg1 { get; set; }
    string Leg2 { get; set; }
    string Length { get; set; }
    string Method { get; set; }
    string Number { get; set; }
    object Parent { get; }
    string PenetrationDepth { get; set; }
    string Pitch { get; set; }
    string Prefix { get; set; }
    string PreparationDepth { get; set; }
    string Root { get; set; }
    string RootGap { get; set; }
    WeldSymbol SecondaryWeldSymbol { get; }
    string SizeOrStrength { get; set; }
    string Spacing { get; set; }
    string Test { get; set; }
    string Thickness { get; set; }
    ObjectTypeEnum Type { get; }
    int WeldSymbolType { get; set; }
    string Width { get; set; }
}
```

**Returned by:** [DrawingWeldingSymbolDefinition](../objects/DrawingWeldingSymbolDefinition.md).WeldSymbolOne, [DrawingWeldingSymbolDefinition](../objects/DrawingWeldingSymbolDefinition.md).WeldSymbolTwo, [ModelWeldingSymbolDefinition](../objects/ModelWeldingSymbolDefinition.md).WeldSymbolOne, [ModelWeldingSymbolDefinition](../objects/ModelWeldingSymbolDefinition.md).WeldSymbolTwo, [WeldSymbol](../objects/WeldSymbol.md).SecondaryWeldSymbol

**Referenced types:** [ContourSymbolTypeEnum](../enums/ContourSymbolTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

