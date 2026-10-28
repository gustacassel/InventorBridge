# ProfilePath3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ProfilePath3DProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Closed { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    int Count { get; }
    ProfileEntity3D Item[int Index] { get; }
    ProfilePath3D NativeObject { get; }
    Profile3D Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Profile3D](../objects/Profile3D.md), [ProfileEntity3D](../objects/ProfileEntity3D.md), [ProfilePath3D](../objects/ProfilePath3D.md)

