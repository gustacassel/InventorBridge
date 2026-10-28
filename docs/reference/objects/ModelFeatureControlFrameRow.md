# ModelFeatureControlFrameRow

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelFeatureControlFrames.Item[…].Definition.FeatureControlFrameRows.Item[…]`

```csharp
interface ModelFeatureControlFrameRow
{
    // Properties
    object Application { get; }
    bool DisplayCommonZoneModifier { get; set; }
    bool DisplayFreeStateModifier { get; set; }
    bool DisplayProjectedToleranceZoneModifier { get; set; }
    bool DisplayStatisticalModifier { get; set; }
    bool DisplayTangentPlaneModifier { get; set; }
    bool DisplayUnequallyDisposedModifier { get; set; }
    bool GeneralProfileOfSurfaceModifier { get; set; }
    GeometricCharacteristicEnum GeometricCharacteristic { get; set; }
    string InternalName { get; }
    ModelFeatureControlFrameDefinition Parent { get; }
    ModelDatumIdentifier PrimaryCompoundDatumIdentifier { get; set; }
    GDTSymbolEnum PrimaryCompoundDatumModifier { get; set; }
    ModelDatumIdentifier PrimaryDatumIdentifier { get; set; }
    GDTSymbolEnum PrimaryDatumModifier { get; set; }
    short ProjectedToleranceZonePrecision { get; set; }
    double ProjectedToleranceZoneValue { get; set; }
    ModelDatumIdentifier SecondaryCompoundDatumIdentifier { get; set; }
    GDTSymbolEnum SecondaryCompoundDatumModifier { get; set; }
    ModelDatumIdentifier SecondaryDatumIdentifier { get; set; }
    GDTSymbolEnum SecondaryDatumModifier { get; set; }
    ModelDatumIdentifier TertiaryCompoundDatumIdentifier { get; set; }
    GDTSymbolEnum TertiaryCompoundDatumModifier { get; set; }
    ModelDatumIdentifier TertiaryDatumIdentifier { get; set; }
    GDTSymbolEnum TertiaryDatumModifier { get; set; }
    double Tolerance { get; set; }
    GDTSymbolEnum ToleranceMaterialCondition { get; set; }
    GDTSymbolEnum ToleranceModifierPrefix { get; set; }
    short TolerancePrecision { get; set; }
    ObjectTypeEnum Type { get; }
    short UnequallyDisposedPrecision { get; set; }
    double UnequallyDisposedValue { get; set; }
    // Methods
    void Delete();
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ModelFeatureControlFrameRows](../objects/ModelFeatureControlFrameRows.md).Add, [ModelFeatureControlFrameRows](../objects/ModelFeatureControlFrameRows.md).Item

**Referenced types:** [GDTSymbolEnum](../enums/GDTSymbolEnum.md), [GeometricCharacteristicEnum](../enums/GeometricCharacteristicEnum.md), [ModelDatumIdentifier](../objects/ModelDatumIdentifier.md), [ModelFeatureControlFrameDefinition](../objects/ModelFeatureControlFrameDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

