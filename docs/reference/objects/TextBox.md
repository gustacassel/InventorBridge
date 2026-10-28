# TextBox

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].TextBoxes.Item[…]`

```csharp
interface TextBox
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Color BackgroundColor { get; set; }
    SketchEntitiesEnumerator BoundaryGeometry { get; }
    Color Color { get; set; }
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

**Returned by:** [ProfilePath](../objects/ProfilePath.md).TextBox, [ProfilePathProxy](../objects/ProfilePathProxy.md).TextBox, [TextBoxConstraint](../objects/TextBoxConstraint.md).TextBox, [TextBoxConstraintProxy](../objects/TextBoxConstraintProxy.md).TextBox, [TextBoxProxy](../objects/TextBoxProxy.md).NativeObject, [TextBoxes](../objects/TextBoxes.md).AddByRectangle, [TextBoxes](../objects/TextBoxes.md).AddFitted, [TextBoxes](../objects/TextBoxes.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [Color](../objects/Color.md), [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [Sketch](../objects/Sketch.md), [SketchBlock](../objects/SketchBlock.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md), [SketchPoint](../objects/SketchPoint.md), [TextLineSpacingTypeEnum](../enums/TextLineSpacingTypeEnum.md), [TextStyle](../objects/TextStyle.md), [VerticalTextAlignmentEnum](../enums/VerticalTextAlignmentEnum.md)

