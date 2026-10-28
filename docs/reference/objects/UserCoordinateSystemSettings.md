# UserCoordinateSystemSettings

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ModelingSettings.UserCoordinateSystemSettings`

```csharp
interface UserCoordinateSystemSettings
{
    // Properties
    object Application { get; }
    CoordinateSystemPlaneEnum DefaultPlane { get; set; }
    string NamingPrefix { get; set; }
    bool ShowOrigin { get; set; }
    bool ShowTriad { get; set; }
    bool ShowXAxis { get; set; }
    bool ShowXYPlane { get; set; }
    bool ShowXZPlane { get; set; }
    bool ShowYAxis { get; set; }
    bool ShowYZPlane { get; set; }
    bool ShowZAxis { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [ModelingSettings](../objects/ModelingSettings.md).UserCoordinateSystemSettings

**Referenced types:** [CoordinateSystemPlaneEnum](../enums/CoordinateSystemPlaneEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

