# NativeBrowserNodeDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [BrowserNodeDefinition](../objects/BrowserNodeDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument.BrowserPanes.GetNativeBrowserNodeDefinition(…)`

```csharp
interface NativeBrowserNodeDefinition
{
    // Properties
    BrowserNodeDisplayStateEnum AdditionalDisplayState { get; set; }
    string AdditionalStateIconToolTipText { get; set; }
    object Application { get; }
    bool BuiltIn { get; }
    BrowserNodeDisplayStateEnum DisplayState { get; set; }
    IPictureDisp ExpandedIcon { get; }
    IPictureDisp Icon { get; }
    string Label { get; }
    object NativeObject { get; }
    ClientNodeResource OverrideExpandedIcon { get; set; }
    ClientNodeResource OverrideIcon { get; set; }
    ClientNodeResource OverrideStateIcon { get; set; }
    Document Parent { get; }
    string StateIconToolTipText { get; set; }
    string ToolTipText { get; set; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnLabelEdit(string NewLabel, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BrowserPanes](../objects/BrowserPanes.md).GetNativeBrowserNodeDefinition, [BrowserPanes](../objects/BrowserPanes.md).GetNativeBrowserNodeDefinitionWithOptions

**Referenced types:** [BrowserNodeDisplayStateEnum](../enums/BrowserNodeDisplayStateEnum.md), [ClientNodeResource](../objects/ClientNodeResource.md), [Document](../objects/Document.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [IPictureDisp](../objects/IPictureDisp.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

