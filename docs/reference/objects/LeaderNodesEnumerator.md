# LeaderNodesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.SketchedSymbols.Item[…].Leader.AllLeafNodes`

```csharp
interface LeaderNodesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    LeaderNode Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Leader](../objects/Leader.md).AllLeafNodes, [Leader](../objects/Leader.md).AllNodes, [LeaderNode](../objects/LeaderNode.md).ChildNodes

**Referenced types:** [LeaderNode](../objects/LeaderNode.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

