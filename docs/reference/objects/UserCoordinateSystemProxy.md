# UserCoordinateSystemProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [UserCoordinateSystem](../objects/UserCoordinateSystem.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.UserCoordinateSystems.Item[…] → (UserCoordinateSystemProxy)`

```csharp
interface UserCoordinateSystemProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    UserCoordinateSystemDefinition Definition { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsOwnedByFeature { get; }
    string Name { get; set; }
    UserCoordinateSystem NativeObject { get; }
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

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [PartFeature](../objects/PartFeature.md), [UserCoordinateSystem](../objects/UserCoordinateSystem.md), [UserCoordinateSystemDefinition](../objects/UserCoordinateSystemDefinition.md), [WorkAxis](../objects/WorkAxis.md), [WorkPlane](../objects/WorkPlane.md), [WorkPoint](../objects/WorkPoint.md)

