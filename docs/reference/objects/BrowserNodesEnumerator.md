# BrowserNodesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.BrowserPanes.Item[…].TopNode.BrowserNodes`

```csharp
interface BrowserNodesEnumerator
{
    // Properties
    Application Application { get; }
    int Count { get; }
    BrowserNode Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BrowserNode ItemById(int Id);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BrowserNode](../objects/BrowserNode.md).AllReferencedNodes, [BrowserNode](../objects/BrowserNode.md).BrowserNodes

**Referenced types:** [Application](../objects/Application.md), [BrowserNode](../objects/BrowserNode.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

