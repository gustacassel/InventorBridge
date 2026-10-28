# ImportedDWGComponentProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ImportedDWGComponent](../objects/ImportedDWGComponent.md) → [ImportedComponent](../objects/ImportedComponent.md) → [ReferenceComponent](../objects/ReferenceComponent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent) → (ImportedDWGComponentProxy)`

```csharp
interface ImportedDWGComponentProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    Box2d Crop { get; set; }
    ImportedComponentDefinition Definition { get; set; }
    bool Grounded { get; set; }
    HealthStatusEnum HealthStatus { get; }
    bool IsEmbedded { get; }
    ImportedDWGLayersEnumerator Layers { get; }
    bool LinkedToFile { get; }
    DWGBlockDefinition ModelSpaceDefinition { get; }
    string Name { get; }
    ImportedDWGComponent NativeObject { get; }
    object Origin { get; }
    ComponentDefinition Parent { get; }
    Box RangeBox { get; }
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    bool SuppressLinkToFile { get; set; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    object XAxis { get; }
    object XYPlane { get; }
    object XZPlane { get; }
    object YAxis { get; }
    object YZPlane { get; }
    object ZAxis { get; }
    // Methods
    void BreakLinkToFile();
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetEndOfPart(bool Before);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [Box2d](../objects/Box2d.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [DWGBlockDefinition](../objects/DWGBlockDefinition.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ImportedComponentDefinition](../objects/ImportedComponentDefinition.md), [ImportedDWGComponent](../objects/ImportedDWGComponent.md), [ImportedDWGLayersEnumerator](../objects/ImportedDWGLayersEnumerator.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

