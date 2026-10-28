# DrawingDimension

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingDimensions.Item[…]`

```csharp
interface DrawingDimension
{
    // Properties
    object Application { get; }
    bool Attached { get; }
    AttributeSets AttributeSets { get; }
    object DimensionLine { get; }
    bool HideValue { get; set; }
    bool IsInspectionDimension { get; set; }
    Layer Layer { get; set; }
    double ModelValue { get; }
    bool ModelValueOverridden { get; set; }
    double OverrideModelValue { get; set; }
    Sheet Parent { get; }
    int Precision { get; set; }
    DimensionText Text { get; set; }
    Tolerance Tolerance { get; }
    int TolerancePrecision { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetInspectionDimensionData(out InspectionDimensionShapeEnum Shape, out string Label, out string Rate);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetInspectionDimensionData(InspectionDimensionShapeEnum Shape = InspectionDimensionShapeEnum.kNoInspectionBorder, string Label = "", string Rate = "");
}
```

**Returned by:** [DimensionText](../objects/DimensionText.md).Parent, [DrawingDimensions](../objects/DrawingDimensions.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [DimensionText](../objects/DimensionText.md), [InspectionDimensionShapeEnum](../enums/InspectionDimensionShapeEnum.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sheet](../objects/Sheet.md), [Tolerance](../objects/Tolerance.md)

