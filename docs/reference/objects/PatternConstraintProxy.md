# PatternConstraintProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PatternConstraintProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool Deletable { get; }
    PatternConstraint NativeObject { get; }
    Sketch Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PatternConstraint](../objects/PatternConstraint.md), [Sketch](../objects/Sketch.md)

