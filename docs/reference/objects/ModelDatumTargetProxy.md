# ModelDatumTargetProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ModelDatumTarget](../objects/ModelDatumTarget.md) → [ModelAnnotation](../objects/ModelAnnotation.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.Item[…] → (ModelDatumTarget) → (ModelDatumTargetProxy)`

```csharp
interface ModelDatumTargetProxy
{
    // Properties
    AnnotationPlane AnnotationPlane { get; set; }
    object Application { get; }
    Parameter AreaDiameter { get; }
    Parameter AreaHeight { get; }
    Parameter AreaWidth { get; }
    AttributeSets AttributeSets { get; }
    ModelCompositeAnnotation CompositeAnnotation { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    HealthStatusEnum HealthStatus { get; }
    int Index { get; set; }
    string InternalName { get; }
    bool IsMemberOfCompositeAnnotation { get; }
    bool IsOwnedByToleranceFeature { get; }
    ModelDatum ModelDatum { get; }
    string Name { get; set; }
    ModelDatumTarget NativeObject { get; }
    ModelToleranceFeature OwnedByToleranceFeature { get; }
    ComponentDefinition Parent { get; }
    object TargetPoint { get; set; }
    Point TextPosition { get; set; }
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

**Referenced types:** [AnnotationPlane](../objects/AnnotationPlane.md), [AttributeSets](../objects/AttributeSets.md), [Camera](../objects/Camera.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ModelCompositeAnnotation](../objects/ModelCompositeAnnotation.md), [ModelDatum](../objects/ModelDatum.md), [ModelDatumTarget](../objects/ModelDatumTarget.md), [ModelToleranceFeature](../objects/ModelToleranceFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [Point](../objects/Point.md)

