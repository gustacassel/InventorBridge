# BendConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface BendConstraintProxy
{
    // Properties
    object Application { get; }
    SketchArc3D Arc { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    SketchLine3D LineOne { get; }
    SketchLine3D LineTwo { get; }
    BendConstraint NativeObject { get; }
    Sketch3D Parent { get; }
    Parameter Radius { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [BendConstraint](../objects/BendConstraint.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [Sketch3D](../objects/Sketch3D.md), [SketchArc3D](../objects/SketchArc3D.md), [SketchLine3D](../objects/SketchLine3D.md)

