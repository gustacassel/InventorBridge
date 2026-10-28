# RibbonTabs

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.Ribbons.Item[…].RibbonTabs`

```csharp
interface RibbonTabs
{
    // Properties
    Application Application { get; }
    int Count { get; }
    RibbonTab Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RibbonTab Add(string DisplayName, string InternalName, string ClientId, string TargetTabInternalName = "", bool InsertBeforeTargetTab = false, bool Contextual = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Ribbon](../objects/Ribbon.md).RibbonTabs

**Referenced types:** [Application](../objects/Application.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RibbonTab](../objects/RibbonTab.md)

