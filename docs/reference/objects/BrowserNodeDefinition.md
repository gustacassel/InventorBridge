# BrowserNodeDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.BrowserPanes.Item[…].TopNode.BrowserNodeDefinition`

```csharp
interface BrowserNodeDefinition
{
    // Properties
    BrowserNodeDisplayStateEnum AdditionalDisplayState { get; set; }
    string AdditionalStateIconToolTipText { get; set; }
    object Application { get; }
    bool BuiltIn { get; }
    BrowserNodeDisplayStateEnum DisplayState { get; set; }
    string Label { get; }
    Document Parent { get; }
    string StateIconToolTipText { get; set; }
    string ToolTipText { get; set; }
    ObjectTypeEnum Type { get; }
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BrowserNode](../objects/BrowserNode.md).BrowserNodeDefinition

**Referenced types:** [BrowserNodeDisplayStateEnum](../enums/BrowserNodeDisplayStateEnum.md), [Document](../objects/Document.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

