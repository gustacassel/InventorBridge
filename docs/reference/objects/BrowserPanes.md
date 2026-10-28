# BrowserPanes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.BrowserPanes`

```csharp
interface BrowserPanes
{
    // Properties
    BrowserPane ActivePane { get; }
    object Application { get; }
    BrowserPanesEvents BrowserPanesEvents { get; }
    ClientNodeResources ClientNodeResources { get; }
    int Count { get; }
    BrowserPane Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BrowserPane Add(string Name, string InternalName);
    BrowserPane AddByManifest(string Name, string InternalName, string ManifestFileName);
    BrowserPane AddTreeBrowserPane(string Name, string InternalName, BrowserNodeDefinition TopNodeDefinition);
    ClientBrowserNodeDefinition CreateBrowserNodeDefinition(string Label, int Id, ClientNodeResource Icon, object ToolTipText = Missing, object ExpandedIcon = Missing, object DisplayState = Missing, object StateIconToolTipText = Missing);
    ClientBrowserNodeDefinition GetClientBrowserNodeDefinition(string ClientId, int Id);
    NativeBrowserNodeDefinition GetNativeBrowserNodeDefinition(object NativeObject);
    NativeBrowserNodeDefinition GetNativeBrowserNodeDefinitionWithOptions(object NativeObject, object Options = Missing);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).BrowserPanes, [Document](../objects/Document.md).BrowserPanes, [DrawingDocument](../objects/DrawingDocument.md).BrowserPanes, [PartDocument](../objects/PartDocument.md).BrowserPanes, [PresentationDocument](../objects/PresentationDocument.md).BrowserPanes

**Referenced types:** [BrowserNodeDefinition](../objects/BrowserNodeDefinition.md), [BrowserPane](../objects/BrowserPane.md), [BrowserPanesEvents](../objects/BrowserPanesEvents.md), [ClientBrowserNodeDefinition](../objects/ClientBrowserNodeDefinition.md), [ClientNodeResource](../objects/ClientNodeResource.md), [ClientNodeResources](../objects/ClientNodeResources.md), [NativeBrowserNodeDefinition](../objects/NativeBrowserNodeDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

