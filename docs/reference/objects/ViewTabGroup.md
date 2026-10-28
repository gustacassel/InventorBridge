# ViewTabGroup

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ViewFrames.Item[…].ViewTabGroups.Item[…]`

```csharp
interface ViewTabGroup
{
    // Properties
    object Application { get; }
    int Count { get; }
    ViewTab Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    ViewFrame ViewFrame { get; }
    // Methods
    void Close();
    ViewTabGroup MoveToGroup(ViewTab TargetViewTab, DockingStateEnum DockingState);
    ViewFrame MoveToNewViewFrame(object ViewFrameWidth = Missing, object ViewFrameHeight = Missing, object ViewFrameLeft = Missing, object ViewFrameTop = Missing);
}
```

**Returned by:** [ViewTab](../objects/ViewTab.md).MoveToGroup, [ViewTab](../objects/ViewTab.md).ViewTabGroup, [ViewTabGroup](../objects/ViewTabGroup.md).MoveToGroup, [ViewTabGroupsEnumerator](../objects/ViewTabGroupsEnumerator.md).Item

**Referenced types:** [DockingStateEnum](../enums/DockingStateEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ViewFrame](../objects/ViewFrame.md), [ViewTab](../objects/ViewTab.md)

