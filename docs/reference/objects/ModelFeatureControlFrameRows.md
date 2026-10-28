# ModelFeatureControlFrameRows

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelFeatureControlFrames.Item[…].Definition.FeatureControlFrameRows`

```csharp
interface ModelFeatureControlFrameRows
{
    // Properties
    object Application { get; }
    int Count { get; }
    ModelFeatureControlFrameRow Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ModelFeatureControlFrameRow Add(GeometricCharacteristicEnum GeometricCharacteristic, double Tolerance, GDTSymbolEnum ToleranceModifierPrefix = GDTSymbolEnum.kGDTNoSymbol, GDTSymbolEnum ToleranceMaterialCondition = GDTSymbolEnum.kGDTNoSymbol, object PrimaryDatumIdentifier = Missing, GDTSymbolEnum PrimaryDatumModifier = GDTSymbolEnum.kGDTNoSymbol, object SecondaryDatumIdentifier = Missing, GDTSymbolEnum SecondaryDatumModifier = GDTSymbolEnum.kGDTNoSymbol, object TertiaryDatumIdentifier = Missing, GDTSymbolEnum TertiaryDatumModifier = GDTSymbolEnum.kGDTNoSymbol);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelFeatureControlFrameDefinition](../objects/ModelFeatureControlFrameDefinition.md).FeatureControlFrameRows

**Referenced types:** [GDTSymbolEnum](../enums/GDTSymbolEnum.md), [GeometricCharacteristicEnum](../enums/GeometricCharacteristicEnum.md), [ModelFeatureControlFrameRow](../objects/ModelFeatureControlFrameRow.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

