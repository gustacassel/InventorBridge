# FeatureControlFrameStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.FeatureControlFrameStyles.Item[…]`

```csharp
interface FeatureControlFrameStyle
{
    // Properties
    bool AlignCellsVertically { get; set; }
    bool AllowTolerance2 { get; set; }
    DecimalMarkerTypeEnum AlternateDecimalMarkerType { get; set; }
    bool AlternateDisplayUnitType { get; set; }
    bool AlternateLeadingZeroDisplay { get; set; }
    LinearPrecisionEnum AlternateLinearPrecision { get; set; }
    UnitsTypeEnum AlternateLinearUnits { get; set; }
    bool AlternateTrailingZeroDisplay { get; set; }
    bool AlternateUnitsDisplay { get; set; }
    AlternateUnitsDisplayTypeEnum AlternateUnitsDisplayType { get; set; }
    object Application { get; }
    bool AttachLeaderToCorner { get; set; }
    GeometricCharacteristicEnum AvailableGeometricCharacteristics { get; set; }
    MaterialRemovalModifierEnum AvailableModifiers { get; set; }
    string Comments { get; set; }
    DecimalMarkerTypeEnum DecimalMarkerType { get; set; }
    bool DisplayUnitType { get; set; }
    bool EnableAuxiliaryFeatureIndicators { get; set; }
    bool EnableInlineNotes { get; set; }
    bool InUse { get; }
    string InternalName { get; }
    LeaderStyle LeaderStyle { get; set; }
    bool LeadingZeroDisplay { get; set; }
    UnitsTypeEnum LinearUnits { get; set; }
    bool MergeDatum { get; set; }
    bool MergeSymbol { get; set; }
    bool MergeTolerance { get; set; }
    string Name { get; set; }
    object Parent { get; }
    bool ScaleToTextHeight { get; set; }
    double Size { get; set; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    TextStyle TextStyle { get; set; }
    bool TrailingZeroDisplay { get; set; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    double WhiteSpace { get; set; }
    // Methods
    Style ConvertToLocal();
    Style Copy(string Name);
    void Delete();
    void GetAvailableAdditionalSymbols(out FeatureControlFrameAdditionalSymbolsEnum[] AvailaleAdditionalSymbols);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SaveToGlobal();
    void SetAvailableAdditionalSymbols(ref FeatureControlFrameAdditionalSymbolsEnum[] AvailaleAdditionalSymbols);
    void UpdateFromGlobal();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FeatureControlFrame](../objects/FeatureControlFrame.md).Style, [FeatureControlFrameStylesEnumerator](../objects/FeatureControlFrameStylesEnumerator.md).Item, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).FeatureControlFrameStyle

**Referenced types:** [AlternateUnitsDisplayTypeEnum](../enums/AlternateUnitsDisplayTypeEnum.md), [DecimalMarkerTypeEnum](../enums/DecimalMarkerTypeEnum.md), [FeatureControlFrameAdditionalSymbolsEnum](../enums/FeatureControlFrameAdditionalSymbolsEnum.md), [GeometricCharacteristicEnum](../enums/GeometricCharacteristicEnum.md), [LeaderStyle](../objects/LeaderStyle.md), [LinearPrecisionEnum](../enums/LinearPrecisionEnum.md), [MaterialRemovalModifierEnum](../enums/MaterialRemovalModifierEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [TextStyle](../objects/TextStyle.md), [UnitsTypeEnum](../enums/UnitsTypeEnum.md)

