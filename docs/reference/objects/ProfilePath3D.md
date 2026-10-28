# ProfilePath3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].Profiles3D.Item[…].Item[…]`

```csharp
interface ProfilePath3D
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool Closed { get; }
    int Count { get; }
    ProfileEntity3D Item[int Index] { get; }
    Profile3D Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Profile3D](../objects/Profile3D.md).Item, [Profile3DProxy](../objects/Profile3DProxy.md).Item, [ProfileEntity3D](../objects/ProfileEntity3D.md).Parent, [ProfileEntity3DProxy](../objects/ProfileEntity3DProxy.md).Parent, [ProfilePath3DProxy](../objects/ProfilePath3DProxy.md).NativeObject

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Profile3D](../objects/Profile3D.md), [ProfileEntity3D](../objects/ProfileEntity3D.md)

