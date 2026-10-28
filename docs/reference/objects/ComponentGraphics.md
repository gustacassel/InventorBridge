# ComponentGraphics

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…].Item[…].AddComponentGraphics(…)`

```csharp
interface ComponentGraphics
{
    // Properties
    bool Anchored { get; }
    object Application { get; }
    SurfaceBody Body { get; }
    bool BurnThrough { get; set; }
    Color Color { get; set; }
    int DepthPriority { get; set; }
    bool DisplaySilhouettes { get; set; }
    SurfaceGraphicsEdgeList DisplayedEdges { get; }
    SurfaceGraphicsFaceList DisplayedFaces { get; }
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

**Returned by:** [GraphicsNode](../objects/GraphicsNode.md).AddComponentGraphics, [GraphicsNodeProxy](../objects/GraphicsNodeProxy.md).AddComponentGraphics

**Referenced types:** [Box](../objects/Box.md), [Color](../objects/Color.md), [DisplayTransformBehaviorEnum](../enums/DisplayTransformBehaviorEnum.md), [GraphicsNode](../objects/GraphicsNode.md), [LineDefinitionSpaceEnum](../enums/LineDefinitionSpaceEnum.md), [LineTypeEnum](../enums/LineTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [SurfaceBody](../objects/SurfaceBody.md), [SurfaceGraphicsEdgeList](../objects/SurfaceGraphicsEdgeList.md), [SurfaceGraphicsFaceList](../objects/SurfaceGraphicsFaceList.md), [ViewLayoutEnum](../enums/ViewLayoutEnum.md)

