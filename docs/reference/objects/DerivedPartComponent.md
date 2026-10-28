# DerivedPartComponent

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ReferenceComponent](../objects/ReferenceComponent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ReferenceComponents.DerivedPartComponents.Item[…]`

```csharp
interface DerivedPartComponent
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    DerivedPartDefinition Definition { get; set; }
    HealthStatusEnum HealthStatus { get; }
    bool IsEmbedded { get; }
    bool LinkedToFile { get; }
    string Name { get; }
    ParametersEnumerator Parameters { get; }
    ComponentDefinition Parent { get; }
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    SketchBlockDefinitionsEnumerator SketchBlockDefinitions { get; }
    SketchBlocksEnumerator SketchBlocks { get; }
    SketchesEnumerator Sketches { get; }
    Sketches3DEnumerator Sketches3D { get; }
    ReferenceFeaturesEnumerator SolidBodies { get; }
    bool SuppressLinkToFile { get; set; }
    ReferenceFeaturesEnumerator SurfaceBodies { get; }
    ObjectTypeEnum Type { get; }
    ObjectsEnumerator WorkFeatures { get; }
    iMateDefinitionsEnumerator iMateDefinitions { get; }
    // Methods
    void BreakLinkToFile();
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void Replace(string FullFileName, NameValueMap Options);
    void SetEndOfPart(bool Before);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DerivedPartComponentProxy](../objects/DerivedPartComponentProxy.md).NativeObject, [DerivedPartComponents](../objects/DerivedPartComponents.md).Add, [DerivedPartComponents](../objects/DerivedPartComponents.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [DerivedPartDefinition](../objects/DerivedPartDefinition.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [ParametersEnumerator](../objects/ParametersEnumerator.md), [ReferenceFeaturesEnumerator](../objects/ReferenceFeaturesEnumerator.md), [SketchBlockDefinitionsEnumerator](../objects/SketchBlockDefinitionsEnumerator.md), [SketchBlocksEnumerator](../objects/SketchBlocksEnumerator.md), [Sketches3DEnumerator](../objects/Sketches3DEnumerator.md), [SketchesEnumerator](../objects/SketchesEnumerator.md), [iMateDefinitionsEnumerator](../objects/iMateDefinitionsEnumerator.md)

