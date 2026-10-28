# HelpEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.HelpManager.HelpEvents`

```csharp
interface HelpEvents
{
    // Properties
    object Application { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnApplicationHelp(NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [HelpManager](../objects/HelpManager.md).HelpEvents

**Referenced types:** [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

