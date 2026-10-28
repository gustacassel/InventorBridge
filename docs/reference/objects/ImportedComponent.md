# ImportedComponent

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ReferenceComponent](../objects/ReferenceComponent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…]`

```csharp
interface ImportedComponent
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ImportedComponentDefinition Definition { get; set; }
    HealthStatusEnum HealthStatus { get; }
    bool IsEmbedded { get; }
    bool LinkedToFile { get; }
    string Name { get; }
    ComponentDefinition Parent { get; }
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    bool SuppressLinkToFile { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void BreakLinkToFile();
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetEndOfPart(bool Before);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ComponentOccurrence](../objects/ComponentOccurrence.md).ImportedComponent, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).ImportedComponent, [ImportedComponentDefinition](../objects/ImportedComponentDefinition.md).Parent, [ImportedComponents](../objects/ImportedComponents.md).Add, [ImportedComponents](../objects/ImportedComponents.md).Item, [ImportedDWGComponentDefinition](../objects/ImportedDWGComponentDefinition.md).Parent, [ImportedDataExchangeComponentDefinition](../objects/ImportedDataExchangeComponentDefinition.md).Parent, [ImportedGenericComponentDefinition](../objects/ImportedGenericComponentDefinition.md).Parent, [ImportedRVTComponentDefinition](../objects/ImportedRVTComponentDefinition.md).Parent

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ImportedComponentDefinition](../objects/ImportedComponentDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

