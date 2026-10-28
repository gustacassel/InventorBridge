# MidpointConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface MidpointConstraintProxy
{
    // Properties
    object Application { get; }
    SketchArc Arc { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    SketchLine Line { get; }
    MidpointConstraint NativeObject { get; }
    Sketch Parent { get; }
    SketchPoint Point { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [MidpointConstraint](../objects/MidpointConstraint.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [SketchArc](../objects/SketchArc.md), [SketchLine](../objects/SketchLine.md), [SketchPoint](../objects/SketchPoint.md)

