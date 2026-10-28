# SketchEntity

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].SketchEntities.Item[…]`

```csharp
interface SketchEntity
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraintsEnumerator Constraints { get; }
    bool Construction { get; set; }
    SketchBlock ContainingSketchBlock { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    bool HasReferenceComponent { get; }
    Layer Layer { get; set; }
    SketchEntitiesEnumerator OwnedBy { get; }
    Sketch Parent { get; }
    Box2d RangeBox { get; }
    bool Reference { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    object ReferencedEntity { get; }
    SketchBlocksEnumerator SketchBlockPath { get; }
    bool SketchOnly { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ArcLengthDimConstraint](../objects/ArcLengthDimConstraint.md).Entity, [ArcLengthDimConstraintProxy](../objects/ArcLengthDimConstraintProxy.md).Entity, [CoincidentConstraint](../objects/CoincidentConstraint.md).EntityOne, [CoincidentConstraint](../objects/CoincidentConstraint.md).EntityTwo, [CoincidentConstraintProxy](../objects/CoincidentConstraintProxy.md).EntityOne, [CoincidentConstraintProxy](../objects/CoincidentConstraintProxy.md).EntityTwo, [CollinearConstraint](../objects/CollinearConstraint.md).EntityOne, [CollinearConstraint](../objects/CollinearConstraint.md).EntityTwo, [CollinearConstraintProxy](../objects/CollinearConstraintProxy.md).EntityOne, [CollinearConstraintProxy](../objects/CollinearConstraintProxy.md).EntityTwo, [ConcentricConstraint](../objects/ConcentricConstraint.md).EntityOne, [ConcentricConstraint](../objects/ConcentricConstraint.md).EntityTwo, [ConcentricConstraintProxy](../objects/ConcentricConstraintProxy.md).EntityOne, [ConcentricConstraintProxy](../objects/ConcentricConstraintProxy.md).EntityTwo, [DiameterDimConstraint](../objects/DiameterDimConstraint.md).Entity, [DiameterDimConstraintProxy](../objects/DiameterDimConstraintProxy.md).Entity, [DrawingSketch](../objects/DrawingSketch.md).AddByProjectingEntity, [EllipseRadiusDimConstraint](../objects/EllipseRadiusDimConstraint.md).Entity, [EllipseRadiusDimConstraintProxy](../objects/EllipseRadiusDimConstraintProxy.md).Entity, [EqualRadiusConstraint](../objects/EqualRadiusConstraint.md).EntityOne, [EqualRadiusConstraint](../objects/EqualRadiusConstraint.md).EntityTwo, [EqualRadiusConstraintProxy](../objects/EqualRadiusConstraintProxy.md).EntityOne, [EqualRadiusConstraintProxy](../objects/EqualRadiusConstraintProxy.md).EntityTwo, [GroundConstraint](../objects/GroundConstraint.md).Entity, [GroundConstraintProxy](../objects/GroundConstraintProxy.md).Entity, [HorizontalConstraint](../objects/HorizontalConstraint.md).Entity, [HorizontalConstraintProxy](../objects/HorizontalConstraintProxy.md).Entity, [OffsetConstraint](../objects/OffsetConstraint.md).EntityFour, [OffsetConstraint](../objects/OffsetConstraint.md).EntityOne, [OffsetConstraint](../objects/OffsetConstraint.md).EntityThree, [OffsetConstraint](../objects/OffsetConstraint.md).EntityTwo, [OffsetConstraintProxy](../objects/OffsetConstraintProxy.md).EntityFour, [OffsetConstraintProxy](../objects/OffsetConstraintProxy.md).EntityOne, [OffsetConstraintProxy](../objects/OffsetConstraintProxy.md).EntityThree, [OffsetConstraintProxy](../objects/OffsetConstraintProxy.md).EntityTwo, [OffsetDimConstraint](../objects/OffsetDimConstraint.md).Entity, [OffsetDimConstraintProxy](../objects/OffsetDimConstraintProxy.md).Entity, [ParallelConstraint](../objects/ParallelConstraint.md).EntityOne, [ParallelConstraint](../objects/ParallelConstraint.md).EntityTwo, [ParallelConstraintProxy](../objects/ParallelConstraintProxy.md).EntityOne and 37 more (see `members.tsv`)

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch](../objects/Sketch.md), [SketchBlock](../objects/SketchBlock.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md), [SketchConstraintsEnumerator](../objects/SketchConstraintsEnumerator.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md)

