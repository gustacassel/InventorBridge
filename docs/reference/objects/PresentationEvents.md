# PresentationEvents

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface PresentationEvents
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnDelete(PresentationDocument DocumentObject, Publication PublicationObj, object pEntity, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewPublication(PresentationDocument DocumentObject, Publication PublicationObject, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewPublicationMarkedView(PresentationDocument DocumentObject, Publication PublicationObj, PublicationMarkedView PublicationMarkedViewObj, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnPublicationComponentChange(PresentationDocument DocumentObject, PublicationComponent PublicationComponent, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnPublicationDesignViewChange(PresentationDocument DocumentObject, Publication PublicationObj, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnPublicationModelingDataUpdate(Publication Publication, CommandTypesEnum ReasonsForChange, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnPublicationNameChange(PresentationDocument DocumentObject, Publication PublicationObj, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnStoryboardChange(Publication PublicationObj, Storyboard StoryboardObj, CommandTypesEnum ReasonsForChange, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Referenced types:** [CommandTypesEnum](../enums/CommandTypesEnum.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationDocument](../objects/PresentationDocument.md)

