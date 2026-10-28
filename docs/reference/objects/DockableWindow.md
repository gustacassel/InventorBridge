# DockableWindow

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.UserInterfaceManager.DockableWindows.Item[…]`

```csharp
interface DockableWindow
{
    // Properties
    object Application { get; }
    string Caption { get; set; }
    string ClientId { get; }
    object Control { get; }
    bool DisableCloseButton { get; set; }
    DockingStateEnum DisabledDockingStates { get; set; }
    int HWND { get; }
    int Height { get; set; }
    string InternalName { get; }
    bool IsCustomized { get; }
    int Left { get; }
    UserInterfaceManager Parent { get; }
    bool ShowVisibilityCheckBox { get; set; }
    int Top { get; }
    ObjectTypeEnum Type { get; }
    ControlDefinition VisibilityControl { get; }
    bool Visible { get; set; }
    int Width { get; set; }
    // Methods
    void AddChild(object Identifier);
    void Clear();
    void Delete();
    void GetDockingState(out DockingStateEnum DockingState, out object DockToObject);
    void Move(int Top, int Left, int Height, int Width);
    void SetDockingState(DockingStateEnum DockingState, object DockToObject = Missing);
    void SetMinimumSize(int Height, int Width);
}
```

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DockableWindows](../objects/DockableWindows.md).Add, [DockableWindows](../objects/DockableWindows.md).Item

**Referenced types:** [ControlDefinition](../objects/ControlDefinition.md), [DockingStateEnum](../enums/DockingStateEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [UserInterfaceManager](../objects/UserInterfaceManager.md)

