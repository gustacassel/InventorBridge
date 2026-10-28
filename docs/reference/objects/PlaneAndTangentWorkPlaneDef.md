# PlaneAndTangentWorkPlaneDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PlaneAndTangentWorkPlaneDef
{
    // Properties
    object Application { get; }
    Face Face { get; }
    WorkPlane Parent { get; }
    object Plane { get; }
    Point ProximityPoint { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out object Plane, out Face Face, out Point ProximityPoint);
}
```

**Referenced types:** [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [WorkPlane](../objects/WorkPlane.md)

