# HoleThreadNote

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [DiameterGeneralDimension](../objects/DiameterGeneralDimension.md) → [GeneralDimension](../objects/GeneralDimension.md) → [DrawingDimension](../objects/DrawingDimension.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingNotes.HoleThreadNotes.Item[…]`

```csharp
interface HoleThreadNote
{
    // Properties
    object Application { get; }
    bool ArrowheadsInside { get; set; }
    bool Attached { get; }
    AttributeSets AttributeSets { get; }
    object DimensionLine { get; }
    object Edge { get; set; }
    object ExtensionLineOne { get; }
    object ExtensionLineTwo { get; }
    bool FirstArrowheadInside { get; set; }
    ArrowheadTypeEnum FirstArrowheadType { get; set; }
    string FormattedHoleThreadNote { get; set; }
    string FormattedQuantityNote { get; set; }
    GeneralDimensionTypeEnum GeneralDimensionType { get; }
    bool HideValue { get; set; }
    GeometryIntent Intent { get; set; }
    bool IsHoleNote { get; }
    bool IsInspectionDimension { get; set; }
    Layer Layer { get; set; }
    bool LeaderFromCenter { get; set; }
    double ModelValue { get; }
    bool ModelValueOverridden { get; set; }
    double OverrideModelValue { get; set; }
    Sheet Parent { get; }
    int Precision { get; set; }
    HoleNoteQuantityEnum QuantityDefinition { get; set; }
    bool Retrieved { get; }
    object RetrievedFrom { get; }
    bool RightHandedThread { get; set; } // since 2025
    bool SecondArrowheadInside { get; set; }
    ArrowheadTypeEnum SecondArrowheadType { get; set; }
    bool SingleDimensionLine { get; set; }
    DimensionStyle Style { get; set; }
    bool TapDrill { get; set; }
    DimensionText Text { get; set; }
    Tolerance Tolerance { get; }
    int TolerancePrecision { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseCustomThreadDesignation { get; set; }
    bool UseDefaultFormat { get; set; }
    bool UsePartUnits { get; set; }
    // Methods
    void Delete();
    void GetInspectionDimensionData(out InspectionDimensionShapeEnum Shape, out string Label, out string Rate);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    DimensionConstraint PromoteToSketch();
    void SetInspectionDimensionData(InspectionDimensionShapeEnum Shape = InspectionDimensionShapeEnum.kNoInspectionBorder, string Label = "", string Rate = "");
    void ShowAllExtensionLines();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [HoleThreadNotes](../objects/HoleThreadNotes.md).Add, [HoleThreadNotes](../objects/HoleThreadNotes.md).Item

**Referenced types:** [ArrowheadTypeEnum](../enums/ArrowheadTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [DimensionConstraint](../objects/DimensionConstraint.md), [DimensionStyle](../objects/DimensionStyle.md), [DimensionText](../objects/DimensionText.md), [GeneralDimensionTypeEnum](../enums/GeneralDimensionTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [HoleNoteQuantityEnum](../enums/HoleNoteQuantityEnum.md), [InspectionDimensionShapeEnum](../enums/InspectionDimensionShapeEnum.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sheet](../objects/Sheet.md), [Tolerance](../objects/Tolerance.md)

