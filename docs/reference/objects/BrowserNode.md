# BrowserNode

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.BrowserPanes.Item[…].TopNode`

```csharp
interface BrowserNode
{
    // Properties
    object Application { get; }
    BrowserFoldersEnumerator BrowserFolders { get; }
    BrowserNodeDefinition BrowserNodeDefinition { get; }
    BrowserNodesEnumerator BrowserNodes { get; }
    bool Expanded { get; set; }
    string FullPath { get; }
    object NativeObject { get; }
    object Parent { get; }
    bool Selected { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    BrowserNode AddChild(BrowserNodeDefinition Definition);
    BrowserNodesEnumerator AllReferencedNodes(BrowserNodeDefinition Definition);
    void Delete();
    void DoPreSelect();
    void DoSelect();
    void EnsureVisible();
    BrowserNode InsertChild(BrowserNodeDefinition Definition, BrowserNode TargetNode, bool InsertBefore);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BrowserFolder](../objects/BrowserFolder.md).BrowserNode, [BrowserNode](../objects/BrowserNode.md).AddChild, [BrowserNode](../objects/BrowserNode.md).InsertChild, [BrowserNodesEnumerator](../objects/BrowserNodesEnumerator.md).Item, [BrowserNodesEnumerator](../objects/BrowserNodesEnumerator.md).ItemById, [BrowserPane](../objects/BrowserPane.md).GetBrowserNodeFromObject, [BrowserPane](../objects/BrowserPane.md).TopNode, [ClientFeature](../objects/ClientFeature.md).BrowserNode, [ClientFeatureProxy](../objects/ClientFeatureProxy.md).BrowserNode

**Referenced types:** [BrowserFoldersEnumerator](../objects/BrowserFoldersEnumerator.md), [BrowserNodeDefinition](../objects/BrowserNodeDefinition.md), [BrowserNodesEnumerator](../objects/BrowserNodesEnumerator.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

