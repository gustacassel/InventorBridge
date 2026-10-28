# GeneralDimensionsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingDimensions.ChainDimensionSets.Item[…].Members`

```csharp
interface GeneralDimensionsEnumerator
{
    // Properties
    int Count { get; }
    GeneralDimension Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BaselineDimensionSet](../objects/BaselineDimensionSet.md).Members, [ChainDimensionSet](../objects/ChainDimensionSet.md).AddMembers, [ChainDimensionSet](../objects/ChainDimensionSet.md).Members

**Referenced types:** [GeneralDimension](../objects/GeneralDimension.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

