# NormalToCurveWorkPlaneDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface NormalToCurveWorkPlaneDef
{
    // Properties
    object Application { get; }
    object CurveEntity { get; }
    WorkPlane Parent { get; }
    object Point { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out object CurveEntity, out object Point);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WorkPlane](../objects/WorkPlane.md)

