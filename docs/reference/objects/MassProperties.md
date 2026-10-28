# MassProperties

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.MassProperties`

```csharp
interface MassProperties
{
    // Properties
    MassPropertiesAccuracyEnum Accuracy { get; set; }
    double Area { get; }
    MassPropertiesAccuracyEnum AvailableAccuracy { get; }
    bool CacheResultsOnCompute { get; set; }
    Point CenterOfMass { get; }
    bool IncludeCosmeticWelds { get; set; }
    bool IncludeQuantityOverrides { get; set; }
    double Mass { get; set; }
    bool MassOverridden { get; set; }
    ObjectTypeEnum Type { get; }
    double Volume { get; set; }
    bool VolumeOverridden { get; set; }
    // Methods
    void AchievedAccuracy(out double AchievedAccuracyArea, out double AchievedAccuracyVolume);
    void PrincipalMomentsOfInertia(out double I1, out double I2, out double I3);
    void RadiusOfGyration(out double Kx, out double Ky, out double Kz);
    void RotationToPrincipal(out double Rx, out double Ry, out double Rz);
    void XYZMomentsOfInertia(out double Ixx, out double Iyy, out double Izz, out double Ixy, out double Iyz, out double Ixz);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).MassProperties, [ComponentOccurrence](../objects/ComponentOccurrence.md).MassProperties, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).MassProperties, [FlatPattern](../objects/FlatPattern.md).MassProperties, [PartComponentDefinition](../objects/PartComponentDefinition.md).MassProperties, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).MassProperties, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).MassProperties

**Referenced types:** [MassPropertiesAccuracyEnum](../enums/MassPropertiesAccuracyEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

