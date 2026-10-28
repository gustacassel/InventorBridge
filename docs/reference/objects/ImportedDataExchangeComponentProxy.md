# ImportedDataExchangeComponentProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ImportedDataExchangeComponent](../objects/ImportedDataExchangeComponent.md) → [ImportedComponent](../objects/ImportedComponent.md) → [ReferenceComponent](../objects/ReferenceComponent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDataExchangeComponent) → (ImportedDataExchangeComponentProxy)`

```csharp
interface ImportedDataExchangeComponentProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    ImportedComponentDefinition Definition { get; set; }
    HealthStatusEnum HealthStatus { get; }
    bool IsEmbedded { get; }
    bool LinkedToFile { get; }
    string Name { get; }
    ImportedDataExchangeComponent NativeObject { get; }
    ComponentDefinition Parent { get; }
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    bool SuppressLinkToFile { get; set; }
    ObjectTypeEnum Type { get; }
    string Urn { get; }
    // Methods
    void BreakLinkToFile();
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetEndOfPart(bool Before);
    void Update(object Options = Missing);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ImportedComponentDefinition](../objects/ImportedComponentDefinition.md), [ImportedDataExchangeComponent](../objects/ImportedDataExchangeComponent.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

