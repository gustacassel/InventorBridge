# PointGraphics

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GraphicsPrimitive](../objects/GraphicsPrimitive.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…].Item[…].Item[…] → (PointGraphics)`

```csharp
interface PointGraphics
{
    // Properties
    bool Anchored { get; }
    object Application { get; }
    bool BurnThrough { get; set; }
    GraphicsIndexSet CoordinateIndexSet { get; set; }
    GraphicsCoordinateSet CoordinateSet { get; set; }
    int DepthPriority { get; set; }
    int Id { get; }
    GraphicsNode Parent { get; }
    PointRenderStyleEnum PointRenderStyle { get; set; }
    Box RangeBox { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetCustomImage(out GraphicsImageSet GraphicsImageSet, out int GraphicsImageIndex);
    void GetViewSpaceAnchor(out Point Origin, out Point2d Anchor, out ViewLayoutEnum AnchorRelativeTo);
    void RemoveViewSpaceAnchor();
    void SetCustomImage(GraphicsImageSet GraphicsImageSet, int GraphicsImageIndex);
    void SetViewSpaceAnchor(Point Origin, Point2d Anchor, ViewLayoutEnum AnchorRelativeTo);
}
```

**Returned by:** [GraphicsNode](../objects/GraphicsNode.md).AddPointGraphics, [GraphicsNodeProxy](../objects/GraphicsNodeProxy.md).AddPointGraphics

**Referenced types:** [Box](../objects/Box.md), [GraphicsCoordinateSet](../objects/GraphicsCoordinateSet.md), [GraphicsImageSet](../objects/GraphicsImageSet.md), [GraphicsIndexSet](../objects/GraphicsIndexSet.md), [GraphicsNode](../objects/GraphicsNode.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [PointRenderStyleEnum](../enums/PointRenderStyleEnum.md), [ViewLayoutEnum](../enums/ViewLayoutEnum.md)

