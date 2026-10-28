# PresentationBody

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].TopSceneComponent.SurfaceBodies.Item[…]`

```csharp
interface PresentationBody
{
    // Properties
    object Application { get; }
    PresentationEdgesEnumerator Edges { get; }
    PresentationFacesEnumerator Faces { get; }
    string Name { get; }
    PresentationComponent Parent { get; }
    Box RangeBox { get; }
    ObjectTypeEnum Type { get; }
    PresentationVerticesEnumerator Vertices { get; }
    // Methods
    void CalculateFacets(double Tolerance, out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out double[] NormalVectors, out int[] VertexIndices);
    void CalculateFacetsAndTextureMap(double Tolerance, out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out double[] NormalVectors, out int[] VertexIndices, out double[] TextureCoordinates);
    void CalculateFacetsWithOptions(double ChordalTolerance, NameValueMap Options, out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out double[] NormalVectors, out int[] VertexIndices, out object TextureCoordinates = Missing);
    void CalculateStrokes(double Tolerance, out int VertexCount, out int SegmentCount, out double[] VertexCoordinates, out int[] VertexIndices);
    void CalculateStrokesWithOptions(double ChordalTolerance, NameValueMap Options, out int VertexCount, out double[] VertexCoordinates, out int PolylineCount, out int[] PolylineLengths);
    void GetExistingFacetTolerances(out int ToleranceCount, out double[] ExistingTolerances);
    void GetExistingFacets(double ToleranceIndex, out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out double[] NormalVectors, out int[] VertexIndices);
    void GetExistingFacetsAndTextureMap(double ToleranceIndex, out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out double[] NormalVectors, out int[] VertexIndices, out double[] TextureCoordinates);
    void GetExistingStrokeTolerances(out int ToleranceCount, out double[] ExistingTolerances);
    void GetExistingStrokes(double ToleranceIndex, out int VertexCount, out double[] VertexCoordinates, out int PolylineCount, out int[] PolylineLengths);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PresentationBodiesEnumerator](../objects/PresentationBodiesEnumerator.md).Item, [PresentationEdge](../objects/PresentationEdge.md).Parent, [PresentationFace](../objects/PresentationFace.md).Parent, [PresentationFace](../objects/PresentationFace.md).PresentationBody, [PresentationVertex](../objects/PresentationVertex.md).Parent

**Referenced types:** [Box](../objects/Box.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PresentationComponent](../objects/PresentationComponent.md), [PresentationEdgesEnumerator](../objects/PresentationEdgesEnumerator.md), [PresentationFacesEnumerator](../objects/PresentationFacesEnumerator.md), [PresentationVerticesEnumerator](../objects/PresentationVerticesEnumerator.md)

