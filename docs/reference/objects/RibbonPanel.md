# RibbonPanel

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.Ribbons.Item[…].RibbonTabs.Item[…].RibbonPanels.Item[…]`

```csharp
interface RibbonPanel
{
    // Properties
    Application Application { get; }
    string ClientId { get; }
    CommandControls CommandControls { get; }
    string DisplayName { get; }
    bool Docked { get; set; }
    string InternalName { get; }
    RibbonTab Parent { get; }
    string SlideOutKeyTip { get; set; }
    CommandControls SlideoutControls { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete();
    void Move(int Top, int Left);
    void Reposition(string TargetPanelInternalName, bool InsertBeforeTargetPanel);
}
```

**Returned by:** [RibbonPanels](../objects/RibbonPanels.md).Add, [RibbonPanels](../objects/RibbonPanels.md).Item

**Referenced types:** [Application](../objects/Application.md), [CommandControls](../objects/CommandControls.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RibbonTab](../objects/RibbonTab.md)

