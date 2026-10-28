# AssemblyEvents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.AssemblyEvents`

```csharp
interface AssemblyEvents
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Events
    event OnAssemblyChange(AssemblyDocument DocumentObject, NameValueMap Context, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
    event OnAssemblyChanged(NameValueMap Context, EventTimingEnum BeforeOrAfter, out HandlingCodeEnum HandlingCode);
    event OnAssemblySolve(_AssemblySolver Solver, EventTimingEnum BeforeOrAfter, NameValueMap Context);
    event OnDelete(Document DocumentObject, object Entity, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnLoadStateChange(AssemblyDocument DocumentObject, DocumentLoadStateEnum NewLoadState, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewConstraint(AssemblyDocument DocumentObject, object Constraint, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewOccurrence(AssemblyDocument DocumentObject, ComponentOccurrence Occurrence, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnNewRelationship(AssemblyDocument DocumentObject, object Relationship, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
    event OnOccurrenceChange(AssemblyDocument DocumentObject, ComponentOccurrence Occurrence, EventTimingEnum BeforeOrAfter, NameValueMap Context, out HandlingCodeEnum HandlingCode);
}
```

**Returned by:** [Application](../objects/Application.md).AssemblyEvents, [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).AssemblyEvents, [InventorServer](../objects/InventorServer.md).AssemblyEvents, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).AssemblyEvents

**Referenced types:** [AssemblyDocument](../objects/AssemblyDocument.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [Document](../objects/Document.md), [DocumentLoadStateEnum](../enums/DocumentLoadStateEnum.md), [EventTimingEnum](../enums/EventTimingEnum.md), [HandlingCodeEnum](../enums/HandlingCodeEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

