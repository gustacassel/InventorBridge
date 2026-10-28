# OffsetConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface OffsetConstraintProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    SketchEntity EntityFour { get; }
    SketchEntity EntityOne { get; }
    SketchEntity EntityThree { get; }
    SketchEntity EntityTwo { get; }
    OffsetConstraint NativeObject { get; }
    Sketch Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OffsetConstraint](../objects/OffsetConstraint.md), [Sketch](../objects/Sketch.md), [SketchEntity](../objects/SketchEntity.md)

