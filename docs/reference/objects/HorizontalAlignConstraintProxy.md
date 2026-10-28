# HorizontalAlignConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface HorizontalAlignConstraintProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    HorizontalAlignConstraint NativeObject { get; }
    Sketch Parent { get; }
    SketchPoint PointOne { get; }
    SketchPoint PointTwo { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [HorizontalAlignConstraint](../objects/HorizontalAlignConstraint.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [SketchPoint](../objects/SketchPoint.md)

