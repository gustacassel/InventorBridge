# DrawingEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).DrawingEvents`

```csharp
interface DrawingEvents
{
    // Properties
    object Application { get; }
    DrawingDocument Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnRetrieveDimensions(ObjectsEnumerator SketchDimensions, GeneralDimensionsEnumerator DrawingDimensions, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [DrawingDocument](../objects/DrawingDocument.md).DrawingEvents

**Referenced types:** [DrawingDocument](../objects/DrawingDocument.md), [EventTimingEnum](../enums/EventTimingEnum.md), [GeneralDimensionsEnumerator](../objects/GeneralDimensionsEnumerator.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md)

