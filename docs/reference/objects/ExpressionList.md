# ExpressionList

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.Item[…].ExpressionList`

```csharp
interface ExpressionList
{
    // Properties
    bool AllowCustomValues { get; set; }
    object Application { get; }
    int Count { get; }
    bool CustomOrder { get; set; }
    string Item[int Index] { get; }
    Parameter Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void ClearAll();
    string[] GetExpressionList();
    void SetExpressionList(ref string[] ExpressionList, bool ChangeCurrentValue = false, int CurrentValueIndex = -1);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedParameter](../objects/DerivedParameter.md).ExpressionList, [FinishParameter](../objects/FinishParameter.md).ExpressionList, [ModelParameter](../objects/ModelParameter.md).ExpressionList, [Parameter](../objects/Parameter.md).ExpressionList, [ReferenceParameter](../objects/ReferenceParameter.md).ExpressionList, [TableParameter](../objects/TableParameter.md).ExpressionList, [UserParameter](../objects/UserParameter.md).ExpressionList

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md)

