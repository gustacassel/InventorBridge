# ConcentricConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ConcentricConstraintProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool CenterPointConstraint { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    SketchEntity EntityOne { get; }
    SketchEntity EntityTwo { get; }
    ConcentricConstraint NativeObject { get; }
    Sketch Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConcentricConstraint](../objects/ConcentricConstraint.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [SketchEntity](../objects/SketchEntity.md)

