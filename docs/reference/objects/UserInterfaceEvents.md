# UserInterfaceEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.UserInterfaceEvents`

```csharp
interface UserInterfaceEvents
{
    // Properties
    Application Application { get; }
    UserInterfaceManager Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnEnvironmentChange(Environment Environment, EnvironmentStateEnum EnvironmentState, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnResetCommandBars(ObjectsEnumerator CommandBars, NameValueMap Context);
    event OnResetEnvironments(ObjectsEnumerator Environments, NameValueMap Context);
    event OnResetInventorLayout(NameValueMap Context);
    event OnResetMarkingMenu(string MarkingMenuInternalName, NameValueMap Context);
    event OnResetRibbonInterface(NameValueMap Context);
    event OnResetShortcuts(NameValueMap Context);
}
```

**Returned by:** [UserInterfaceManager](../objects/UserInterfaceManager.md).UserInterfaceEvents

**Referenced types:** [Application](../objects/Application.md), [Environment](../objects/Environment.md), [EnvironmentStateEnum](../enums/EnvironmentStateEnum.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [UserInterfaceManager](../objects/UserInterfaceManager.md)

