# PlaneAndPointWorkPlaneDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PlaneAndPointWorkPlaneDef
{
    // Properties
    object Application { get; }
    WorkPlane Parent { get; }
    object Plane { get; }
    object Point { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out object Plane, out object Point);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WorkPlane](../objects/WorkPlane.md)

