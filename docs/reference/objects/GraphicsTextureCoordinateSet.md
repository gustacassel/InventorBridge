# GraphicsTextureCoordinateSet

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GraphicsDataSet](../objects/GraphicsDataSet.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument.GraphicsDataSetsCollection.Item[…].Item[…] → (GraphicsTextureCoordinateSet)`

```csharp
interface GraphicsTextureCoordinateSet
{
    // Properties
    object Coordinate[int Index] { get; set; }
    int Count { get; }
    int Id { get; }
    TextureDimensionEnum TextureDimension { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(int Index, object Coordinate);
    void Delete();
    void GetCoordinates(out double[] Coordinates);
    void PutCoordinates(ref double[] Coordinates);
    void Remove(int Index);
}
```

**Returned by:** [GraphicsDataSets](../objects/GraphicsDataSets.md).CreateTextureCoordinateSet, [TriangleFanGraphics](../objects/TriangleFanGraphics.md).TextureCoordinateSet, [TriangleGraphics](../objects/TriangleGraphics.md).TextureCoordinateSet, [TriangleStripGraphics](../objects/TriangleStripGraphics.md).TextureCoordinateSet

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [TextureDimensionEnum](../enums/TextureDimensionEnum.md)

