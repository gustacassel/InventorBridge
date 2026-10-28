# TextBoxes

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].TextBoxes`

```csharp
interface TextBoxes
{
    // Properties
    object Application { get; }
    int Count { get; }
    TextBox Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    TextBox AddByRectangle(Point2d CornerOne, Point2d CornerTwo, string FormattedText, object TextStyle = Missing);
    TextBox AddFitted(Point2d Position, string FormattedText, object TextStyle = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).TextBoxes, [PlanarSketch](../objects/PlanarSketch.md).TextBoxes, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).TextBoxes, [Sketch](../objects/Sketch.md).TextBoxes, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).TextBoxes, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).TextBoxes

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [TextBox](../objects/TextBox.md)

