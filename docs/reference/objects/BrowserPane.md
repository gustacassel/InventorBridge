# BrowserPane

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.BrowserPanes.Item[…]`

```csharp
interface BrowserPane
{
    // Properties
    object Application { get; }
    bool BuiltIn { get; }
    object Control { get; }
    bool Default { get; set; }
    string InternalName { get; }
    string Name { get; set; }
    Document Parent { get; }
    SearchBox SearchBox { get; }
    BrowserNode TopNode { get; }
    bool TreeBrowser { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Activate();
    BrowserFolder AddBrowserFolder(string Name = "", object BrowserNodes = Missing);
    BrowserFolder AddBrowserFolderWithOptions(string Name = "", object Options = Missing); // since 2027
    void ClearPreSelect();
    void Delete();
    BrowserNode GetBrowserNodeFromObject(object NativeObject);
    void GetDockingState(out DockingStateEnum DockingState, out object DockToObject);
    void Refresh();
    void Reorder(BrowserNode TargetNode, bool Before, BrowserNode StartNode, object EndNode = Missing);
    void SetDockingState(DockingStateEnum DockingState, object DockToObject = Missing);
    void Update();
    // Events
    event OnActivate();
    event OnDeactivate();
    event OnHelp(EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BrowserPanes](../objects/BrowserPanes.md).ActivePane, [BrowserPanes](../objects/BrowserPanes.md).Add, [BrowserPanes](../objects/BrowserPanes.md).AddByManifest, [BrowserPanes](../objects/BrowserPanes.md).AddTreeBrowserPane, [BrowserPanes](../objects/BrowserPanes.md).Item, [SearchBox](../objects/SearchBox.md).Parent

**Referenced types:** [BrowserFolder](../objects/BrowserFolder.md), [BrowserNode](../objects/BrowserNode.md), [DockingStateEnum](../enums/DockingStateEnum.md), [Document](../objects/Document.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SearchBox](../objects/SearchBox.md)

