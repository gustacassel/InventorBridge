# SketchBlocks

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchBlocks`

```csharp
interface SketchBlocks
{
    // Properties
    object Application { get; }
    int Count { get; }
    SketchBlock Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SketchBlock Add(ObjectCollection SketchObjects, string Name = "", object InsertionPoint = Missing);
    SketchBlock AddByDefinition(SketchBlockDefinition Definition, Point2d Position);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PlanarSketch](../objects/PlanarSketch.md).SketchBlocks, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).SketchBlocks, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).SketchBlocks, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).SketchBlocks

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [SketchBlock](../objects/SketchBlock.md), [SketchBlockDefinition](../objects/SketchBlockDefinition.md)

