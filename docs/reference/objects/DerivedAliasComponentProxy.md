# DerivedAliasComponentProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [DerivedAliasComponent](../objects/DerivedAliasComponent.md) → [ReferenceComponent](../objects/ReferenceComponent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedAliasComponents.Item[…] → (DerivedAliasComponentProxy)`

```csharp
interface DerivedAliasComponentProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsEmbedded { get; }
    bool LinkedToFile { get; }
    string Name { get; }
    DerivedAliasComponent NativeObject { get; }
    ComponentDefinition Parent { get; }
    string ReferencedAliasFullFilename { get; }
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    ObjectsEnumerator ResultFeatures { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void BreakLinkToFile();
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetEndOfPart(bool Before);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [DerivedAliasComponent](../objects/DerivedAliasComponent.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md)

