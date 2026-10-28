# ThreePointsWorkPlaneDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ThreePointsWorkPlaneDef
{
    // Properties
    object Application { get; }
    WorkPlane Parent { get; }
    object Point1 { get; }
    object Point2 { get; }
    object Point3 { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out object Point1, out object Point2, out object Point3);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WorkPlane](../objects/WorkPlane.md)

