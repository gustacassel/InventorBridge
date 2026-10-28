# ContentTreeViewNode

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ContentCenter.TreeViewTopNode`

```csharp
interface ContentTreeViewNode
{
    // Properties
    object Application { get; }
    ContentTreeViewNodesEnumerator ChildNodes { get; }
    string DisplayName { get; }
    ContentFamiliesEnumerator Families { get; }
    string FullTreeViewPath { get; }
    IPictureDisp Icon { get; }
    string InternalName { get; }
    ContentTreeViewNode ParentNode { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [ContentCenter](../objects/ContentCenter.md).TreeViewTopNode, [ContentTreeViewNode](../objects/ContentTreeViewNode.md).ParentNode, [ContentTreeViewNodesEnumerator](../objects/ContentTreeViewNodesEnumerator.md).Item

**Referenced types:** [ContentFamiliesEnumerator](../objects/ContentFamiliesEnumerator.md), [ContentTreeViewNodesEnumerator](../objects/ContentTreeViewNodesEnumerator.md), [IPictureDisp](../objects/IPictureDisp.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

