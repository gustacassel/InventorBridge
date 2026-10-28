# PanelBar

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PanelBar
{
    // Properties
    Application Application { get; }
    CommandBarList CommandBarList { get; }
    CommandBar CurrentCommandBar { get; set; }
    CommandBar DefaultCommandBar { get; set; }
    Environment Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnCommandBarSelection(CommandBar CommandBarObject, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Referenced types:** [Application](../objects/Application.md), [Environment](../objects/Environment.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

