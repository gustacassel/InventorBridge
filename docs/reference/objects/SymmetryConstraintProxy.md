# SymmetryConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface SymmetryConstraintProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    SketchEntity EntityOne { get; }
    SketchEntity EntityTwo { get; }
    SymmetryConstraint NativeObject { get; }
    Sketch Parent { get; }
    SketchLine SymmetryLine { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [SketchEntity](../objects/SketchEntity.md), [SketchLine](../objects/SketchLine.md), [SymmetryConstraint](../objects/SymmetryConstraint.md)

