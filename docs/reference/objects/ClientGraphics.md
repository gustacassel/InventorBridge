# ClientGraphics

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…]`

```csharp
interface ClientGraphics
{
    // Properties
    object Application { get; }
    string ClientId { get; }
    int Count { get; }
    GraphicsNode Item[int Index] { get; }
    GraphicsNode ItemById[int NodeId] { get; }
    bool NonTransacting { get; }
    ClientGraphicsCollection Parent { get; }
    Box RangeBox { get; }
    GraphicsSelectabilityEnum Selectable { get; set; }
    ObjectTypeEnum Type { get; }
    GraphicsVisibilityEnum Visible { get; set; }
    // Methods
    GraphicsNode AddNode(int NodeId);
    void Delete();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md).Add, [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md).Item, [GraphicsNode](../objects/GraphicsNode.md).Parent, [GraphicsNodeProxy](../objects/GraphicsNodeProxy.md).Parent, [InteractionGraphics](../objects/InteractionGraphics.md).OverlayClientGraphics, [InteractionGraphics](../objects/InteractionGraphics.md).PreviewClientGraphics

**Referenced types:** [Box](../objects/Box.md), [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md), [GraphicsNode](../objects/GraphicsNode.md), [GraphicsSelectabilityEnum](../enums/GraphicsSelectabilityEnum.md), [GraphicsVisibilityEnum](../enums/GraphicsVisibilityEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

