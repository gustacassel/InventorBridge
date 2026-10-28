# GraphicsPrimitive

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…].Item[…].Item[…]`

```csharp
interface GraphicsPrimitive
{
    // Properties
    bool Anchored { get; }
    object Application { get; }
    int Id { get; }
    GraphicsNode Parent { get; }
    Box RangeBox { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetViewSpaceAnchor(out Point Origin, out Point2d Anchor, out ViewLayoutEnum AnchorRelativeTo);
    void RemoveViewSpaceAnchor();
    void SetViewSpaceAnchor(Point Origin, Point2d Anchor, ViewLayoutEnum AnchorRelativeTo);
}
```

**Returned by:** [GraphicsNode](../objects/GraphicsNode.md).Item, [GraphicsNode](../objects/GraphicsNode.md).ItemById, [GraphicsNodeProxy](../objects/GraphicsNodeProxy.md).Item, [GraphicsNodeProxy](../objects/GraphicsNodeProxy.md).ItemById

**Referenced types:** [Box](../objects/Box.md), [GraphicsNode](../objects/GraphicsNode.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [ViewLayoutEnum](../enums/ViewLayoutEnum.md)

