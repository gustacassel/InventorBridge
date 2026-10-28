# FixedWorkAxisDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface FixedWorkAxisDef
{
    // Properties
    object Application { get; }
    UnitVector Axis { get; }
    Point OriginPoint { get; }
    WorkAxis Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out Point OriginPoint, out UnitVector Axis);
    void PutData(Point OriginPoint, UnitVector Axis);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md), [WorkAxis](../objects/WorkAxis.md)

