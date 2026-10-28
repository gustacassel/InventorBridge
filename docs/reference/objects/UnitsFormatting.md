# UnitsFormatting

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.HoleTables.Item[…].HoleTableColumns.Item[…].UnitsFormatting`

```csharp
interface UnitsFormatting
{
    // Properties
    object Application { get; }
    DecimalMarkerTypeEnum DecimalMarkerType { get; set; }
    DisplayFormatEnum DisplayFormat { get; set; }
    double FractionalTextScale { get; set; }
    object Parent { get; }
    CustomPropertyPrecisionEnum Precision { get; set; }
    bool ShowUnitString { get; set; }
    ObjectTypeEnum Type { get; }
    ValueUnitsTypeEnum UnitType { get; set; }
    UnitsTypeEnum Units { get; set; }
}
```

**Returned by:** [HoleTableColumn](../objects/HoleTableColumn.md).UnitsFormatting

**Referenced types:** [CustomPropertyPrecisionEnum](../enums/CustomPropertyPrecisionEnum.md), [DecimalMarkerTypeEnum](../enums/DecimalMarkerTypeEnum.md), [DisplayFormatEnum](../enums/DisplayFormatEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [UnitsTypeEnum](../enums/UnitsTypeEnum.md), [ValueUnitsTypeEnum](../enums/ValueUnitsTypeEnum.md)

