# GraphicsDataSets

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.GraphicsDataSetsCollection.Item[…]`

```csharp
interface GraphicsDataSets
{
    // Properties
    object Application { get; }
    string ClientId { get; }
    int Count { get; }
    GraphicsDataSet Item[int Index] { get; }
    GraphicsDataSet ItemById[int DataSetId] { get; }
    bool NonTransacting { get; }
    GraphicsDataSetsCollection Parent { get; }
    bool SaveWithDocument { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    GraphicsColorMapper CreateColorMapper();
    GraphicsColorSet CreateColorSet(int DataSetId);
    GraphicsCoordinateSet CreateCoordinateSet(int DataSetId);
    GraphicsImageSet CreateImageSet(int DataSetId);
    GraphicsIndexSet CreateIndexSet(int DataSetId);
    GraphicsNormalSet CreateNormalSet(int DataSetId);
    GraphicsTextureCoordinateSet CreateTextureCoordinateSet(int DataSetId);
    void Delete();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md).Add, [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md).Item, [InteractionGraphics](../objects/InteractionGraphics.md).GraphicsDataSets

**Referenced types:** [GraphicsColorMapper](../objects/GraphicsColorMapper.md), [GraphicsColorSet](../objects/GraphicsColorSet.md), [GraphicsCoordinateSet](../objects/GraphicsCoordinateSet.md), [GraphicsDataSet](../objects/GraphicsDataSet.md), [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md), [GraphicsImageSet](../objects/GraphicsImageSet.md), [GraphicsIndexSet](../objects/GraphicsIndexSet.md), [GraphicsNormalSet](../objects/GraphicsNormalSet.md), [GraphicsTextureCoordinateSet](../objects/GraphicsTextureCoordinateSet.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

