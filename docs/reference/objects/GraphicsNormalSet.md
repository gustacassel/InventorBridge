# GraphicsNormalSet

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GraphicsDataSet](../objects/GraphicsDataSet.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument.GraphicsDataSetsCollection.Item[…].Item[…] → (GraphicsNormalSet)`

```csharp
interface GraphicsNormalSet
{
    // Properties
    int Count { get; }
    int Id { get; }
    UnitVector Normal[int Index] { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(int Index, UnitVector Normal);
    void Delete();
    void GetNormals(out double[] Normals);
    void PutNormals(out double[] Normals);
    void Remove(int Index);
}
```

**Returned by:** [GraphicsDataSets](../objects/GraphicsDataSets.md).CreateNormalSet, [PresentationMeshFeatureEntity](../objects/PresentationMeshFeatureEntity.md).NormalSet, [TriangleFanGraphics](../objects/TriangleFanGraphics.md).NormalSet, [TriangleGraphics](../objects/TriangleGraphics.md).NormalSet, [TriangleStripGraphics](../objects/TriangleStripGraphics.md).NormalSet

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [UnitVector](../objects/UnitVector.md)

