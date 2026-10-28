# ControlDefinitionEvents

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ControlDefinitionEvents
{
    // Properties
    Application Application { get; }
    ControlDefinition Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void FireOnCommandInputs(EventTimingEnum BeforeOrAfter, NameValueMap Context, out NameValueMap Inputs, out HandlingCodeEnum HandlingCode);
    // Events
    event OnCommandInputs(EventTimingEnum BeforeOrAfter, NameValueMap Context, out NameValueMap Inputs, out HandlingCodeEnum HandlingCode);
}
```

**Referenced types:** [Application](../objects/Application.md), [ControlDefinition](../objects/ControlDefinition.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

