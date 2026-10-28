# CoincidentConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface CoincidentConstraintProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    SketchEntity EntityOne { get; }
    SketchEntity EntityTwo { get; }
    CoincidentConstraint NativeObject { get; }
    Sketch Parent { get; }
    bool StartOrEndPointConstraint { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [CoincidentConstraint](../objects/CoincidentConstraint.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [SketchEntity](../objects/SketchEntity.md)

