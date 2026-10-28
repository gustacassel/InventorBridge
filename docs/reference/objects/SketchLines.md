# SketchLines

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchLines`

```csharp
interface SketchLines
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchLine Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchEntitiesEnumerator AddAsPolygon(int NumberOfSides, object CenterPoint, object CircumferencePoint, bool Inscribed);
    SketchEntitiesEnumerator AddAsThreePointCenteredRectangle(object CenterPoint, object EdgePoint, Point2d WidthPoint);
    SketchEntitiesEnumerator AddAsThreePointRectangle(object BasePointOne, object BasePointTwo, Point2d HeightPoint);
    SketchEntitiesEnumerator AddAsTwoPointCenteredRectangle(object CenterPoint, object CornerPoint);
    SketchEntitiesEnumerator AddAsTwoPointRectangle(object CornerPointOne, object CornerPointTwo);
    SketchLine AddByMidEndPoints(object MidPoint, object EndPoint); // since 2025
    SketchLine AddByTwoPoints(object StartPoint, object EndPoint);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).SketchLines, [PlanarSketch](../objects/PlanarSketch.md).SketchLines, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).SketchLines, [Sketch](../objects/Sketch.md).SketchLines, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).SketchLines, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).SketchLines

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md), [SketchLine](../objects/SketchLine.md)

