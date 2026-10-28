# UserCoordinateSystems

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.UserCoordinateSystems`

```csharp
interface UserCoordinateSystems
{
    // Properties
    object Application { get; }
    int Count { get; }
    UserCoordinateSystem Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    UserCoordinateSystem Add(UserCoordinateSystemDefinition Definition);
    UserCoordinateSystemDefinition CreateDefinition();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).UserCoordinateSystems, [FlatPattern](../objects/FlatPattern.md).UserCoordinateSystems, [PartComponentDefinition](../objects/PartComponentDefinition.md).UserCoordinateSystems, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).UserCoordinateSystems, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).UserCoordinateSystems

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [UserCoordinateSystem](../objects/UserCoordinateSystem.md), [UserCoordinateSystemDefinition](../objects/UserCoordinateSystemDefinition.md)

