# CustomPropertyFormat

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.Item[…].CustomPropertyFormat`

```csharp
interface CustomPropertyFormat
{
    // Properties
    object Application { get; }
    Parameter Parent { get; }
    CustomPropertyPrecisionEnum Precision { get; set; }
    CustomPropertyTypeEnum PropertyType { get; set; }
    bool ShowLeadingZeros { get; set; }
    bool ShowTrailingZeros { get; set; }
    bool ShowUnitsString { get; set; }
    ObjectTypeEnum Type { get; }
    string Units { get; set; }
}
```

**Returned by:** [DerivedParameter](../objects/DerivedParameter.md).CustomPropertyFormat, [FinishParameter](../objects/FinishParameter.md).CustomPropertyFormat, [ModelParameter](../objects/ModelParameter.md).CustomPropertyFormat, [Parameter](../objects/Parameter.md).CustomPropertyFormat, [ReferenceParameter](../objects/ReferenceParameter.md).CustomPropertyFormat, [TableParameter](../objects/TableParameter.md).CustomPropertyFormat, [UserParameter](../objects/UserParameter.md).CustomPropertyFormat

**Referenced types:** [CustomPropertyPrecisionEnum](../enums/CustomPropertyPrecisionEnum.md), [CustomPropertyTypeEnum](../enums/CustomPropertyTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md)

