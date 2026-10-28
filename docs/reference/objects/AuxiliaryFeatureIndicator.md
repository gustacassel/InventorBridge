# AuxiliaryFeatureIndicator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.FeatureControlFrames.Item[…].FeatureControlFrameRows.Item[…].AuxiliaryFeatureIndicators.Item[…]`

```csharp
interface AuxiliaryFeatureIndicator
{
    // Properties
    Application Application { get; }
    string FieldOneText { get; set; }
    string FieldTwoText { get; set; }
    FeatureControlFrame Parent { get; }
    AuxiliaryFeatureIndicatorSymbolTypeEnum SymbolType { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [AuxiliaryFeatureIndicators](../objects/AuxiliaryFeatureIndicators.md).Add, [AuxiliaryFeatureIndicators](../objects/AuxiliaryFeatureIndicators.md).Item

**Referenced types:** [Application](../objects/Application.md), [AuxiliaryFeatureIndicatorSymbolTypeEnum](../enums/AuxiliaryFeatureIndicatorSymbolTypeEnum.md), [FeatureControlFrame](../objects/FeatureControlFrame.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

