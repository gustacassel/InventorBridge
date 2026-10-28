# GraphicsImageSet

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [GraphicsDataSet](../objects/GraphicsDataSet.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument.GraphicsDataSetsCollection.Item[…].Item[…] → (GraphicsImageSet)`

```csharp
interface GraphicsImageSet
{
    // Properties
    int Count { get; }
    int Id { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(int Index, IPictureDisp Image, object TransparentColor = Missing, int HotPointX = -1, int HotPointY = -1);
    void Delete();
    void Remove(int Index);
}
```

**Returned by:** [GraphicsDataSets](../objects/GraphicsDataSets.md).CreateImageSet

**Referenced types:** [IPictureDisp](../objects/IPictureDisp.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

