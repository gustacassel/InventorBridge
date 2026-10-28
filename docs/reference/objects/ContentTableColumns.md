# ContentTableColumns

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ContentCenter.TreeViewTopNode.Families.Item[…].TableColumns`

```csharp
interface ContentTableColumns
{
    // Properties
    object Application { get; }
    int Count { get; }
    ContentTableColumn Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ContentTableColumn Add(string InternalName, string DisplayHeading, ValueTypeEnum DataType, object Units = Missing, object Expression = Missing, object PropertySetId = Missing, object PropertyIdentifier = Missing);
    ExpressionLimits CreateExpressionLimits();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ContentFamily](../objects/ContentFamily.md).TableColumns

**Referenced types:** [ContentTableColumn](../objects/ContentTableColumn.md), [ExpressionLimits](../objects/ExpressionLimits.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ValueTypeEnum](../enums/ValueTypeEnum.md)

