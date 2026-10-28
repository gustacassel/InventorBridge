# Face

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…].Faces.Item[…]`

```csharp
interface Face
{
    // Properties
    SurfaceBody AlternateBody[int AlternateForm] { get; }
    Asset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
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

**Returned by:** [ASideDefinition](../objects/ASideDefinition.md).ASideFace, [ChamferDefinition](../objects/ChamferDefinition.md).Face, [DecalFeature](../objects/DecalFeature.md).Face, [DecalFeatureProxy](../objects/DecalFeatureProxy.md).Face, [EdgeLoop](../objects/EdgeLoop.md).Face, [EdgeLoopProxy](../objects/EdgeLoopProxy.md).Face, [EmbossFeature](../objects/EmbossFeature.md).WrapFace, [EmbossFeatureProxy](../objects/EmbossFeatureProxy.md).WrapFace, [Face](../objects/Face.md).GetSourceFace, [FaceProxy](../objects/FaceProxy.md).GetSourceFace, [FaceProxy](../objects/FaceProxy.md).NativeObject, [Faces](../objects/Faces.md).Item, [FlatPattern](../objects/FlatPattern.md).BaseFace, [FlatPattern](../objects/FlatPattern.md).BottomFace, [FlatPattern](../objects/FlatPattern.md).TopFace, [LineAndTangentWorkPlaneDef](../objects/LineAndTangentWorkPlaneDef.md).Face, [LoftFeature](../objects/LoftFeature.md).EndFace, [LoftFeature](../objects/LoftFeature.md).StartFace, [LoftFeatureProxy](../objects/LoftFeatureProxy.md).EndFace, [LoftFeatureProxy](../objects/LoftFeatureProxy.md).StartFace, [MeshFace](../objects/MeshFace.md).Face, [MeshFaceProxy](../objects/MeshFaceProxy.md).Face, [PlaneAndTangentWorkPlaneDef](../objects/PlaneAndTangentWorkPlaneDef.md).Face, [PointAndTangentWorkPlaneDef](../objects/PointAndTangentWorkPlaneDef.md).Face, [RefoldFeature](../objects/RefoldFeature.md).StationaryFace, [RefoldFeatureProxy](../objects/RefoldFeatureProxy.md).StationaryFace, [RevolvedFaceWorkAxisDef](../objects/RevolvedFaceWorkAxisDef.md).Face, [RipDefinition](../objects/RipDefinition.md).RipFace, [SphereCenterPointWorkPointDef](../objects/SphereCenterPointWorkPointDef.md).Face, [SurfaceGraphicsFace](../objects/SurfaceGraphicsFace.md).Face, [TorusCenterPointWorkPointDef](../objects/TorusCenterPointWorkPointDef.md).Face, [TorusMidPlaneWorkPlaneDef](../objects/TorusMidPlaneWorkPlaneDef.md).Face, [UnfoldFeature](../objects/UnfoldFeature.md).StationaryFace, [UnfoldFeatureProxy](../objects/UnfoldFeatureProxy.md).StationaryFace

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [EdgeLoops](../objects/EdgeLoops.md), [Edges](../objects/Edges.md), [FaceCollection](../objects/FaceCollection.md), [FaceShell](../objects/FaceShell.md), [NameValueMap](../objects/NameValueMap.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeature](../objects/PartFeature.md), [Point](../objects/Point.md), [ReferenceComponent](../objects/ReferenceComponent.md), [SurfaceBody](../objects/SurfaceBody.md), [SurfaceEvaluator](../objects/SurfaceEvaluator.md), [SurfaceTypeEnum](../enums/SurfaceTypeEnum.md), [TextureMaps](../objects/TextureMaps.md), [Vertices](../objects/Vertices.md)

