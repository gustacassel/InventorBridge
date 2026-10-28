# PartsListRows

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.PartsLists.Item[…].PartsListRows`

```csharp
interface PartsListRows
{
    // Properties
    object Application { get; }
    int Count { get; }
    PartsListRow Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    PartsListRow Add(int TargetIndex = 0, bool InsertBefore = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartsList](../objects/PartsList.md).PartsListRows

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartsListRow](../objects/PartsListRow.md)

