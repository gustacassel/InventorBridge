# ModelWeldingSymbol

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ModelAnnotation](../objects/ModelAnnotation.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelAnnotations.ModelWeldingSymbols.Item[…]`

```csharp
interface ModelWeldingSymbol
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ModelCompositeAnnotation CompositeAnnotation { get; }
    ModelWeldingSymbolDefinitions Definitions { get; set; }
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

**Returned by:** [ModelWeldingSymbolDefinition](../objects/ModelWeldingSymbolDefinition.md).Parent, [ModelWeldingSymbolProxy](../objects/ModelWeldingSymbolProxy.md).NativeObject, [ModelWeldingSymbols](../objects/ModelWeldingSymbols.md).Add, [ModelWeldingSymbols](../objects/ModelWeldingSymbols.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Camera](../objects/Camera.md), [ComponentDefinition](../objects/ComponentDefinition.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ModelCompositeAnnotation](../objects/ModelCompositeAnnotation.md), [ModelToleranceFeature](../objects/ModelToleranceFeature.md), [ModelWeldingSymbolDefinitions](../objects/ModelWeldingSymbolDefinitions.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

