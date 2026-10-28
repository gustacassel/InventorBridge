# Profile3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface Profile3DProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    int Count { get; }
    ProfilePath3D Item[int Index] { get; }
    Profile3D NativeObject { get; }
    Sketch3D Parent { get; }
    ObjectTypeEnum Type { get; }
    Wires Wires { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Profile3D](../objects/Profile3D.md), [ProfilePath3D](../objects/ProfilePath3D.md), [Sketch3D](../objects/Sketch3D.md), [Wires](../objects/Wires.md)

