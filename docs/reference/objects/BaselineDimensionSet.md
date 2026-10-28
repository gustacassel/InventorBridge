# BaselineDimensionSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingDimensions.BaselineDimensionSets.Item[…]`

```csharp
interface BaselineDimensionSet
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    DimensionTypeEnum DimensionType { get; }
    Layer Layer { get; set; }
    GeneralDimensionsEnumerator Members { get; }
    GeometryIntent Origin { get; set; }
    Sheet Parent { get; }
    int Precision { get; set; }
    DimensionStyle Style { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    LinearGeneralDimension AddMember(object DimensionOrGeometry);
    void ArrangeText();
    void Delete();
    void DetachMember(LinearGeneralDimension Member);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [BaselineDimensionSets](../objects/BaselineDimensionSets.md).Add, [BaselineDimensionSets](../objects/BaselineDimensionSets.md).Item, [LinearGeneralDimension](../objects/LinearGeneralDimension.md).BaselineDimensionSet

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [DimensionStyle](../objects/DimensionStyle.md), [DimensionTypeEnum](../enums/DimensionTypeEnum.md), [GeneralDimensionsEnumerator](../objects/GeneralDimensionsEnumerator.md), [GeometryIntent](../objects/GeometryIntent.md), [Layer](../objects/Layer.md), [LinearGeneralDimension](../objects/LinearGeneralDimension.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sheet](../objects/Sheet.md)

