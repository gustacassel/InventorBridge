# RepresentationEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.RepresentationEvents`

```csharp
interface RepresentationEvents
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnActivateDesignView(Document DocumentObject, DesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnActivateDesignViewRepresentation(AssemblyDocument DocumentObject, DesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnActivateLevelOfDetailRepresentation(Document DocumentObject, LevelOfDetailRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnActivatePositionalRepresentation(AssemblyDocument DocumentObject, PositionalRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnDelete(Document DocumentObject, object Entity, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewDesignView(Document DocumentObject, DesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewDesignViewRepresentation(AssemblyDocument DocumentObject, DesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewLevelOfDetailRepresentation(Document DocumentObject, LevelOfDetailRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewPositionalRepresentation(AssemblyDocument DocumentObject, PositionalRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewSectionView(Document DocumentObject, DesignViewRepresentation Representation, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [Application](../objects/Application.md).RepresentationEvents, [InventorServer](../objects/InventorServer.md).RepresentationEvents

**Referenced types:** [AssemblyDocument](../objects/AssemblyDocument.md), [DesignViewRepresentation](../objects/DesignViewRepresentation.md), [Document](../objects/Document.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PositionalRepresentation](../objects/PositionalRepresentation.md)

