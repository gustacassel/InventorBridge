# ExpressionLimits

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ContentCenter.TreeViewTopNode.Families.Item[…].TableColumns.CreateExpressionLimits(…)`

```csharp
interface ExpressionLimits
{
    // Properties
    object Application { get; }
    string DefaultValue { get; set; }
    string IncrementValue { get; set; }
    string MaximumValue { get; set; }
    ComparisonTypeEnum MaximumValueComparisonType { get; set; }
    string MinimumValue { get; set; }
    ComparisonTypeEnum MinimumValueComparisonType { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [ContentTableColumns](../objects/ContentTableColumns.md).CreateExpressionLimits

**Referenced types:** [ComparisonTypeEnum](../enums/ComparisonTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

