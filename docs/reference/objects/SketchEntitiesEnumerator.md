# SketchEntitiesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchEntities`

```csharp
interface SketchEntitiesEnumerator
{
    // Properties
    int Count { get; }
    SketchEntity Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).AddArcSlotByCenterPointArc, [DrawingSketch](../objects/DrawingSketch.md).AddArcSlotByThreePointArc, [DrawingSketch](../objects/DrawingSketch.md).AddStraightSlotByCenterToCenter, [DrawingSketch](../objects/DrawingSketch.md).AddStraightSlotByOverall, [DrawingSketch](../objects/DrawingSketch.md).AddStraightSlotBySlotCenter, [DrawingSketch](../objects/DrawingSketch.md).OffsetSketchEntitiesUsingDistance, [DrawingSketch](../objects/DrawingSketch.md).OffsetSketchEntitiesUsingPoint, [DrawingSketch](../objects/DrawingSketch.md).SketchEntities, [PlanarSketch](../objects/PlanarSketch.md).AddArcSlotByCenterPointArc, [PlanarSketch](../objects/PlanarSketch.md).AddArcSlotByThreePointArc, [PlanarSketch](../objects/PlanarSketch.md).AddStraightSlotByCenterToCenter, [PlanarSketch](../objects/PlanarSketch.md).AddStraightSlotByOverall, [PlanarSketch](../objects/PlanarSketch.md).AddStraightSlotBySlotCenter, [PlanarSketch](../objects/PlanarSketch.md).OffsetSketchEntitiesUsingDistance, [PlanarSketch](../objects/PlanarSketch.md).OffsetSketchEntitiesUsingPoint, [PlanarSketch](../objects/PlanarSketch.md).SketchEntities, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).AddArcSlotByCenterPointArc, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).AddArcSlotByThreePointArc, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).AddStraightSlotByCenterToCenter, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).AddStraightSlotByOverall, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).AddStraightSlotBySlotCenter, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).OffsetSketchEntitiesUsingDistance, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).OffsetSketchEntitiesUsingPoint, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).SketchEntities, [ProjectedCut](../objects/ProjectedCut.md).SketchEntities, [ProjectedCutProxy](../objects/ProjectedCutProxy.md).SketchEntities, [Sketch](../objects/Sketch.md).AddArcSlotByCenterPointArc, [Sketch](../objects/Sketch.md).AddArcSlotByThreePointArc, [Sketch](../objects/Sketch.md).AddStraightSlotByCenterToCenter, [Sketch](../objects/Sketch.md).AddStraightSlotByOverall, [Sketch](../objects/Sketch.md).AddStraightSlotBySlotCenter, [Sketch](../objects/Sketch.md).OffsetSketchEntitiesUsingDistance, [Sketch](../objects/Sketch.md).OffsetSketchEntitiesUsingPoint, [Sketch](../objects/Sketch.md).SketchEntities, [SketchArc](../objects/SketchArc.md).OwnedBy, [SketchArcProxy](../objects/SketchArcProxy.md).OwnedBy, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).AddArcSlotByCenterPointArc, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).AddArcSlotByThreePointArc, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).AddStraightSlotByCenterToCenter, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).AddStraightSlotByOverall and 48 more (see `members.tsv`)

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchEntity](../objects/SketchEntity.md)

