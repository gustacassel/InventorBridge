# AuxiliaryFeatureIndicators

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.FeatureControlFrames.Item[…].FeatureControlFrameRows.Item[…].AuxiliaryFeatureIndicators`

```csharp
interface AuxiliaryFeatureIndicators
{
    // Properties
    Application Application { get; }
    int Count { get; }
    AuxiliaryFeatureIndicator Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    AuxiliaryFeatureIndicator Add(AuxiliaryFeatureIndicatorSymbolTypeEnum SymbolType, string FieldOneText = "", string FieldTwoText = "");
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FeatureControlFrameRow](../objects/FeatureControlFrameRow.md).AuxiliaryFeatureIndicators

**Referenced types:** [Application](../objects/Application.md), [AuxiliaryFeatureIndicator](../objects/AuxiliaryFeatureIndicator.md), [AuxiliaryFeatureIndicatorSymbolTypeEnum](../enums/AuxiliaryFeatureIndicatorSymbolTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

