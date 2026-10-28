# BrowserFoldersEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.BrowserPanes.Item[…].TopNode.BrowserFolders`

```csharp
interface BrowserFoldersEnumerator
{
    // Properties
    Application Application { get; }
    int Count { get; }
    BrowserFolder Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BrowserNode](../objects/BrowserNode.md).BrowserFolders

**Referenced types:** [Application](../objects/Application.md), [BrowserFolder](../objects/BrowserFolder.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

