# ImportedDWGComponent

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ImportedComponent](../objects/ImportedComponent.md) → [ReferenceComponent](../objects/ReferenceComponent.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.ImportedComponents.Item[…] → (ImportedDWGComponent)`

```csharp
interface ImportedDWGComponent
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Box2d Crop { get; set; }
    ImportedComponentDefinition Definition { get; set; }
    bool Grounded { get; set; }
    HealthStatusEnum HealthStatus { get; }
    bool IsEmbedded { get; }
    ImportedDWGLayersEnumerator Layers { get; }
    bool LinkedToFile { get; }
    DWGBlockDefinition ModelSpaceDefinition { get; }
    string Name { get; }
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

**Returned by:** [DWGACMStandardPart](../objects/DWGACMStandardPart.md).Parent, [DWGACMStandardPartProxy](../objects/DWGACMStandardPartProxy.md).Parent, [DWGAcadSupportedProxy](../objects/DWGAcadSupportedProxy.md).Parent, [DWGAcadSupportedProxyProxy](../objects/DWGAcadSupportedProxyProxy.md).Parent, [DWGArc](../objects/DWGArc.md).Parent, [DWGArcProxy](../objects/DWGArcProxy.md).Parent, [DWGBlockDefinition](../objects/DWGBlockDefinition.md).Parent, [DWGBlockDefinitionProxy](../objects/DWGBlockDefinitionProxy.md).Parent, [DWGBlockReference](../objects/DWGBlockReference.md).Parent, [DWGBlockReferenceProxy](../objects/DWGBlockReferenceProxy.md).Parent, [DWGEllipticalArc](../objects/DWGEllipticalArc.md).Parent, [DWGEllipticalArcProxy](../objects/DWGEllipticalArcProxy.md).Parent, [DWGEntity](../objects/DWGEntity.md).Parent, [DWGEntityProxy](../objects/DWGEntityProxy.md).Parent, [DWGEntitySegmentProxy](../objects/DWGEntitySegmentProxy.md).Parent, [DWGLine](../objects/DWGLine.md).Parent, [DWGLineProxy](../objects/DWGLineProxy.md).Parent, [DWGPoint](../objects/DWGPoint.md).Parent, [DWGPointProxy](../objects/DWGPointProxy.md).Parent, [DWGPolyline](../objects/DWGPolyline.md).Parent, [DWGPolyline2D](../objects/DWGPolyline2D.md).Parent, [DWGPolyline2DProxy](../objects/DWGPolyline2DProxy.md).Parent, [DWGPolyline3D](../objects/DWGPolyline3D.md).Parent, [DWGPolyline3DProxy](../objects/DWGPolyline3DProxy.md).Parent, [DWGPolylineProxy](../objects/DWGPolylineProxy.md).Parent, [DWGSpline](../objects/DWGSpline.md).Parent, [DWGSplineProxy](../objects/DWGSplineProxy.md).Parent, [ImportedDWGComponentProxy](../objects/ImportedDWGComponentProxy.md).NativeObject

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [Box2d](../objects/Box2d.md), [ComponentDefinition](../objects/ComponentDefinition.md), [DWGBlockDefinition](../objects/DWGBlockDefinition.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ImportedComponentDefinition](../objects/ImportedComponentDefinition.md), [ImportedDWGLayersEnumerator](../objects/ImportedDWGLayersEnumerator.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

