# HorizontalConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface HorizontalConstraintProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    SketchEntity Entity { get; }
    HorizontalConstraint NativeObject { get; }
    Sketch Parent { get; }
    ObjectTypeEnum Type { get; }
    bool UseEllipseMajorAxis { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [HorizontalConstraint](../objects/HorizontalConstraint.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [SketchEntity](../objects/SketchEntity.md)

