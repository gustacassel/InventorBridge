# GraphicsNode

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…].Item[…]`

```csharp
interface GraphicsNode
{
    // Properties
    bool AllowSliceCapping { get; set; }
    bool AllowSlicing { get; set; }
    Asset Appearance { get; set; }
    object Application { get; }
    int Count { get; }
    string DisplayName { get; set; }
    bool ExcludedFromViewAll { get; set; }
    int Id { get; set; }
    bool IsTransparentInPlaceEdit { get; set; }
    GraphicsPrimitive Item[int Index] { get; }
    GraphicsPrimitive ItemById[int DataSetId] { get; }
    double OverrideOpacity { get; set; }
    ClientGraphics Parent { get; }
    Box RangeBox { get; }
    bool Selectable { get; set; }
    Matrix Transformation { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    bool VisibleInActiveEditObject { get; set; }
    ViewList VisibleInViews { get; }
    // Methods
    ComponentGraphics AddComponentGraphics(ComponentDefinition ComponentDefinition);
    CurveGraphics AddCurveGraphics(object Curve);
    LineGraphics AddLineGraphics();
    LineStripGraphics AddLineStripGraphics();
    PointGraphics AddPointGraphics();
    TextGraphics AddScalableTextGraphics();
    SurfaceGraphics AddSurfaceGraphics(object Surfaces);
    TextGraphics AddTextGraphics();
    TriangleFanGraphics AddTriangleFanGraphics();
    TriangleGraphics AddTriangleGraphics();
    TriangleStripGraphics AddTriangleStripGraphics();
    void ClearSlice();
    GraphicsNode Copy(Matrix Transformation, int NodeId);
    void Delete();
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ClientGraphics](../objects/ClientGraphics.md).AddNode, [ClientGraphics](../objects/ClientGraphics.md).Item, [ClientGraphics](../objects/ClientGraphics.md).ItemById, [ComponentGraphics](../objects/ComponentGraphics.md).Parent, [CurveGraphics](../objects/CurveGraphics.md).Parent, [GraphicsNode](../objects/GraphicsNode.md).Copy, [GraphicsNodeProxy](../objects/GraphicsNodeProxy.md).Copy, [GraphicsNodeProxy](../objects/GraphicsNodeProxy.md).NativeObject, [GraphicsPrimitive](../objects/GraphicsPrimitive.md).Parent, [LineGraphics](../objects/LineGraphics.md).Parent, [LineStripGraphics](../objects/LineStripGraphics.md).Parent, [PointGraphics](../objects/PointGraphics.md).Parent, [SurfaceGraphics](../objects/SurfaceGraphics.md).Parent, [TextGraphics](../objects/TextGraphics.md).Parent, [TriangleFanGraphics](../objects/TriangleFanGraphics.md).Parent, [TriangleGraphics](../objects/TriangleGraphics.md).Parent, [TriangleStripGraphics](../objects/TriangleStripGraphics.md).Parent

**Referenced types:** [Asset](../objects/Asset.md), [Box](../objects/Box.md), [ClientGraphics](../objects/ClientGraphics.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentGraphics](../objects/ComponentGraphics.md), [CurveGraphics](../objects/CurveGraphics.md), [GraphicsPrimitive](../objects/GraphicsPrimitive.md), [LineGraphics](../objects/LineGraphics.md), [LineStripGraphics](../objects/LineStripGraphics.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PointGraphics](../objects/PointGraphics.md), [SurfaceGraphics](../objects/SurfaceGraphics.md), [TextGraphics](../objects/TextGraphics.md), [TriangleFanGraphics](../objects/TriangleFanGraphics.md), [TriangleGraphics](../objects/TriangleGraphics.md), [TriangleStripGraphics](../objects/TriangleStripGraphics.md), [ViewList](../objects/ViewList.md)

