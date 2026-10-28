# FeatureControlFrameRows

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.FeatureControlFrames.Item[…].FeatureControlFrameRows`

```csharp
interface FeatureControlFrameRows
{
    // Properties
    object Application { get; }
    int Count { get; }
    FeatureControlFrameRow Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    FeatureControlFrameRow Add(GeometricCharacteristicEnum GeometricCharacteristic, string Tolerance, string LowerTolerance = "", string DatumOne = "", string DatumTwo = "", string DatumThree = "");
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FeatureControlFrame](../objects/FeatureControlFrame.md).FeatureControlFrameRows, [FeatureControlFrames](../objects/FeatureControlFrames.md).CreateFeatureControlFrameRows

**Referenced types:** [FeatureControlFrameRow](../objects/FeatureControlFrameRow.md), [GeometricCharacteristicEnum](../enums/GeometricCharacteristicEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

