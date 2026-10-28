# ContentTreeViewNodesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ContentCenter.TreeViewTopNode.ChildNodes`

```csharp
interface ContentTreeViewNodesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    ContentTreeViewNode Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ContentTreeViewNode](../objects/ContentTreeViewNode.md).ChildNodes

**Referenced types:** [ContentTreeViewNode](../objects/ContentTreeViewNode.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

