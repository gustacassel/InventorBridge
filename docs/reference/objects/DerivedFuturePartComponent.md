# DerivedFuturePartComponent

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ReferenceComponent](../objects/ReferenceComponent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedFuturePartComponents.Item[…]`

```csharp
interface DerivedFuturePartComponent
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    DerivedFuturePartDefinition Definition { get; set; }
    HealthStatusEnum HealthStatus { get; }
    bool IsEmbedded { get; }
    bool LinkedToFile { get; }
    string Name { get; }
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

**Returned by:** [DerivedFuturePartComponentProxy](../objects/DerivedFuturePartComponentProxy.md).NativeObject, [DerivedFuturePartComponents](../objects/DerivedFuturePartComponents.md).Add, [DerivedFuturePartComponents](../objects/DerivedFuturePartComponents.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [DerivedFuturePartDefinition](../objects/DerivedFuturePartDefinition.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceFeaturesEnumerator](../objects/ReferenceFeaturesEnumerator.md)

