# GraphicsColorSet

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GraphicsDataSet](../objects/GraphicsDataSet.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument.GraphicsDataSetsCollection.Item[…].Item[…] → (GraphicsColorSet)`

```csharp
interface GraphicsColorSet
{
    // Properties
    Color Color[int Index] { get; set; }
    int Count { get; }
    int Id { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(int Index, byte Red, byte Green, byte Blue);
    void Delete();
    void GetColors(out byte[] Colors);
    void PutColors(out byte[] Colors);
    void Remove(int Index);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [GraphicsDataSets](../objects/GraphicsDataSets.md).CreateColorSet, [LineGraphics](../objects/LineGraphics.md).ColorSet, [LineStripGraphics](../objects/LineStripGraphics.md).ColorSet, [PresentationMeshFeatureEntity](../objects/PresentationMeshFeatureEntity.md).ColorSet, [TriangleFanGraphics](../objects/TriangleFanGraphics.md).ColorSet, [TriangleGraphics](../objects/TriangleGraphics.md).ColorSet, [TriangleStripGraphics](../objects/TriangleStripGraphics.md).ColorSet

**Referenced types:** [Color](../objects/Color.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

