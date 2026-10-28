# LinePlaneAndAngleWorkPlaneDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface LinePlaneAndAngleWorkPlaneDef
{
    // Properties
    Parameter Angle { get; }
    object Application { get; }
    object Line { get; }
    WorkPlane Parent { get; }
    object Plane { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out object Line, out object Plane, out Parameter Angle);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [WorkPlane](../objects/WorkPlane.md)

