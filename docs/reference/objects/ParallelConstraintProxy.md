# ParallelConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ParallelConstraintProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    SketchEntity EntityOne { get; }
    SketchEntity EntityTwo { get; }
    ParallelConstraint NativeObject { get; }
    Sketch Parent { get; }
    ObjectTypeEnum Type { get; }
    bool UseEllipseOneMajorAxis { get; }
    bool UseEllipseTwoMajorAxis { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ParallelConstraint](../objects/ParallelConstraint.md), [Sketch](../objects/Sketch.md), [SketchEntity](../objects/SketchEntity.md)

