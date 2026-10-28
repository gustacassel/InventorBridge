# ReferenceComponent

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.WorkPoints.Item[…].ReferenceComponent`

```csharp
interface ReferenceComponent
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsEmbedded { get; }
    bool LinkedToFile { get; }
    string Name { get; }
    ComponentDefinition Parent { get; }
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void BreakLinkToFile();
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetEndOfPart(bool Before);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngleiMateDefinition](../objects/AngleiMateDefinition.md).ReferenceComponent, [AngleiMateDefinitionProxy](../objects/AngleiMateDefinitionProxy.md).ReferenceComponent, [CompositeiMateDefinition](../objects/CompositeiMateDefinition.md).ReferenceComponent, [CompositeiMateDefinitionProxy](../objects/CompositeiMateDefinitionProxy.md).ReferenceComponent, [DerivedParameterTable](../objects/DerivedParameterTable.md).ReferenceComponent, [Face](../objects/Face.md).ReferenceComponent, [FaceProxy](../objects/FaceProxy.md).ReferenceComponent, [FlushiMateDefinition](../objects/FlushiMateDefinition.md).ReferenceComponent, [FlushiMateDefinitionProxy](../objects/FlushiMateDefinitionProxy.md).ReferenceComponent, [HelicalCurve](../objects/HelicalCurve.md).ReferenceComponent, [HelicalCurveProxy](../objects/HelicalCurveProxy.md).ReferenceComponent, [InsertiMateDefinition](../objects/InsertiMateDefinition.md).ReferenceComponent, [InsertiMateDefinitionProxy](../objects/InsertiMateDefinitionProxy.md).ReferenceComponent, [MateiMateDefinition](../objects/MateiMateDefinition.md).ReferenceComponent, [MateiMateDefinitionProxy](../objects/MateiMateDefinitionProxy.md).ReferenceComponent, [PlanarSketch](../objects/PlanarSketch.md).ReferenceComponent, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).ReferenceComponent, [ReferenceFeature](../objects/ReferenceFeature.md).ReferenceComponent, [ReferenceFeatureProxy](../objects/ReferenceFeatureProxy.md).ReferenceComponent, [RotateRotateiMateDefinition](../objects/RotateRotateiMateDefinition.md).ReferenceComponent, [RotateRotateiMateDefinitionProxy](../objects/RotateRotateiMateDefinitionProxy.md).ReferenceComponent, [RotateTranslateiMateDefinition](../objects/RotateTranslateiMateDefinition.md).ReferenceComponent, [RotateTranslateiMateDefinitionProxy](../objects/RotateTranslateiMateDefinitionProxy.md).ReferenceComponent, [Sketch3D](../objects/Sketch3D.md).ReferenceComponent, [Sketch3DProxy](../objects/Sketch3DProxy.md).ReferenceComponent, [SketchArc](../objects/SketchArc.md).ReferenceComponent, [SketchArc3D](../objects/SketchArc3D.md).ReferenceComponent, [SketchArc3DProxy](../objects/SketchArc3DProxy.md).ReferenceComponent, [SketchArcProxy](../objects/SketchArcProxy.md).ReferenceComponent, [SketchBlock](../objects/SketchBlock.md).ReferenceComponent, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).ReferenceComponent, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).ReferenceComponent, [SketchBlockProxy](../objects/SketchBlockProxy.md).ReferenceComponent, [SketchCircle](../objects/SketchCircle.md).ReferenceComponent, [SketchCircle3D](../objects/SketchCircle3D.md).ReferenceComponent, [SketchCircle3DProxy](../objects/SketchCircle3DProxy.md).ReferenceComponent, [SketchCircleProxy](../objects/SketchCircleProxy.md).ReferenceComponent, [SketchControlPointSpline](../objects/SketchControlPointSpline.md).ReferenceComponent, [SketchControlPointSpline3D](../objects/SketchControlPointSpline3D.md).ReferenceComponent, [SketchControlPointSpline3DProxy](../objects/SketchControlPointSpline3DProxy.md).ReferenceComponent and 48 more (see `members.tsv`)

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentDefinition](../objects/ComponentDefinition.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

