# DerivedFuturePartComponentProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [DerivedFuturePartComponent](../objects/DerivedFuturePartComponent.md) → [ReferenceComponent](../objects/ReferenceComponent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedFuturePartComponents.Item[…] → (DerivedFuturePartComponentProxy)`

```csharp
interface DerivedFuturePartComponentProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    DerivedFuturePartDefinition Definition { get; set; }
    HealthStatusEnum HealthStatus { get; }
    bool IsEmbedded { get; }
    bool LinkedToFile { get; }
    string Name { get; }
    DerivedFuturePartComponent NativeObject { get; }
    ComponentDefinition Parent { get; }
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    ReferenceFeaturesEnumerator SolidBodies { get; }
    bool SuppressLinkToFile { get; set; }
    ReferenceFeaturesEnumerator SurfaceBodies { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void BreakLinkToFile();
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetEndOfPart(bool Before);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [DerivedFuturePartComponent](../objects/DerivedFuturePartComponent.md), [DerivedFuturePartDefinition](../objects/DerivedFuturePartDefinition.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceFeaturesEnumerator](../objects/ReferenceFeaturesEnumerator.md)

