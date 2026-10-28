# DimensionStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.DimensionStyles.Item[…]`

```csharp
interface DimensionStyle
{
    // Properties
    DimensionTextOrientationEnum AlignedDimensionTextOrientation { get; set; }
    DecimalMarkerTypeEnum AlternateDecimalMarkerType { get; set; }
    DisplayFormatEnum AlternateDisplayFormat { get; set; }
    bool AlternateDisplayUnitType { get; set; }
    double AlternateFractionalTextScale { get; set; }
    bool AlternateIncludedZeroDisplay { get; set; }
    bool AlternateLeadingZeroDisplay { get; set; }
    LinearPrecisionEnum AlternateLinearPrecision { get; set; }
    UnitsTypeEnum AlternateLinearUnits { get; set; }
    bool AlternateTrailingZeroDisplay { get; set; }
    bool AngularArrowsInside { get; set; }
    bool AngularFormatIsDecimalDegrees { get; set; }
    bool AngularHideExtensionLineOne { get; set; }
    bool AngularHideExtensionLineTwo { get; set; }
    bool AngularLeadingZeroDisplay { get; set; }
    AngularPrecisionEnum AngularPrecision { get; set; }
    DimensionTextModifierEnum AngularTextModifier { get; set; }
    DimensionTextOrientationEnum AngularTextOrientation { get; set; }
    bool AngularTrailingZeroDisplay { get; set; }
    bool AngularUseQuadrant { get; set; }
    object Application { get; }
    bool ArcLengthDimensionSymbolAbove { get; set; } // since 2025
    double ArrowheadHeight { get; set; }
    double ArrowheadSize { get; set; }
    ArrowheadTypeEnum ArrowheadType { get; set; }
    ArrowheadTypeEnum ArrowheadTypeForChainDimensions { get; set; }
    bool BasicDimensionPrefixSuffixInside { get; set; }
    DimensionStyleFormatEnum BendNoteDualFormat { get; set; }
    DimensionStyleFormatEnum ChamferNoteDualFormat { get; set; }
    Color Color { get; set; }
    string Comments { get; set; }
    DecimalMarkerTypeEnum DecimalMarkerType { get; set; }
    bool DiameterArrowsInside { get; set; }
    bool DiameterDualDimensionLine { get; set; }
    DimensionTextOrientationEnum DiameterExternalTextOrientation { get; set; }
    DimensionTextOrientationEnum DiameterInternalTextOrientation { get; set; }
    bool DiameterLeaderFromCenter { get; set; }
    MultiLineDimensionTextEnum DiameterMultiLineTextOrientation { get; set; }
    bool DiameterShowDiameterSymbol { get; set; }
    DimensionStyleFormatEnum DimensionDualFormat { get; set; }
    DisplayFormatEnum DisplayFormat { get; set; }
    bool DisplayUnitType { get; set; }
    double ExtendBeyondTicks { get; set; } // since 2026
    double Extension { get; set; }
    double ExtensionLine { get; set; } // since 2026
    double FractionalTextScale { get; set; }
    double Gap { get; set; }
    DimensionStyleFormatEnum HoleNoteDualFormat { get; set; }
    string[] HoleThreadTypeList { get; } // since 2025
    DimensionTextOrientationEnum HorizontalDimensionTextOrientation { get; set; }
    bool InUse { get; }
    bool IncludedZeroDisplay { get; set; }
    string InternalName { get; }
    LeaderStyle LeaderStyle { get; set; }
    bool LeadingZeroDisplay { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    bool LinearArrowsInside { get; set; }
    bool LinearHideExtensionLineOne { get; set; }
    bool LinearHideExtensionLineTwo { get; set; }
    MultiLineDimensionTextEnum LinearMultiLineTextOrientation { get; set; }
    LinearPrecisionEnum LinearPrecision { get; set; }
    UnitsTypeEnum LinearUnits { get; set; }
    string Name { get; set; }
    OrdinateDimensionAlignmentEnum OrdinateAlignment { get; set; }
    ArrowheadTypeEnum OrdinateDimensionOriginArrowheadType { get; set; }
    bool OrdinateHideOriginIndicator { get; set; }
    bool OrdinateJoggingAllowed { get; set; }
    bool OrdinatePositiveBothDirections { get; set; }
    bool OrdinateShowDirection { get; set; }
    bool OrdinateUseOriginIndicator { get; set; }
    double OriginOffset { get; set; }
    object Parent { get; }
    double PartOffset { get; set; }
    string Prefix { get; set; }
    PrefixAndSuffixOrderEnum PrefixAndSuffixOrder { get; set; }
    DimensionStyleFormatEnum PunchNoteDualFormat { get; set; }
    bool RadialArrowsInside { get; set; }
    bool RadialJoggedLeader { get; set; }
    bool RadialLeaderFromCenter { get; set; }
    MultiLineDimensionTextEnum RadialMultiLineTextOrientation { get; set; }
    DimensionTextOrientationEnum RadialTextOrientation { get; set; }
    bool ShowBreakSymbol { get; set; }
    bool ShowDimensionLine { get; set; }
    double Spacing { get; set; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    string Suffix { get; set; }
    TextStyle TextStyle { get; set; }
    Tolerance Tolerance { get; }
    bool ToleranceAlternateIncludedZeroDisplay { get; set; }
    bool ToleranceAlternateLeadingZeroDisplay { get; set; }
    bool ToleranceAlternateTrailingZeroDisplay { get; set; }
    int ToleranceAlternateUnitPrecision { get; set; }
    AngularPrecisionEnum ToleranceAngularPrecision { get; set; }
    double ToleranceFontSize { get; set; }
    bool ToleranceIncludedZeroDisplay { get; set; }
    VerticalTextAlignmentEnum ToleranceJustification { get; set; }
    bool ToleranceLeadingZeroDisplay { get; set; }
    int ToleranceLinearPrecision { get; set; }
    bool ToleranceShowMinuteSecond { get; set; }
    TextStyle ToleranceTextStyle { get; set; }
    bool ToleranceTrailingZeroDisplay { get; set; }
    DimensionZeroToleranceDisplayEnum ToleranceZeroToleranceDisplay { get; set; }
    bool TrailingZeroDisplay { get; set; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    bool UseCapitalXForEquallySpacedFeatures { get; set; } // since 2026
    DimensionTextOrientationEnum VerticalDimensionTextOrientation { get; set; }
    // Methods
    Style ConvertToLocal();
    Style Copy(string Name);
    void Delete();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void GetHoleThreadNoteOptionValue(string HoleThreadType, string OptionName, out object Value); // since 2025
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SaveToGlobal();
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    void SetHoleThreadNoteOptionValue(string HoleThreadType, string OptionName, object OptionValue, object ApplyToAll = Missing); // since 2025
    void UpdateFromGlobal();
}
```

