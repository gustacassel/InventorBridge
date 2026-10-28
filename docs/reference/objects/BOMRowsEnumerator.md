# BOMRowsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.BOM.BOMViews.Item[…].BOMRows`

```csharp
interface BOMRowsEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    BOMRow Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BOMRow](../objects/BOMRow.md).ChildRows, [BOMView](../objects/BOMView.md).BOMRows

**Referenced types:** [BOMRow](../objects/BOMRow.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

