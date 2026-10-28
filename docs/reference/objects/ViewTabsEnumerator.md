# ViewTabsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ViewFrames.Item[…].ViewTabs`

```csharp
interface ViewTabsEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    ViewTab Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ViewFrame](../objects/ViewFrame.md).ViewTabs

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ViewTab](../objects/ViewTab.md)

