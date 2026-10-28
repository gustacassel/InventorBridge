# TextBoxProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [TextBox](../objects/TextBox.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].TextBoxes.Item[…] → (TextBoxProxy)`

```csharp
interface TextBoxProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Color BackgroundColor { get; set; }
    SketchEntitiesEnumerator BoundaryGeometry { get; }
    Color Color { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    SketchBlock ContainingSketchBlock { get; }
    bool Fitted { get; }
    double FittedTextHeight { get; }
    double FittedTextWidth { get; }
    string FormattedText { get; set; }
    double Height { get; set; }
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    Layer Layer { get; set; }
    double LineSpacing { get; set; }
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    TextBox NativeObject { get; }
    Point2d Origin { get; set; }
    SketchPoint OriginSketchPoint { get; }
    Sketch Parent { get; }
    Box2d RangeBox { get; }
    double Rotation { get; set; }
    bool ShowBoundaries { get; set; }
    bool SingleLineText { get; set; }
    SketchBlocksEnumerator SketchBlockPath { get; }
    VerticalTextAlignmentEnum StackedTextPosition { get; set; }
    TextStyle Style { get; set; }
    string Text { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseBackgroundColor { get; set; }
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    double Width { get; set; }
    double WidthScale { get; set; }
    // Methods
    SketchEntitiesEnumerator ConvertToGeometry(string SHXFont, object UseBigFont = Missing, object BigFont = Missing);
    void Delete();
    void GetFacetsInfo(out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out int[] VertexIndices);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [Color](../objects/Color.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [Sketch](../objects/Sketch.md), [SketchBlock](../objects/SketchBlock.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md), [SketchPoint](../objects/SketchPoint.md), [TextBox](../objects/TextBox.md), [TextLineSpacingTypeEnum](../enums/TextLineSpacingTypeEnum.md), [TextStyle](../objects/TextStyle.md), [VerticalTextAlignmentEnum](../enums/VerticalTextAlignmentEnum.md)

