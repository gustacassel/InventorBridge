# PathProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PathProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Closed { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    int Count { get; }
    PathEntity Item[int Index] { get; }
    Path NativeObject { get; }
    ObjectTypeEnum Type { get; }
    Wires Wires { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Path](../objects/Path.md), [PathEntity](../objects/PathEntity.md), [Wires](../objects/Wires.md)

