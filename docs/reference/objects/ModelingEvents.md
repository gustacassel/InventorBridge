# ModelingEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ModelingEvents`

```csharp
interface ModelingEvents
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnClientFeatureDoubleClick(Document DocumentObject, ClientFeature Feature, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnClientFeatureSolve(Document DocumentObject, ClientFeature Feature, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnDelete(Document DocumentObject, object Entity, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnFeatureChange(Document DocumentObject, PartFeature Feature, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnGeneralSurfaceProfileGDTSolve(Document DocumentObject, ModelAnnotation Annotation, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnGenerateMember(Document FactoryDocumentObject, string MemberName, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnGenerateModelStateMember(Document FactoryDocumentObject, string MemberName, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnModelAnnotationsScaleChange(Document DocumentObject, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnModelAnnotationsSolve(Document DocumentObject, ModelAnnotations Annotations, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewFeature(Document DocumentObject, PartFeature Feature, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewParameter(Document DocumentObject, Parameter Parameter, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnParameterChange(Document DocumentObject, Parameter Parameter, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnPreGenerateMember(Document FactoryDocumentObject, string MemberName, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [Application](../objects/Application.md).ModelingEvents, [InventorServer](../objects/InventorServer.md).ModelingEvents

**Referenced types:** [ClientFeature](../objects/ClientFeature.md), [Document](../objects/Document.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [ModelAnnotation](../objects/ModelAnnotation.md), [ModelAnnotations](../objects/ModelAnnotations.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [PartFeature](../objects/PartFeature.md)

