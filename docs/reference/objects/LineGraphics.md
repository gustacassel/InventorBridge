# LineGraphics

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GraphicsPrimitive](../objects/GraphicsPrimitive.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…].Item[…].Item[…] → (LineGraphics)`

```csharp
interface LineGraphics
{
    // Properties
    bool Anchored { get; }
    object Application { get; }
    bool BurnThrough { get; set; }
    ColorBindingEnum ColorBinding { get; set; }
    GraphicsIndexSet ColorIndexSet { get; set; }
    GraphicsColorSet ColorSet { get; set; }
    GraphicsIndexSet CoordinateIndexSet { get; set; }
    GraphicsCoordinateSet CoordinateSet { get; set; }
    int DepthPriority { get; set; }
    int Id { get; }
    LineDefinitionSpaceEnum LineDefinitionSpace { get; set; }
    double LineScale { get; set; }
    LineTypeEnum LineType { get; set; }
    double LineWeight { get; set; }
    GraphicsNode Parent { get; }
    Box RangeBox { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void GetTransformBehavior(out Point TextAnchor, out DisplayTransformBehaviorEnum BehaviorType, out double PixelScale);
    void GetViewSpaceAnchor(out Point Origin, out Point2d Anchor, out ViewLayoutEnum AnchorRelativeTo);
    void RemoveViewSpaceAnchor();
    void SetCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    void SetTransformBehavior(Point Anchor, DisplayTransformBehaviorEnum BehaviorType, double PixelScale = 1);
    void SetViewSpaceAnchor(Point Origin, Point2d Anchor, ViewLayoutEnum AnchorRelativeTo);
}
```

**Returned by:** [GraphicsNode](../objects/GraphicsNode.md).AddLineGraphics, [GraphicsNodeProxy](../objects/GraphicsNodeProxy.md).AddLineGraphics

**Referenced types:** [Box](../objects/Box.md), [ColorBindingEnum](../enums/ColorBindingEnum.md), [DisplayTransformBehaviorEnum](../enums/DisplayTransformBehaviorEnum.md), [GraphicsColorSet](../objects/GraphicsColorSet.md), [GraphicsCoordinateSet](../objects/GraphicsCoordinateSet.md), [GraphicsIndexSet](../objects/GraphicsIndexSet.md), [GraphicsNode](../objects/GraphicsNode.md), [LineDefinitionSpaceEnum](../enums/LineDefinitionSpaceEnum.md), [LineTypeEnum](../enums/LineTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [ViewLayoutEnum](../enums/ViewLayoutEnum.md)

