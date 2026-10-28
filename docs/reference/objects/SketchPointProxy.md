# SketchPointProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchPoint](../objects/SketchPoint.md) → [SketchEntity](../objects/SketchEntity.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SketchBlockDefinitions.Item[…].InsertionPoint → (SketchPointProxy)`

```csharp
interface SketchPointProxy
{
    // Properties
    object Application { get; }
    SketchEntitiesEnumerator AttachedEntities { get; }
    AttributeSets AttributeSets { get; }
    bool ConnectionPoint { get; set; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraintsEnumerator Constraints { get; }
    bool Construction { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    SketchBlock ContainingSketchBlock { get; }
    ActionTypeEnum DisabledActionTypes { get; set; }
    Point2d Geometry { get; }
    Point Geometry3d { get; }
    bool HasReferenceComponent { get; }
    bool HoleCenter { get; set; }
    bool InsertionPoint { get; set; }
    Layer Layer { get; set; }
    SketchPoint NativeObject { get; }
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
    void Merge(SketchPoint SketchPoint);
    void MoveBy(Vector2d Vector);
    void MoveTo(Point2d Point);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [ActionTypeEnum](../enums/ActionTypeEnum.md), [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Point2d](../objects/Point2d.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch](../objects/Sketch.md), [SketchBlock](../objects/SketchBlock.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md), [SketchConstraintsEnumerator](../objects/SketchConstraintsEnumerator.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md), [SketchPoint](../objects/SketchPoint.md), [Vector2d](../objects/Vector2d.md)

