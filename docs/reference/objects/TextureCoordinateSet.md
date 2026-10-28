# TextureCoordinateSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Faces.Item[…].TextureMaps.Item[…].GetTextureCoordinateSet(…)`

```csharp
interface TextureCoordinateSet
{
    // Properties
    object Application { get; }
    int Count { get; }
    Point Item[int Index] { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetCoordinates(out double[] Coordinates);
}
```

**Returned by:** [TextureMap](../objects/TextureMap.md).GetTextureCoordinateSet

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

