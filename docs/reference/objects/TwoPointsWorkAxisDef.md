# TwoPointsWorkAxisDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface TwoPointsWorkAxisDef
{
    // Properties
    object Application { get; }
    WorkAxis Parent { get; }
    object Point1 { get; }
    object Point2 { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out object Point1, out object Point2);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WorkAxis](../objects/WorkAxis.md)

