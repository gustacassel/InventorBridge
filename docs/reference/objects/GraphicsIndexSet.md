# GraphicsIndexSet

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GraphicsDataSet](../objects/GraphicsDataSet.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument.GraphicsDataSetsCollection.Item[…].Item[…] → (GraphicsIndexSet)`

```csharp
interface GraphicsIndexSet
{
    // Properties
    int Count { get; }
    int Id { get; }
    int IndexValue[int Index] { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(int Index, int IndexValue);
    void Delete();
    void GetIndices(out int[] IndexValues);
    void PutIndices(out int[] IndexValues);
    void Remove(int Index);
}
```

**Returned by:** [GraphicsDataSets](../objects/GraphicsDataSets.md).CreateIndexSet, [LineGraphics](../objects/LineGraphics.md).ColorIndexSet, [LineGraphics](../objects/LineGraphics.md).CoordinateIndexSet, [LineStripGraphics](../objects/LineStripGraphics.md).ColorIndexSet, [LineStripGraphics](../objects/LineStripGraphics.md).CoordinateIndexSet, [PointGraphics](../objects/PointGraphics.md).CoordinateIndexSet, [PresentationMeshFeatureEntity](../objects/PresentationMeshFeatureEntity.md).ColorIndexSet, [PresentationMeshFeatureEntity](../objects/PresentationMeshFeatureEntity.md).CoordinateIndexSet, [PresentationMeshFeatureEntity](../objects/PresentationMeshFeatureEntity.md).NormalIndexSet, [TriangleFanGraphics](../objects/TriangleFanGraphics.md).ColorIndexSet, [TriangleFanGraphics](../objects/TriangleFanGraphics.md).CoordinateIndexSet, [TriangleFanGraphics](../objects/TriangleFanGraphics.md).NormalIndexSet, [TriangleFanGraphics](../objects/TriangleFanGraphics.md).TextureCoordinateIndexSet, [TriangleGraphics](../objects/TriangleGraphics.md).ColorIndexSet, [TriangleGraphics](../objects/TriangleGraphics.md).CoordinateIndexSet, [TriangleGraphics](../objects/TriangleGraphics.md).NormalIndexSet, [TriangleGraphics](../objects/TriangleGraphics.md).TextureCoordinateIndexSet, [TriangleStripGraphics](../objects/TriangleStripGraphics.md).ColorIndexSet, [TriangleStripGraphics](../objects/TriangleStripGraphics.md).CoordinateIndexSet, [TriangleStripGraphics](../objects/TriangleStripGraphics.md).NormalIndexSet, [TriangleStripGraphics](../objects/TriangleStripGraphics.md).TextureCoordinateIndexSet

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

