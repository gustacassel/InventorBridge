# BrowserFolder

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.BrowserPanes.Item[…].TopNode.BrowserFolders.Item[…]`

```csharp
interface BrowserFolder
{
    // Properties
    bool AllowAddRemove { get; set; }
    bool AllowDelete { get; set; }
    bool AllowRename { get; set; }
    bool AllowReorder { get; set; }
    object Application { get; }
    BrowserNode BrowserNode { get; }
    string Name { get; set; }
    object Parent { get; }
    bool PartFeatureFolder { get; } // since 2027
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(BrowserNode BrowserNode, object TargetNode = Missing, bool Before = false);
    void Delete(bool Reserved = true);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void Remove(BrowserNode BrowserNode, object TargetNode = Missing, bool Before = false);
    void SetEndOfPart(bool Before);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BrowserFoldersEnumerator](../objects/BrowserFoldersEnumerator.md).Item, [BrowserPane](../objects/BrowserPane.md).AddBrowserFolder, [BrowserPane](../objects/BrowserPane.md).AddBrowserFolderWithOptions

**Referenced types:** [BrowserNode](../objects/BrowserNode.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

