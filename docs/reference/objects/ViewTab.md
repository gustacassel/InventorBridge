# ViewTab

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.Views.Item[…].ViewTab`

```csharp
interface ViewTab
{
    // Properties
    object Application { get; }
    ObjectTypeEnum Type { get; }
    object View { get; }
    ViewFrame ViewFrame { get; }
    ViewTabGroup ViewTabGroup { get; }
    // Methods
    void Close();
    ViewTabGroup MoveToGroup(bool CreateNewGroup, ViewTab TargetViewTab, DockingStateEnum DockingState, object AdditionalViewTabs = Missing);
    ViewFrame MoveToNewViewFrame(object ViewFrameWidth = Missing, object ViewFrameHeight = Missing, object ViewFrameLeft = Missing, object ViewFrameTop = Missing, object AdditionalViewTabs = Missing);
}
```

**Returned by:** [View](../objects/View.md).ViewTab, [ViewTabGroup](../objects/ViewTabGroup.md).Item, [ViewTabsEnumerator](../objects/ViewTabsEnumerator.md).Item

**Referenced types:** [DockingStateEnum](../enums/DockingStateEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ViewFrame](../objects/ViewFrame.md), [ViewTabGroup](../objects/ViewTabGroup.md)

