# VerticalAlignConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface VerticalAlignConstraintProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    VerticalAlignConstraint NativeObject { get; }
    Sketch Parent { get; }
    SketchPoint PointOne { get; }
    SketchPoint PointTwo { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [SketchPoint](../objects/SketchPoint.md), [VerticalAlignConstraint](../objects/VerticalAlignConstraint.md)

