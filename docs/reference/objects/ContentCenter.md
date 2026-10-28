# ContentCenter

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ContentCenter`

```csharp
interface ContentCenter
{
    // Properties
    object Application { get; }
    ContentTreeViewNode TreeViewTopNode { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    object GetContentObject(string ContentIdentifier, string LibraryId = "");
}
```

19 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).ContentCenter, [InventorServer](../objects/InventorServer.md).ContentCenter

**Referenced types:** [ContentTreeViewNode](../objects/ContentTreeViewNode.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

