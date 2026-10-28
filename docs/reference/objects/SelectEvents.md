# SelectEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CreateInteractionEvents(…).SelectEvents`

```csharp
interface SelectEvents
{
    // Properties
    Application Application { get; }
    bool Enabled { get; set; }
    bool ExpressSelectionEnabled { get; set; }
    bool IgnoreProfileInnerLoops { get; set; }
    bool MouseMoveEnabled { get; set; }
    InteractionEvents Parent { get; }
    bool PreSelectBurnThrough { get; set; }
    ComponentOccurrence RestrictSelectionToOccurrence { get; set; } // signature changed; in 2024: ComponentOccurrence RestrictSelectionToOccurrence { set; }
    ComponentOccurrence RestrictWindowSelectionToOccurrence { get; set; } // since 2025
    ObjectsEnumerator SelectedEntities { get; }
    bool SingleSelectEnabled { get; set; }
    ObjectTypeEnum Type { get; }
    bool WindowSelectEnabled { get; set; }
    _PreSelectionTypeEnum _PreSelectionType { get; }
    // Methods
    void AddSelectionFilter(SelectionFilterEnum Filter);
    void AddToSelectedEntities(object ItemObject);
    void AddWindowSelectionFilter(SelectionFilterEnum Filter);
    void ClearSelectionFilter();
    void ClearWindowSelectionFilter();
    void RemoveFromSelectedEntities(object ItemObject);
    void ResetSelections();
    // Events
    event OnPreSelect(out object PreSelectEntity, out bool DoHighlight, out ObjectCollection MorePreSelectEntities, SelectionDeviceEnum SelectionDevice, Point ModelPosition, Point2d ViewPosition, View View);
    event OnPreSelectMouseMove(object PreSelectEntity, Point ModelPosition, Point2d ViewPosition, View View);
    event OnSelect(ObjectsEnumerator JustSelectedEntities, SelectionDeviceEnum SelectionDevice, Point ModelPosition, Point2d ViewPosition, View View);
    event OnStopPreSelect(Point ModelPosition, Point2d ViewPosition, View View);
    event OnUnSelect(ObjectsEnumerator UnSelectedEntities, SelectionDeviceEnum SelectionDevice, Point ModelPosition, Point2d ViewPosition, View View);
}
```

**Returned by:** [InteractionEvents](../objects/InteractionEvents.md).SelectEvents

**Referenced types:** [Application](../objects/Application.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [InteractionEvents](../objects/InteractionEvents.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [SelectionDeviceEnum](../enums/SelectionDeviceEnum.md), [SelectionFilterEnum](../enums/SelectionFilterEnum.md), [View](../objects/View.md)

