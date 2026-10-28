# FixedWorkPlaneDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface FixedWorkPlaneDef
{
    // Properties
    object Application { get; }
    Point OriginPoint { get; }
    WorkPlane Parent { get; }
    ObjectTypeEnum Type { get; }
    UnitVector XAxis { get; }
    UnitVector YAxis { get; }
    // Methods
    void GetData(out Point OriginPoint, out UnitVector XAxis, out UnitVector YAxis);
    void PutData(Point OriginPoint, UnitVector XAxis, UnitVector YAxis);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [UnitVector](../objects/UnitVector.md), [WorkPlane](../objects/WorkPlane.md)

