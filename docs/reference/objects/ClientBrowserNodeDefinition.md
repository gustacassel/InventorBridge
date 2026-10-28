# ClientBrowserNodeDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [BrowserNodeDefinition](../objects/BrowserNodeDefinition.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument.BrowserPanes.CreateBrowserNodeDefinition(…)`

```csharp
interface ClientBrowserNodeDefinition
{
    // Properties
    BrowserNodeDisplayStateEnum AdditionalDisplayState { get; set; }
    string AdditionalStateIconToolTipText { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool BuiltIn { get; }
    BrowserNodeDisplayStateEnum DisplayState { get; set; }
    ClientNodeResource ExpandedIcon { get; set; }
    ClientNodeResource Icon { get; set; }
    int Id { get; }
    bool IsReferenced { get; }
    string Label { get; }
    Document Parent { get; }
    string StateIconToolTipText { get; set; }
    string ToolTipText { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetLabel(string Label);
    // Events
    event OnActivate(NameValueMap Context);
    event OnGetDisplayObjects(out ObjectCollection Objects, NameValueMap Context);
    event OnLabelEdit(string NewLabel, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BrowserPanes](../objects/BrowserPanes.md).CreateBrowserNodeDefinition, [BrowserPanes](../objects/BrowserPanes.md).GetClientBrowserNodeDefinition

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [BrowserNodeDisplayStateEnum](../enums/BrowserNodeDisplayStateEnum.md), [ClientNodeResource](../objects/ClientNodeResource.md), [Document](../objects/Document.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

