# TextureMap

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Faces.Item[…].TextureMaps.Item[…]`

```csharp
interface TextureMap
{
    // Properties
    object Application { get; }
    IPictureDisp Image { get; }
    Color MaskColor { get; }
    object Parent { get; }
    Matrix Transformation { get; }
    ObjectTypeEnum Type { get; }
    bool UseMask { get; }
    // Methods
    void GenerateImage(string FileName);
    TextureCoordinateSet GetTextureCoordinateSet(double Tolerance);
}
```

**Returned by:** [TextureMaps](../objects/TextureMaps.md).Item

**Referenced types:** [Color](../objects/Color.md), [IPictureDisp](../objects/IPictureDisp.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [TextureCoordinateSet](../objects/TextureCoordinateSet.md)

