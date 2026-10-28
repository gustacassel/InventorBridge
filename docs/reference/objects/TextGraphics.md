# TextGraphics

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…].Item[…].AddTextGraphics(…)`

```csharp
interface TextGraphics
{
    // Properties
    Point Anchor { get; set; }
    bool Anchored { get; }
    object Application { get; }
    bool Bold { get; set; }
    bool BurnThrough { get; set; }
    int DepthPriority { get; set; }
    string Font { get; set; }
    double FontSize { get; set; }
    HorizontalTextAlignmentEnum HorizontalAlignment { get; set; }
    int Id { get; }
    bool Italic { get; set; }
    GraphicsNode Parent { get; }
    Box RangeBox { get; }
    bool Scalable { get; }
    string Text { get; set; }
    ObjectTypeEnum Type { get; }
    VerticalTextAlignmentEnum VerticalAlignment { get; set; }
    // Methods
    void Delete();
    void GetTextColor(out byte Red, out byte Green, out byte Blue);
    void GetTransformBehavior(out Point TextAnchor, out DisplayTransformBehaviorEnum BehaviorType, out double PixelScale);
    void GetViewSpaceAnchor(out Point Origin, out Point2d Anchor, out ViewLayoutEnum AnchorRelativeTo);
    void PutTextColor(byte Red, byte Green, byte Blue);
    void RemoveViewSpaceAnchor();
    void SetTransformBehavior(Point Anchor, DisplayTransformBehaviorEnum BehaviorType, double PixelScale = 1);
    void SetViewSpaceAnchor(Point Origin, Point2d Anchor, ViewLayoutEnum AnchorRelativeTo);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [GraphicsNode](../objects/GraphicsNode.md).AddScalableTextGraphics, [GraphicsNode](../objects/GraphicsNode.md).AddTextGraphics, [GraphicsNodeProxy](../objects/GraphicsNodeProxy.md).AddScalableTextGraphics, [GraphicsNodeProxy](../objects/GraphicsNodeProxy.md).AddTextGraphics

**Referenced types:** [Box](../objects/Box.md), [DisplayTransformBehaviorEnum](../enums/DisplayTransformBehaviorEnum.md), [GraphicsNode](../objects/GraphicsNode.md), [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [VerticalTextAlignmentEnum](../enums/VerticalTextAlignmentEnum.md), [ViewLayoutEnum](../enums/ViewLayoutEnum.md)

