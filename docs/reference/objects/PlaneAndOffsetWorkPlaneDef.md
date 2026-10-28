# PlaneAndOffsetWorkPlaneDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PlaneAndOffsetWorkPlaneDef
{
    // Properties
    object Application { get; }
    Parameter Offset { get; }
    WorkPlane Parent { get; }
    object Plane { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out object Plane, out Parameter Offset);
}
```

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [WorkPlane](../objects/WorkPlane.md)

