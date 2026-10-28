# DockableWindows

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.DockableWindows`

```csharp
interface DockableWindows
{
    // Properties
    object Application { get; }
    int Count { get; }
    DockableWindowsEvents Events { get; }
    DockableWindow Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DockableWindow Add(string ClientId, string InternalName, string Caption);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DockableWindowsEvents](../objects/DockableWindowsEvents.md).Parent, [UserInterfaceManager](../objects/UserInterfaceManager.md).DockableWindows

**Referenced types:** [DockableWindow](../objects/DockableWindow.md), [DockableWindowsEvents](../objects/DockableWindowsEvents.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

