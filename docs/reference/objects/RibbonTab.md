# RibbonTab

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.Ribbons.Item[…].RibbonTabs.Item[…]`

```csharp
interface RibbonTab
{
    // Properties
    bool Active { get; set; }
    Application Application { get; }
    string ClientId { get; }
    bool Contextual { get; set; }
    string DisplayName { get; }
    string InternalName { get; }
    string KeyTip { get; set; }
    Ribbon Parent { get; }
    RibbonPanels RibbonPanels { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete();
}
```

**Returned by:** [RibbonPanel](../objects/RibbonPanel.md).Parent, [RibbonTabs](../objects/RibbonTabs.md).Add, [RibbonTabs](../objects/RibbonTabs.md).Item

**Referenced types:** [Application](../objects/Application.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Ribbon](../objects/Ribbon.md), [RibbonPanels](../objects/RibbonPanels.md)

