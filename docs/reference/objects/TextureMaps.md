# TextureMaps

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Faces.Item[…].TextureMaps`

```csharp
interface TextureMaps
{
    // Properties
    object Application { get; }
    int Count { get; }
    TextureMap Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Face](../objects/Face.md).TextureMaps, [FaceProxy](../objects/FaceProxy.md).TextureMaps

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [TextureMap](../objects/TextureMap.md)

