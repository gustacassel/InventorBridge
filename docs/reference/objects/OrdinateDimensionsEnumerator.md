# OrdinateDimensionsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.DrawingDimensions.OrdinateDimensionSets.Item[…].Members`

```csharp
interface OrdinateDimensionsEnumerator
{
    // Properties
    int Count { get; }
    OrdinateDimension Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [OrdinateDimensionSet](../objects/OrdinateDimensionSet.md).Members

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OrdinateDimension](../objects/OrdinateDimension.md)

