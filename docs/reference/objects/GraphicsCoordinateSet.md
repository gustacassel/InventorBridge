# GraphicsCoordinateSet

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GraphicsDataSet](../objects/GraphicsDataSet.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument.GraphicsDataSetsCollection.Item[…].Item[…] → (GraphicsCoordinateSet)`

```csharp
interface GraphicsCoordinateSet
{
    // Properties
    Point Coordinate[int Index] { get; set; }
    int Count { get; }
    int Id { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(int Index, Point Coordinate);
    void Delete();
    void GetCoordinates(out double[] Coordinates);
    void PutCoordinates(out double[] Coordinates);
    void Remove(int Index);
}
```

**Returned by:** [GraphicsDataSets](../objects/GraphicsDataSets.md).CreateCoordinateSet, [LineGraphics](../objects/LineGraphics.md).CoordinateSet, [LineStripGraphics](../objects/LineStripGraphics.md).CoordinateSet, [PointGraphics](../objects/PointGraphics.md).CoordinateSet, [PresentationMeshFeatureEntity](../objects/PresentationMeshFeatureEntity.md).CoordinateSet, [TriangleFanGraphics](../objects/TriangleFanGraphics.md).CoordinateSet, [TriangleGraphics](../objects/TriangleGraphics.md).CoordinateSet, [TriangleStripGraphics](../objects/TriangleStripGraphics.md).CoordinateSet

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

