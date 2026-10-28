# PartEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.PartEvents`

```csharp
interface PartEvents
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnSurfaceBodyChanged(NameValueMap Context, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [FlatPattern](../objects/FlatPattern.md).PartEvents, [PartComponentDefinition](../objects/PartComponentDefinition.md).PartEvents, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).PartEvents

**Referenced types:** [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

