# GraphicsNodeProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GraphicsNode](../objects/GraphicsNode.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…].Item[…] → (GraphicsNodeProxy)`

```csharp
interface GraphicsNodeProxy
{
    // Properties
    bool AllowSliceCapping { get; set; }
    bool AllowSlicing { get; set; }
    Asset Appearance { get; set; }
    object Application { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    int Count { get; }
    string DisplayName { get; set; }
    bool ExcludedFromViewAll { get; set; }
    int Id { get; set; }
    bool IsTransparentInPlaceEdit { get; set; }
    GraphicsPrimitive Item[int Index] { get; }
    GraphicsPrimitive ItemById[int DataSetId] { get; }
    GraphicsNode NativeObject { get; }
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

**Referenced types:** [Asset](../objects/Asset.md), [Box](../objects/Box.md), [ClientGraphics](../objects/ClientGraphics.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentGraphics](../objects/ComponentGraphics.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [CurveGraphics](../objects/CurveGraphics.md), [GraphicsNode](../objects/GraphicsNode.md), [GraphicsPrimitive](../objects/GraphicsPrimitive.md), [LineGraphics](../objects/LineGraphics.md), [LineStripGraphics](../objects/LineStripGraphics.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PointGraphics](../objects/PointGraphics.md), [SurfaceGraphics](../objects/SurfaceGraphics.md), [TextGraphics](../objects/TextGraphics.md), [TriangleFanGraphics](../objects/TriangleFanGraphics.md), [TriangleGraphics](../objects/TriangleGraphics.md), [TriangleStripGraphics](../objects/TriangleStripGraphics.md), [ViewList](../objects/ViewList.md)

