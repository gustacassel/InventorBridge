# HoleTableRows

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.HoleTables.Item[…].HoleTableRows`

```csharp
interface HoleTableRows
{
    // Properties
    object Application { get; }
    int Count { get; }
    HoleTableRow Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    HoleTableRow Add(object Hole);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [HoleTable](../objects/HoleTable.md).HoleTableRows

**Referenced types:** [HoleTableRow](../objects/HoleTableRow.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

