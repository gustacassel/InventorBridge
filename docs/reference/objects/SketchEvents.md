# SketchEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.SketchEvents`

```csharp
interface SketchEvents
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnDelete(Document DocumentObject, object Entity, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewSketch(Document DocumentObject, Sketch Sketch, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewSketch3D(Document DocumentObject, Sketch3D Sketch3D, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnSketch3DChange(Document DocumentObject, Sketch3D Sketch3D, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnSketch3DSolve(Document DocumentObject, object Sketch, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnSketchChange(Document DocumentObject, Sketch Sketch, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [Application](../objects/Application.md).SketchEvents, [InventorServer](../objects/InventorServer.md).SketchEvents

**Referenced types:** [Document](../objects/Document.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch](../objects/Sketch.md), [Sketch3D](../objects/Sketch3D.md)

