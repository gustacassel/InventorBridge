# RadiusGeneralDimension

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GeneralDimension](../objects/GeneralDimension.md) → [DrawingDimension](../objects/DrawingDimension.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingDimensions.GeneralDimensions.Item[…] → (RadiusGeneralDimension)`

```csharp
interface RadiusGeneralDimension
{
    // Properties
    object Application { get; }
    bool ArrowheadsInside { get; set; }
    bool Attached { get; }
    AttributeSets AttributeSets { get; }
    object DimensionLine { get; }
    bool FirstArrowheadInside { get; set; }
    ArrowheadTypeEnum FirstArrowheadType { get; set; }
    GeneralDimensionTypeEnum GeneralDimensionType { get; }
    bool HideValue { get; set; }
    GeometryIntent Intent { get; set; }
    bool IsInspectionDimension { get; set; }
    bool Jogged { get; set; }
    Layer Layer { get; set; }
    bool LeaderFromCenter { get; set; }
    double ModelValue { get; }
    bool ModelValueOverridden { get; set; }
    double OverrideModelValue { get; set; }
    Sheet Parent { get; }
    int Precision { get; set; }
    bool Retrieved { get; }
    object RetrievedFrom { get; }
    bool SecondArrowheadInside { get; set; }
    ArrowheadTypeEnum SecondArrowheadType { get; set; }
    DimensionStyle Style { get; set; }
    DimensionText Text { get; set; }
    Tolerance Tolerance { get; }
    int TolerancePrecision { get; set; }
    ObjectTypeEnum Type { get; }
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

**Returned by:** [GeneralDimensions](../objects/GeneralDimensions.md).AddRadius

**Referenced types:** [ArrowheadTypeEnum](../enums/ArrowheadTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [DimensionConstraint](../objects/DimensionConstraint.md), [DimensionStyle](../objects/DimensionStyle.md), [DimensionText](../objects/DimensionText.md), [GeneralDimensionTypeEnum](../enums/GeneralDimensionTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [InspectionDimensionShapeEnum](../enums/InspectionDimensionShapeEnum.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sheet](../objects/Sheet.md), [Tolerance](../objects/Tolerance.md)

