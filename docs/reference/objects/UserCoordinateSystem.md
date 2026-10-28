# UserCoordinateSystem

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.UserCoordinateSystems.Item[…]`

```csharp
interface UserCoordinateSystem
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    UserCoordinateSystemDefinition Definition { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsOwnedByFeature { get; }
    string Name { get; set; }
    WorkPoint Origin { get; }
    PartFeature OwnedBy { get; }
    ComponentDefinition Parent { get; }
    Matrix Transformation { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    Parameter XAngle { get; }
    WorkAxis XAxis { get; }
    Parameter XOffset { get; }
    WorkPlane XYPlane { get; }
    WorkPlane XZPlane { get; }
    Parameter YAngle { get; }
    WorkAxis YAxis { get; }
    Parameter YOffset { get; }
    WorkPlane YZPlane { get; }
    Parameter ZAngle { get; }
    WorkAxis ZAxis { get; }
    Parameter ZOffset { get; }
    // Methods
    void Delete(bool RetainDependentFeaturesAndSketches = false, bool RetainDependentWorkFeatures = false);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetEndOfPart(bool Before);
}
```

**Returned by:** [BIMComponentDescription](../objects/BIMComponentDescription.md).UserCoordinateSystemOrientation, [UserCoordinateSystemDefinition](../objects/UserCoordinateSystemDefinition.md).Parent, [UserCoordinateSystemProxy](../objects/UserCoordinateSystemProxy.md).NativeObject, [UserCoordinateSystems](../objects/UserCoordinateSystems.md).Add, [UserCoordinateSystems](../objects/UserCoordinateSystems.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [PartFeature](../objects/PartFeature.md), [UserCoordinateSystemDefinition](../objects/UserCoordinateSystemDefinition.md), [WorkAxis](../objects/WorkAxis.md), [WorkPlane](../objects/WorkPlane.md), [WorkPoint](../objects/WorkPoint.md)

