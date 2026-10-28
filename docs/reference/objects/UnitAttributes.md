# UnitAttributes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingNotes.BendNotes.Item[…].UnitAttributes`

```csharp
interface UnitAttributes
{
    // Properties
    DecimalMarkerTypeEnum AlternateDecimalMarkerType { get; set; }
    bool AlternateLeadingZerosDisplay { get; set; }
    LinearPrecisionEnum AlternateLinearPrecision { get; set; }
    UnitsTypeEnum AlternateLinearUnits { get; set; }
    bool AlternateTrailingZerosDisplay { get; set; }
    bool AlternateUnitTypeDisplay { get; set; }
    bool AlternateUnitsDisplay { get; set; }
    object Application { get; }
    DimensionStyleFormatEnum DisplayStyleProp { get; set; }
    object Parent { get; }
    DecimalMarkerTypeEnum PrimaryDecimalMarkerType { get; set; }
    bool PrimaryLeadingZerosDisplay { get; set; }
    UnitsTypeEnum PrimaryLinearUnits { get; set; }
    bool PrimaryTrailingZerosDisplay { get; set; }
    bool PrimaryUnitTypeDisplay { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseStandardsNotation { get; set; }
}
```

**Returned by:** [BendNote](../objects/BendNote.md).UnitAttributes, [ChamferNote](../objects/ChamferNote.md).UnitAttributes, [GeneralNote](../objects/GeneralNote.md).UnitAttributes, [LeaderNote](../objects/LeaderNote.md).UnitAttributes, [PunchNote](../objects/PunchNote.md).UnitAttributes

**Referenced types:** [DecimalMarkerTypeEnum](../enums/DecimalMarkerTypeEnum.md), [DimensionStyleFormatEnum](../enums/DimensionStyleFormatEnum.md), [LinearPrecisionEnum](../enums/LinearPrecisionEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [UnitsTypeEnum](../enums/UnitsTypeEnum.md)

