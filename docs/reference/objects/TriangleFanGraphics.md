# TriangleFanGraphics

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…].Item[…].AddTriangleFanGraphics(…)`

```csharp
interface TriangleFanGraphics
{
    // Properties
    bool Anchored { get; }
    object Application { get; }
    BackFaceCullingEnum BackFaceCulling { get; set; }
    bool BurnThrough { get; set; }
    ColorBindingEnum ColorBinding { get; set; }
    GraphicsIndexSet ColorIndexSet { get; set; }
    GraphicsColorMapper ColorMapper { get; set; }
    GraphicsColorSet ColorSet { get; set; }
    GraphicsIndexSet CoordinateIndexSet { get; set; }
    GraphicsCoordinateSet CoordinateSet { get; set; }
    int DepthPriority { get; set; }
    int Id { get; }
    NormalBindingEnum NormalBinding { get; set; }
    GraphicsIndexSet NormalIndexSet { get; set; }
    GraphicsNormalSet NormalSet { get; set; }
    GraphicsNode Parent { get; }
    Box RangeBox { get; }
    GraphicsIndexSet TextureCoordinateIndexSet { get; set; }
    GraphicsTextureCoordinateSet TextureCoordinateSet { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetStripLengths(out int[] StripLengths);
    void GetTransformBehavior(out Point TextAnchor, out DisplayTransformBehaviorEnum BehaviorType, out double PixelScale);
    void GetViewSpaceAnchor(out Point Origin, out Point2d Anchor, out ViewLayoutEnum AnchorRelativeTo);
    void PutStripLengths(out int[] StripLengths);
    void RemoveViewSpaceAnchor();
    void SetTransformBehavior(Point Anchor, DisplayTransformBehaviorEnum BehaviorType, double PixelScale = 1);
    void SetViewSpaceAnchor(Point Origin, Point2d Anchor, ViewLayoutEnum AnchorRelativeTo);
}
```

**Returned by:** [GraphicsNode](../objects/GraphicsNode.md).AddTriangleFanGraphics, [GraphicsNodeProxy](../objects/GraphicsNodeProxy.md).AddTriangleFanGraphics

**Referenced types:** [BackFaceCullingEnum](../enums/BackFaceCullingEnum.md), [Box](../objects/Box.md), [ColorBindingEnum](../enums/ColorBindingEnum.md), [DisplayTransformBehaviorEnum](../enums/DisplayTransformBehaviorEnum.md), [GraphicsColorMapper](../objects/GraphicsColorMapper.md), [GraphicsColorSet](../objects/GraphicsColorSet.md), [GraphicsCoordinateSet](../objects/GraphicsCoordinateSet.md), [GraphicsIndexSet](../objects/GraphicsIndexSet.md), [GraphicsNode](../objects/GraphicsNode.md), [GraphicsNormalSet](../objects/GraphicsNormalSet.md), [GraphicsTextureCoordinateSet](../objects/GraphicsTextureCoordinateSet.md), [NormalBindingEnum](../enums/NormalBindingEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [ViewLayoutEnum](../enums/ViewLayoutEnum.md)

