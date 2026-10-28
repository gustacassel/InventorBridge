# GripSnapOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.GeneralOptions.GripSnapOptions`

```csharp
interface GripSnapOptions
{
    // Properties
    object Application { get; }
    bool DisplayObjectInOriginalLocation { get; set; }
    bool SelectGroundedComponentsAndWorkGeometry { get; set; }
    bool ShowDegreesOfFreedom { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseFreeDrag { get; set; }
    bool UseTemporaryConstraints { get; set; }
}
```

**Returned by:** [GeneralOptions](../objects/GeneralOptions.md).GripSnapOptions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

