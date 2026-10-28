# GraphicsColorMapper

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.GraphicsDataSetsCollection.Item[…].CreateColorMapper(…)`

```csharp
interface GraphicsColorMapper
{
    // Properties
    Color Color[int Index] { get; set; }
    int ColorCount { get; }
    Color MappedColor[double Value] { get; }
    ObjectTypeEnum Type { get; }
    double Value[int Index] { get; set; }
    int ValueCount { get; }
    // Methods
    void Delete();
    void GetColors(out byte[] Colors);
    void GetValues(out double[] Values);
    void PutColors(ref byte[] Colors);
    void PutValues(ref double[] Values);
}
```

**Returned by:** [GraphicsDataSets](../objects/GraphicsDataSets.md).CreateColorMapper, [TriangleFanGraphics](../objects/TriangleFanGraphics.md).ColorMapper, [TriangleGraphics](../objects/TriangleGraphics.md).ColorMapper, [TriangleStripGraphics](../objects/TriangleStripGraphics.md).ColorMapper

**Referenced types:** [Color](../objects/Color.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

