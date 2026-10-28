# BrowserPanesEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.BrowserPanes.BrowserPanesEvents`

```csharp
interface BrowserPanesEvents
{
    // Events
    event OnBrowserNodeActivate(object BrowserNodeDefinition, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnBrowserNodeDeleteEntry(object BrowserNodeDefinition, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnBrowserNodeGetDisplayObjects(object BrowserNodeDefinition, out ObjectCollection Objects, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnBrowserNodeLabelEdit(object BrowserNodeDefinition, string NewLabel, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnBrowserNodesReorder(BrowserPane BrowserPane, BrowserNodesEnumerator DragNodes, BrowserNode TargetNode, InsertionLocationTypeEnum eInsertionLoactionType, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [BrowserPanes](../objects/BrowserPanes.md).BrowserPanesEvents

**Referenced types:** [BrowserNode](../objects/BrowserNode.md), [BrowserNodesEnumerator](../objects/BrowserNodesEnumerator.md), [BrowserPane](../objects/BrowserPane.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [InsertionLocationTypeEnum](../enums/InsertionLocationTypeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectCollection](../objects/ObjectCollection.md)

