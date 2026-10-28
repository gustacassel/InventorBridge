# ContentFamiliesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ContentCenter.TreeViewTopNode.Families`

```csharp
interface ContentFamiliesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    ContentFamily Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ContentTreeViewNode](../objects/ContentTreeViewNode.md).Families

**Referenced types:** [ContentFamily](../objects/ContentFamily.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

