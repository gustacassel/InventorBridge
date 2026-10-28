# RegionProperties

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].Profiles.Item[…].RegionProperties`

```csharp
interface RegionProperties
{
    // Properties
    AccuracyEnum Accuracy { get; set; }
    object Application { get; }
    double Area { get; }
    object Centroid { get; }
    object Parent { get; }
    double Perimeter { get; }
    double RotationAngle { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void CentroidMomentsOfInertia(out double Ixx, out double Iyy, out double Izz, out double Ixy, out double Iyz, out double Ixz);
    void GetTorsionProperties(out double Torsion, out double WorstStressValue, out Point WorstStressPosition, int FiniteElementNodeCount = 10000);
    void MomentsOfInertia(out double Ixx, out double Iyy, out double Izz, out double Ixy, out double Iyz, out double Ixz);
    void PrincipalAxes(out Vector XAxis, out Vector YAxis);
    void PrincipalMomentsOfInertia(out double Ix, out double Iy, out double Iz);
    void RadiusOfGyration(out double Kxx, out double Kyy, out double Kzz);
}
```

**Returned by:** [Profile](../objects/Profile.md).RegionProperties, [ProfileProxy](../objects/ProfileProxy.md).RegionProperties

**Referenced types:** [AccuracyEnum](../enums/AccuracyEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [Vector](../objects/Vector.md)

