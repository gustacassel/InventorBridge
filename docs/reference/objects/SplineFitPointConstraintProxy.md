# SplineFitPointConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface SplineFitPointConstraintProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    SplineFitPointConstraint NativeObject { get; }
    Sketch Parent { get; }
    SketchPoint Point { get; }
    SketchSpline Spline { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [SketchPoint](../objects/SketchPoint.md), [SketchSpline](../objects/SketchSpline.md), [SplineFitPointConstraint](../objects/SplineFitPointConstraint.md)

