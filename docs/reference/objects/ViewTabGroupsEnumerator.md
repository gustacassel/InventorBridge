# ViewTabGroupsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ViewFrames.Item[…].ViewTabGroups`

```csharp
interface ViewTabGroupsEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    ViewTabGroup Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ViewFrame](../objects/ViewFrame.md).ViewTabGroups

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ViewTabGroup](../objects/ViewTabGroup.md)

