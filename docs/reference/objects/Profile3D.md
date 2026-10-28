# Profile3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].Profiles3D.Item[…]`

```csharp
interface Profile3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    int Count { get; }
    ProfilePath3D Item[int Index] { get; }
    Sketch3D Parent { get; }
    ObjectTypeEnum Type { get; }
    Wires Wires { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Profile3DProxy](../objects/Profile3DProxy.md).NativeObject, [ProfilePath3D](../objects/ProfilePath3D.md).Parent, [ProfilePath3DProxy](../objects/ProfilePath3DProxy.md).Parent, [Profiles3D](../objects/Profiles3D.md).AddClosed, [Profiles3D](../objects/Profiles3D.md).AddOpen, [Profiles3D](../objects/Profiles3D.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProfilePath3D](../objects/ProfilePath3D.md), [Sketch3D](../objects/Sketch3D.md), [Wires](../objects/Wires.md)

