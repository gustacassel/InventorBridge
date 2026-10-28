# PublicationEvents

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PublicationEvents
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnModelingDataUpdate(PresentationDocument DocumentObject, Publication Publication, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
}
```

**Referenced types:** [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationDocument](../objects/PresentationDocument.md)

