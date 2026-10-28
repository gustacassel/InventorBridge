# PointAndTangentWorkPlaneDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PointAndTangentWorkPlaneDef
{
    // Properties
    object Application { get; }
    Face Face { get; }
    WorkPlane Parent { get; }
    object Point { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out object Point, out Face Face);
}
```

**Referenced types:** [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WorkPlane](../objects/WorkPlane.md)

