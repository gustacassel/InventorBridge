# LinearGeneralDimension

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GeneralDimension](../objects/GeneralDimension.md) → [DrawingDimension](../objects/DrawingDimension.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingDimensions.GeneralDimensions.Item[…] → (LinearGeneralDimension)`

```csharp
interface LinearGeneralDimension
{
    // Properties
    object AlignmentGeometry { get; }
    object Application { get; }
    bool ArrowheadsInside { get; set; }
    bool Attached { get; }
    AttributeSets AttributeSets { get; }
    BaselineDimensionSet BaselineDimensionSet { get; }
    ChainDimensionSet ChainDimensionSet { get; }
    object DimensionLine { get; }
    DimensionTypeEnum DimensionType { get; }
    object ExtensionLineOne { get; }
    bool ExtensionLineOneVisible { get; set; }
    object ExtensionLineTwo { get; }
    bool ExtensionLineTwoVisible { get; set; }
    bool FirstArrowheadInside { get; set; }
    ArrowheadTypeEnum FirstArrowheadType { get; set; }
    bool FullDimensionLine { get; set; }
    GeneralDimensionTypeEnum GeneralDimensionType { get; }
    bool HideSecondArrowhead { get; set; }
    bool HideValue { get; set; }
    GeometryIntent IntentOne { get; set; }
    GeometryIntent IntentThree { get; set; }
    GeometryIntent IntentTwo { get; set; }
    bool IsBaselineSetMember { get; }
    bool IsChainSetMember { get; }
    bool IsInspectionDimension { get; set; }
    Layer Layer { get; set; }
    double ModelValue { get; }
    bool ModelValueOverridden { get; set; }
    double OverrideModelValue { get; set; }
    Sheet Parent { get; }
    int Precision { get; set; }
    bool Retrieved { get; }
    object RetrievedFrom { get; }
    bool SecondArrowheadInside { get; set; }
    Point2d SecondArrowheadPosition { get; set; }
    ArrowheadTypeEnum SecondArrowheadType { get; set; }
    bool ShowLeader { get; set; }
    LinearGeneralDimension SpacingDimension { get; set; } // since 2026
    DimensionStyle Style { get; set; }
    DimensionText Text { get; set; }
    Tolerance Tolerance { get; }
    int TolerancePrecision { get; set; }
    ObjectTypeEnum Type { get; }
    GeometryIntent VirtualArcPosition { get; set; }
    // Methods
    void CenterText();
    void Delete();
    void GetInspectionDimensionData(out InspectionDimensionShapeEnum Shape, out string Label, out string Rate);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    DimensionConstraint PromoteToSketch();
    void SetInspectionDimensionData(InspectionDimensionShapeEnum Shape = InspectionDimensionShapeEnum.kNoInspectionBorder, string Label = "", string Rate = "");
    void ShowAllExtensionLines();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BaselineDimensionSet](../objects/BaselineDimensionSet.md).AddMember, [GeneralDimensions](../objects/GeneralDimensions.md).AddArcLengthForeshortened, [GeneralDimensions](../objects/GeneralDimensions.md).AddLinear, [GeneralDimensions](../objects/GeneralDimensions.md).AddLinear2, [GeneralDimensions](../objects/GeneralDimensions.md).AddLinearForeshortened, [GeneralDimensions](../objects/GeneralDimensions.md).AddLinearSum, [LinearGeneralDimension](../objects/LinearGeneralDimension.md).SpacingDimension

**Referenced types:** [ArrowheadTypeEnum](../enums/ArrowheadTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [BaselineDimensionSet](../objects/BaselineDimensionSet.md), [ChainDimensionSet](../objects/ChainDimensionSet.md), [DimensionConstraint](../objects/DimensionConstraint.md), [DimensionStyle](../objects/DimensionStyle.md), [DimensionText](../objects/DimensionText.md), [DimensionTypeEnum](../enums/DimensionTypeEnum.md), [GeneralDimensionTypeEnum](../enums/GeneralDimensionTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [InspectionDimensionShapeEnum](../enums/InspectionDimensionShapeEnum.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md), [Tolerance](../objects/Tolerance.md)

