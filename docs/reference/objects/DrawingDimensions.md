# DrawingDimensions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingDimensions`

```csharp
interface DrawingDimensions
{
    // Properties
    object Application { get; }
    BaselineDimensionSets BaselineDimensionSets { get; }
    ChainDimensionSets ChainDimensionSets { get; }
    int Count { get; }
    GeneralDimensions GeneralDimensions { get; }
    DrawingDimension Item[int Index] { get; }
    OrdinateDimensionSets OrdinateDimensionSets { get; }
    OrdinateDimensions OrdinateDimensions { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Arrange(ObjectCollection DrawingDimensions, object ContourEntity = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).DrawingDimensions

**Referenced types:** [BaselineDimensionSets](../objects/BaselineDimensionSets.md), [ChainDimensionSets](../objects/ChainDimensionSets.md), [DrawingDimension](../objects/DrawingDimension.md), [GeneralDimensions](../objects/GeneralDimensions.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OrdinateDimensionSets](../objects/OrdinateDimensionSets.md), [OrdinateDimensions](../objects/OrdinateDimensions.md)

