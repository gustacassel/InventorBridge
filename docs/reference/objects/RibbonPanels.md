# RibbonPanels

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.Ribbons.Item[…].RibbonTabs.Item[…].RibbonPanels`

```csharp
interface RibbonPanels
{
    // Properties
    Application Application { get; }
    int Count { get; }
    RibbonPanel Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RibbonPanel Add(string DisplayName, string InternalName, string ClientId, string TargetPanelInternalName = "", bool InsertBeforeTargetPanel = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [RibbonTab](../objects/RibbonTab.md).RibbonPanels

**Referenced types:** [Application](../objects/Application.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RibbonPanel](../objects/RibbonPanel.md)

