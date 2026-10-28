# ViewFrame

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ViewFrames.Item[…]`

```csharp
interface ViewFrame
{
    // Properties
    Application Application { get; }
    string Caption { get; }
    int Height { get; set; }
    bool IsDefault { get; }
    int Left { get; }
    Application Parent { get; }
    int Top { get; }
    ObjectTypeEnum Type { get; }
    ViewTabGroupsEnumerator ViewTabGroups { get; }
    ViewTabsEnumerator ViewTabs { get; }
    int Width { get; set; }
    WindowsSizeEnum WindowState { get; set; }
    // Methods
    void Arrange(ViewTileTypeEnum Value = ViewTileTypeEnum.kArrangeViewTileType);
    void Close();
    void Close2(bool SaveDocuments = false, object DocumentsToSave = Missing);
    void Move(ref int Top, ref int Left, ref int Height, ref int Width);
    void RestorePreviousLayout();
}
```

**Returned by:** [Application](../objects/Application.md).ActiveViewFrame, [View](../objects/View.md).ViewFrame, [ViewFramesEnumerator](../objects/ViewFramesEnumerator.md).Item, [ViewTab](../objects/ViewTab.md).MoveToNewViewFrame, [ViewTab](../objects/ViewTab.md).ViewFrame, [ViewTabGroup](../objects/ViewTabGroup.md).MoveToNewViewFrame, [ViewTabGroup](../objects/ViewTabGroup.md).ViewFrame

**Referenced types:** [Application](../objects/Application.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ViewTabGroupsEnumerator](../objects/ViewTabGroupsEnumerator.md), [ViewTabsEnumerator](../objects/ViewTabsEnumerator.md), [ViewTileTypeEnum](../enums/ViewTileTypeEnum.md), [WindowsSizeEnum](../enums/WindowsSizeEnum.md)

