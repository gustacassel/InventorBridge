# ChainDimensionSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingDimensions.ChainDimensionSets.Item[…]`

```csharp
interface ChainDimensionSet
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    DimensionTypeEnum DimensionType { get; }
    Layer Layer { get; set; }
    bool Locked { get; set; }
    GeneralDimensionsEnumerator Members { get; }
    Sheet Parent { get; }
    int Precision { get; set; }
    DimensionStyle Style { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    GeneralDimensionsEnumerator AddMembers(object DimensionOrGeometry);
    void Arrange(LinearGeneralDimension BaseDimension);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void MergeMembers(LinearGeneralDimension MemberOne, LinearGeneralDimension MemberTwo);
}
```

**Returned by:** [ChainDimensionSets](../objects/ChainDimensionSets.md).Add, [ChainDimensionSets](../objects/ChainDimensionSets.md).AddUsingBaseDimension, [ChainDimensionSets](../objects/ChainDimensionSets.md).Item, [LinearGeneralDimension](../objects/LinearGeneralDimension.md).ChainDimensionSet

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [DimensionStyle](../objects/DimensionStyle.md), [DimensionTypeEnum](../enums/DimensionTypeEnum.md), [GeneralDimensionsEnumerator](../objects/GeneralDimensionsEnumerator.md), [Layer](../objects/Layer.md), [LinearGeneralDimension](../objects/LinearGeneralDimension.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sheet](../objects/Sheet.md)

