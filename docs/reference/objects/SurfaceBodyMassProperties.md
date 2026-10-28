# SurfaceBodyMassProperties

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].MassProperties`

```csharp
interface SurfaceBodyMassProperties
{
    // Properties
    object Application { get; }
    double Area { get; }
    Point CenterOfMass { get; }
    double Mass { get; }
    SurfaceBody Parent { get; }
    ObjectTypeEnum Type { get; }
    double Volume { get; }
    // Methods
    void PrincipalMomentsOfInertia(out double I1, out double I2, out double I3, object OverriddenMass = Missing);
    void XYZMomentsOfInertia(out double Ixx, out double Iyy, out double Izz, out double Ixy, out double Iyz, out double Ixz, object OverriddenMass = Missing);
}
```

**Returned by:** [SurfaceBody](../objects/SurfaceBody.md).MassProperties, [SurfaceBodyProxy](../objects/SurfaceBodyProxy.md).MassProperties

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [SurfaceBody](../objects/SurfaceBody.md)

