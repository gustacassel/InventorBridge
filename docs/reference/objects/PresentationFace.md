# PresentationFace

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PresentationDocument).Scenes.Item[…].TopSceneComponent.SurfaceBodies.Item[…].Faces.Item[…]`

```csharp
interface PresentationFace
{
    // Properties
    object Application { get; }
    PresentationEdgesEnumerator Edges { get; }
    SurfaceEvaluator Evaluator { get; }
    object Geometry { get; }
    int GeometryForm { get; }
    bool IsParamReversed { get; }
    PresentationBody Parent { get; }
    Point PointOnFace { get; }
    PresentationBody PresentationBody { get; }
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

**Returned by:** [PresentationFacesEnumerator](../objects/PresentationFacesEnumerator.md).Item

**Referenced types:** [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md), [PresentationBody](../objects/PresentationBody.md), [PresentationEdgesEnumerator](../objects/PresentationEdgesEnumerator.md), [PresentationVerticesEnumerator](../objects/PresentationVerticesEnumerator.md), [SurfaceEvaluator](../objects/SurfaceEvaluator.md)

