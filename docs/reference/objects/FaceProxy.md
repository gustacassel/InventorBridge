# FaceProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Face](../objects/Face.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Faces.Item[…] → (FaceProxy)`

```csharp
interface FaceProxy
{
    // Properties
    SurfaceBody AlternateBody[int AlternateForm] { get; }
    Asset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    PartFeature CreatedByFeature { get; }
    EdgeLoops EdgeLoops { get; }
    Edges Edges { get; }
    SurfaceEvaluator Evaluator { get; }
    FaceShell FaceShell { get; }
    object Geometry { get; }
    int GeometryForm { get; }
    bool HasReferenceComponent { get; }
    string InternalName { get; }
    bool IsParamReversed { get; }
    Face NativeObject { get; }
    SurfaceBody Parent { get; }
    Point PointOnFace { get; }
    ReferenceComponent ReferenceComponent { get; }
    object ReferencedEntity { get; }
    SurfaceBody SurfaceBody { get; }
    SurfaceTypeEnum SurfaceType { get; }
    FaceCollection TangentiallyConnectedFaces { get; }
    TextureMaps TextureMaps { get; }
    ObjectCollection ThreadInfos { get; }
    int TransientKey { get; }
    ObjectTypeEnum Type { get; }
    Vertices Vertices { get; }
    // Methods
    void CalculateFacets(double Tolerance, out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out double[] NormalVectors, out int[] VertexIndices);
    void CalculateFacetsAndTextureMap(double Tolerance, out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out double[] NormalVectors, out int[] VertexIndices, out double[] TextureCoordinates);
    void CalculateFacetsWithOptions(double ChordalTolerance, NameValueMap Options, out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out double[] NormalVectors, out int[] VertexIndices, out object TextureCoordinates = Missing);
    void CalculateStrokes(double Tolerance, out int VertexCount, out int SegmentCount, out double[] VertexCoordinates, out int[] VertexIndices);
    void CalculateStrokesWithOptions(double ChordalTolerance, NameValueMap Options, out int VertexCount, out double[] VertexCoordinates, out int PolylineCount, out int[] PolylineLengths);
    Point GetClosestPointTo(Point InputPoint);
    void GetExistingFacetTolerances(out int ToleranceCount, out double[] ExistingTolerances);
    void GetExistingFacets(double ToleranceIndex, out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out double[] NormalVectors, out int[] VertexIndices);
    void GetExistingFacetsAndTextureMap(double ToleranceIndex, out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out double[] NormalVectors, out int[] VertexIndices, out double[] TextureCoordinates);
    void GetExistingStrokeTolerances(out int ToleranceCount, out double[] ExistingTolerances);
    void GetExistingStrokes(double ToleranceIndex, out int VertexCount, out double[] VertexCoordinates, out int PolylineCount, out int[] PolylineLengths);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    Face GetSourceFace(bool GetLeafSource = true);
    void GetTextureScale(out double UScale, out double VScale);
}
```

7 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [EdgeLoops](../objects/EdgeLoops.md), [Edges](../objects/Edges.md), [Face](../objects/Face.md), [FaceCollection](../objects/FaceCollection.md), [FaceShell](../objects/FaceShell.md), [NameValueMap](../objects/NameValueMap.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md), [Point](../objects/Point.md), [ReferenceComponent](../objects/ReferenceComponent.md), [SurfaceBody](../objects/SurfaceBody.md), [SurfaceEvaluator](../objects/SurfaceEvaluator.md), [SurfaceTypeEnum](../enums/SurfaceTypeEnum.md), [TextureMaps](../objects/TextureMaps.md), [Vertices](../objects/Vertices.md)