14 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngularGeneralDimension](../objects/AngularGeneralDimension.md).Style, [BaselineDimensionSet](../objects/BaselineDimensionSet.md).Style, [BendNote](../objects/BendNote.md).DimensionStyle, [ChainDimensionSet](../objects/ChainDimensionSet.md).Style, [ChamferNote](../objects/ChamferNote.md).DimensionStyle, [DiameterGeneralDimension](../objects/DiameterGeneralDimension.md).Style, [DimensionStylesEnumerator](../objects/DimensionStylesEnumerator.md).Item, [GeneralDimension](../objects/GeneralDimension.md).Style, [HoleTag](../objects/HoleTag.md).DimensionStyle, [HoleThreadNote](../objects/HoleThreadNote.md).Style, [LeaderNote](../objects/LeaderNote.md).DimensionStyle, [LinearGeneralDimension](../objects/LinearGeneralDimension.md).Style, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).AngularDimensionStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).BaselineDimensionStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).BendNoteStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).BendTagStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).ChainDimensionStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).ChamferNoteStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).DiameterDimensionStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).HoleNoteStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).HoleTagStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).LeaderTextStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).LinearDimensionStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).OrdinateDimensionStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).OrdinateSetDimensionStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).PunchNoteStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).RadialDimensionStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).ThreadNoteStyle, [OrdinateDimension](../objects/OrdinateDimension.md).Style, [OrdinateDimensionSet](../objects/OrdinateDimensionSet.md).Style, [PunchNote](../objects/PunchNote.md).DimensionStyle, [RadiusGeneralDimension](../objects/RadiusGeneralDimension.md).Style

**Referenced types:** [AngularPrecisionEnum](../enums/AngularPrecisionEnum.md), [ArrowheadTypeEnum](../enums/ArrowheadTypeEnum.md), [Color](../objects/Color.md), [DecimalMarkerTypeEnum](../enums/DecimalMarkerTypeEnum.md), [DimensionStyleFormatEnum](../enums/DimensionStyleFormatEnum.md), [DimensionTextModifierEnum](../enums/DimensionTextModifierEnum.md), [DimensionTextOrientationEnum](../enums/DimensionTextOrientationEnum.md), [DimensionZeroToleranceDisplayEnum](../enums/DimensionZeroToleranceDisplayEnum.md), [DisplayFormatEnum](../enums/DisplayFormatEnum.md), [LeaderStyle](../objects/LeaderStyle.md), [LineTypeEnum](../enums/LineTypeEnum.md), [LinearPrecisionEnum](../enums/LinearPrecisionEnum.md), [MultiLineDimensionTextEnum](../enums/MultiLineDimensionTextEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OrdinateDimensionAlignmentEnum](../enums/OrdinateDimensionAlignmentEnum.md), [PrefixAndSuffixOrderEnum](../enums/PrefixAndSuffixOrderEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [TextStyle](../objects/TextStyle.md), [Tolerance](../objects/Tolerance.md), [UnitsTypeEnum](../enums/UnitsTypeEnum.md), [VerticalTextAlignmentEnum](../enums/VerticalTextAlignmentEnum.md)

