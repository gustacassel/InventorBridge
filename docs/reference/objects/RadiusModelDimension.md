# RadiusModelDimension

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ModelFeatureControlFrame](../objects/ModelFeatureControlFrame.md) → [ModelAnnotation](../objects/ModelAnnotation.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelDimensions.RadiusModelDimensions.Item[…]`

```csharp
interface RadiusModelDimension
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ModelCompositeAnnotation CompositeAnnotation { get; }
    ModelDimensionDefinition Definition { get; set; }
    HealthStatusEnum HealthStatus { get; }
    string InternalName { get; }
    bool IsMemberOfCompositeAnnotation { get; }
    bool IsOwnedByToleranceFeature { get; }
    double ModelValue { get; }
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

**Returned by:** [RadiusModelDimensionProxy](../objects/RadiusModelDimensionProxy.md).NativeObject, [RadiusModelDimensions](../objects/RadiusModelDimensions.md).Add, [RadiusModelDimensions](../objects/RadiusModelDimensions.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Camera](../objects/Camera.md), [ComponentDefinition](../objects/ComponentDefinition.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ModelCompositeAnnotation](../objects/ModelCompositeAnnotation.md), [ModelDimensionDefinition](../objects/ModelDimensionDefinition.md), [ModelToleranceFeature](../objects/ModelToleranceFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

