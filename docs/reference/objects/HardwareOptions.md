# HardwareOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.HardwareOptions`

```csharp
interface HardwareOptions
{
    // Properties
    object Application { get; }
    string Diagnostics { get; }
    bool EnableViewportGPURayTracing { get; set; }
    GraphicsDriverTypeEnum GraphicsDriverType { get; set; }
    GraphicsSettingTypeEnum GraphicsSettingType { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseSoftwareGraphics { get; set; }
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).HardwareOptions, [ApprenticeServer](../objects/ApprenticeServer.md).HardwareOptions, [ApprenticeServerComponent](../objects/ApprenticeServerComponent.md).HardwareOptions, [InventorServer](../objects/InventorServer.md).HardwareOptions

**Referenced types:** [GraphicsDriverTypeEnum](../enums/GraphicsDriverTypeEnum.md), [GraphicsSettingTypeEnum](../enums/GraphicsSettingTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

