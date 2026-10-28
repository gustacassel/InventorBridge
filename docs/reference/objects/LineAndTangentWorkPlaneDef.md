# LineAndTangentWorkPlaneDef

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface LineAndTangentWorkPlaneDef
{
    // Properties
    object Application { get; }
    Face Face { get; }
    object Line { get; }
    WorkPlane Parent { get; }
    Point ProximityPoint { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetData(out object Line, out Face Face, out Point ProximityPoint);
}
```

**Referenced types:** [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [WorkPlane](../objects/WorkPlane.md)

