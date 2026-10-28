# EqualLengthConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface EqualLengthConstraintProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    SketchLine LineOne { get; }
    SketchLine LineTwo { get; }
    EqualLengthConstraint NativeObject { get; }
    Sketch Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [EqualLengthConstraint](../objects/EqualLengthConstraint.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [SketchLine](../objects/SketchLine.md)

