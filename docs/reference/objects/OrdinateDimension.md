# OrdinateDimension

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [DrawingDimension](../objects/DrawingDimension.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingDimensions.OrdinateDimensions.Item[…]`

```csharp
interface OrdinateDimension
{
    // Properties
    object Application { get; }
    bool Attached { get; }
    AttributeSets AttributeSets { get; }
    object DimensionLine { get; }
    DimensionTypeEnum DimensionType { get; }
    bool HideValue { get; set; }
    GeometryIntent Intent { get; set; }
    bool IsInspectionDimension { get; set; }
    bool IsOrdinateSetMember { get; }
    Point2d JogPointOne { get; set; }
    Point2d JogPointTwo { get; set; }
    Layer Layer { get; set; }
    double ModelValue { get; }
    bool ModelValueOverridden { get; set; }
    OrdinateDimensionSet OrdinateDimensionSet { get; }
    double OverrideModelValue { get; set; }
    Sheet Parent { get; }
    int Precision { get; set; }
    DimensionStyle Style { get; set; }
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

**Returned by:** [OrdinateDimensionSet](../objects/OrdinateDimensionSet.md).AddMember, [OrdinateDimensionSet](../objects/OrdinateDimensionSet.md).OriginMember, [OrdinateDimensions](../objects/OrdinateDimensions.md).Add, [OrdinateDimensions](../objects/OrdinateDimensions.md).Item, [OrdinateDimensionsEnumerator](../objects/OrdinateDimensionsEnumerator.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [DimensionStyle](../objects/DimensionStyle.md), [DimensionText](../objects/DimensionText.md), [DimensionTypeEnum](../enums/DimensionTypeEnum.md), [GeometryIntent](../objects/GeometryIntent.md), [InspectionDimensionShapeEnum](../enums/InspectionDimensionShapeEnum.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OrdinateDimensionSet](../objects/OrdinateDimensionSet.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md), [Tolerance](../objects/Tolerance.md)

