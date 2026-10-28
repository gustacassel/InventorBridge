# UserInputEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.UserInputEvents`

```csharp
interface UserInputEvents
{
    // Properties
    Application Application { get; }
    CommandManager Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnActivateCommand(string CommandName, NameValueMap Context);
    event OnContextMenu(SelectionDeviceEnum SelectionDevice, NameValueMap AdditionalInfo, CommandBar CommandBar);
    event OnContextMenuOld(SelectionDeviceEnum SelectionDevice, NameValueMap AdditionalInfo, CommandBar CommandBar);
    event OnContextualMiniToolbar(ObjectsEnumerator SelectedEntities, NameValueMap DisplayedCommands, NameValueMap AdditionalInfo);
    event OnDeleteKeyUp(ObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice, View View, NameValueMap AdditionalInfo, out HandlingCodeEnum HandlingCode);
    event OnDoubleClick(ObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice, MouseButtonEnum Button, ShiftStateEnum ShiftKeys, Point ModelPosition, Point2d ViewPosition, View View, NameValueMap AdditionalInfo, out HandlingCodeEnum HandlingCode);
    event OnDrag(DragStateEnum DragState, ShiftStateEnum ShiftKeys, Point ModelPosition, Point2d ViewPosition, View View, NameValueMap AdditionalInfo, out HandlingCodeEnum HandlingCode);
    event OnLinearMarkingMenu(ObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice, CommandControls LinearMenu, NameValueMap AdditionalInfo);
    event OnMarkTutorialCommand(string CommandID, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnPreSelect(out object PreSelectEntity, out bool DoHighlight, out ObjectCollection MorePreSelectEntities, SelectionDeviceEnum SelectionDevice, Point ModelPosition, Point2d ViewPosition, View View);
    event OnRadialMarkingMenu(ObjectsEnumerator SelectedEntities, SelectionDeviceEnum SelectionDevice, RadialMarkingMenu RadialMenu, NameValueMap AdditionalInfo);
    event OnSelect(ObjectsEnumerator JustSelectedEntities, out ObjectCollection MoreSelectedEntities, SelectionDeviceEnum SelectionDevice, Point ModelPosition, Point2d ViewPosition, View View);
    event OnStartCommand(CommandIDEnum CommandID);
    event OnStopCommand(CommandIDEnum CommandID);
    event OnStopPreSelect(Point ModelPosition, Point2d ViewPosition, View View);
    event OnTerminateCommand(string CommandName, NameValueMap Context);
    event OnUnSelect(ObjectsEnumerator UnSelectedEntities, SelectionDeviceEnum SelectionDevice, Point ModelPosition, Point2d ViewPosition, View View);
}
```

**Returned by:** [CommandManager](../objects/CommandManager.md).UserInputEvents

**Referenced types:** [Application](../objects/Application.md), [CommandControls](../objects/CommandControls.md), [CommandManager](../objects/CommandManager.md), [DragStateEnum](../enums/DragStateEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [MouseButtonEnum](../enums/MouseButtonEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [RadialMarkingMenu](../objects/RadialMarkingMenu.md), [SelectionDeviceEnum](../enums/SelectionDeviceEnum.md), [ShiftStateEnum](../enums/ShiftStateEnum.md), [View](../objects/View.md)

