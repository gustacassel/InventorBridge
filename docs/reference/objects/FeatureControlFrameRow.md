# FeatureControlFrameRow

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.FeatureControlFrames.Item[…].FeatureControlFrameRows.Item[…]`

```csharp
interface FeatureControlFrameRow
{
    // Properties
    object Application { get; }
    AuxiliaryFeatureIndicators AuxiliaryFeatureIndicators { get; }
    string DatumOne { get; set; }
    string DatumThree { get; set; }
    string DatumTwo { get; set; }
    GeometricCharacteristicEnum GeometricCharacteristic { get; set; }
    string InlineNote { get; set; }
    string LowerTolerance { get; set; }
    FeatureControlFrame Parent { get; }
    string Tolerance { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [FeatureControlFrameRows](../objects/FeatureControlFrameRows.md).Add, [FeatureControlFrameRows](../objects/FeatureControlFrameRows.md).Item

**Referenced types:** [AuxiliaryFeatureIndicators](../objects/AuxiliaryFeatureIndicators.md), [FeatureControlFrame](../objects/FeatureControlFrame.md), [GeometricCharacteristicEnum](../enums/GeometricCharacteristicEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

