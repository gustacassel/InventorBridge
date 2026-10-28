# UserCoordinateSystemDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.UserCoordinateSystems.Item[…].Definition`

```csharp
interface UserCoordinateSystemDefinition
{
    // Properties
    object Application { get; }
    UCSDefinitionTypeEnum DefinitionType { get; }
    UserCoordinateSystem Parent { get; }
    Matrix Transformation { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void GetByThreePoints(out object Origin, out object XDirectionPoint, out object YDirectionPoint);
    void SetByThreePoints(object Origin, object XDirectionPoint, object YDirectionPoint);
}
```

**Returned by:** [UserCoordinateSystem](../objects/UserCoordinateSystem.md).Definition, [UserCoordinateSystemProxy](../objects/UserCoordinateSystemProxy.md).Definition, [UserCoordinateSystems](../objects/UserCoordinateSystems.md).CreateDefinition

**Referenced types:** [Matrix](../objects/Matrix.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [UCSDefinitionTypeEnum](../enums/UCSDefinitionTypeEnum.md), [UserCoordinateSystem](../objects/UserCoordinateSystem.md)

