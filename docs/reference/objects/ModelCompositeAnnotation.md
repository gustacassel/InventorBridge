# ModelCompositeAnnotation

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ModelAnnotation](../objects/ModelAnnotation.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.Item[…].CompositeAnnotation`

```csharp
interface ModelCompositeAnnotation
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    string ClientId { get; }
    ModelCompositeAnnotation CompositeAnnotation { get; }
    ModelCompositeAnnotationDefinition Definition { get; set; }
    HealthStatusEnum HealthStatus { get; }
    string InternalName { get; }
    bool IsMemberOfCompositeAnnotation { get; }
    bool IsOwnedByToleranceFeature { get; }
    string Name { get; set; }
    ModelToleranceFeature OwnedByToleranceFeature { get; }
    ComponentDefinition Parent { get; }
    ModelToleranceFeature TopToleranceFeature { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Delete();
    void GetDisplayGeometry(Camera Camera, out int GroupCount, out int[] PolylinesPerGroup, out bool[] FilledGroups, out int PolylineCount, out int[] PolylineLengths, out int VertexCount, out double[] VertexCoordinates);
    void GetFilledAreaFacetsInfo(Camera Camera, out int TextVertexCount, out int TextFacetCount, out double[] TextVertexCoordinates, out int[] TextVertexIndices, out int SymbolVertexCount, out int SymbolFacetCount, out double[] SymbolVertexCoordinates, out int[] SymbolVertexIndices);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AngularModelDimension](../objects/AngularModelDimension.md).CompositeAnnotation, [AngularModelDimensionProxy](../objects/AngularModelDimensionProxy.md).CompositeAnnotation, [DiameterModelDimension](../objects/DiameterModelDimension.md).CompositeAnnotation, [DiameterModelDimensionProxy](../objects/DiameterModelDimensionProxy.md).CompositeAnnotation, [LinearModelDimension](../objects/LinearModelDimension.md).CompositeAnnotation, [LinearModelDimensionProxy](../objects/LinearModelDimensionProxy.md).CompositeAnnotation, [ModelAnnotation](../objects/ModelAnnotation.md).CompositeAnnotation, [ModelCompositeAnnotation](../objects/ModelCompositeAnnotation.md).CompositeAnnotation, [ModelCompositeAnnotationDefinition](../objects/ModelCompositeAnnotationDefinition.md).Parent, [ModelCompositeAnnotationProxy](../objects/ModelCompositeAnnotationProxy.md).CompositeAnnotation, [ModelCompositeAnnotationProxy](../objects/ModelCompositeAnnotationProxy.md).NativeObject, [ModelCompositeAnnotations](../objects/ModelCompositeAnnotations.md).Add, [ModelCompositeAnnotations](../objects/ModelCompositeAnnotations.md).Item, [ModelDatumIdentifier](../objects/ModelDatumIdentifier.md).CompositeAnnotation, [ModelDatumIdentifierProxy](../objects/ModelDatumIdentifierProxy.md).CompositeAnnotation, [ModelDatumTarget](../objects/ModelDatumTarget.md).CompositeAnnotation, [ModelDatumTargetProxy](../objects/ModelDatumTargetProxy.md).CompositeAnnotation, [ModelDimension](../objects/ModelDimension.md).CompositeAnnotation, [ModelFeatureControlFrame](../objects/ModelFeatureControlFrame.md).CompositeAnnotation, [ModelFeatureControlFrameProxy](../objects/ModelFeatureControlFrameProxy.md).CompositeAnnotation, [ModelGeneralNote](../objects/ModelGeneralNote.md).CompositeAnnotation, [ModelGeneralNoteProxy](../objects/ModelGeneralNoteProxy.md).CompositeAnnotation, [ModelHoleThreadNote](../objects/ModelHoleThreadNote.md).CompositeAnnotation, [ModelHoleThreadNoteProxy](../objects/ModelHoleThreadNoteProxy.md).CompositeAnnotation, [ModelLeaderNote](../objects/ModelLeaderNote.md).CompositeAnnotation, [ModelLeaderNoteProxy](../objects/ModelLeaderNoteProxy.md).CompositeAnnotation, [ModelSurfaceTextureSymbol](../objects/ModelSurfaceTextureSymbol.md).CompositeAnnotation, [ModelSurfaceTextureSymbolProxy](../objects/ModelSurfaceTextureSymbolProxy.md).CompositeAnnotation, [ModelWeldingSymbol](../objects/ModelWeldingSymbol.md).CompositeAnnotation, [ModelWeldingSymbolProxy](../objects/ModelWeldingSymbolProxy.md).CompositeAnnotation, [RadiusModelDimension](../objects/RadiusModelDimension.md).CompositeAnnotation, [RadiusModelDimensionProxy](../objects/RadiusModelDimensionProxy.md).CompositeAnnotation

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Camera](../objects/Camera.md), [ComponentDefinition](../objects/ComponentDefinition.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ModelCompositeAnnotationDefinition](../objects/ModelCompositeAnnotationDefinition.md), [ModelToleranceFeature](../objects/ModelToleranceFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

