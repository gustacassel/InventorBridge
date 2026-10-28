# Profiles3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].Profiles3D`

```csharp
interface Profiles3D
{
    // Properties
    object Application { get; }
    int Count { get; }
    Profile3D Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Profile3D AddClosed();
    Profile3D AddOpen();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).Profiles3D, [Sketch3DProxy](../objects/Sketch3DProxy.md).Profiles3D

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Profile3D](../objects/Profile3D.md)

