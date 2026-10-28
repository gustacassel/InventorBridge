# MeasureTools

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.MeasureTools`

```csharp
interface MeasureTools
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    double GetAngle(object EntityOne, object EntityTwo, object EntityThree = Missing);
    int GetAnglePrecision(Document Document);
    int GetLengthPrecision(Document Document);
    double GetLoopLength(object Curves);
    double GetMinimumDistance(object EntityOne, object EntityTwo, InferredTypeEnum EntityOneInferredType = InferredTypeEnum.kNoInference, InferredTypeEnum EntityTwoInferredType = InferredTypeEnum.kNoInference, out object Context = Missing);
    int SetAnglePrecision(Document Document, int Precision);
    int SetLengthPrecision(Document Document, int Precision);
}
```

**Returned by:** [Application](../objects/Application.md).MeasureTools, [InventorServer](../objects/InventorServer.md).MeasureTools

**Referenced types:** [Document](../objects/Document.md), [InferredTypeEnum](../enums/InferredTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

