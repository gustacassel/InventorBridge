# GraphicsDataSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.GraphicsDataSetsCollection.Item[…].Item[…]`

```csharp
interface GraphicsDataSet
{
    // Properties
    int Count { get; }
    int Id { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void Remove(int Index);
}
```

**Returned by:** [GraphicsDataSets](../objects/GraphicsDataSets.md).Item, [GraphicsDataSets](../objects/GraphicsDataSets.md).ItemById

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

