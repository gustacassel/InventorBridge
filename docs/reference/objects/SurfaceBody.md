# SurfaceBody

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.SurfaceBodies.Item[…]`

```csharp
interface SurfaceBody
{
    // Properties
    PartFeaturesEnumerator AffectedByFeatures { get; }
    SurfaceBody AlternateBody[int AlternateForm] { get; }
    Asset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentDefinition ComponentDefinition { get; }
    EdgeCollection ConcaveEdges { get; }
    EdgeCollection ConvexEdges { get; }
    PartFeature CreatedByFeature { get; }
    DataIO DataIO { get; }
    Edges Edges { get; }
    bool Exported { get; set; }
    FaceShells FaceShells { get; }
    Faces Faces { get; }
    int GeometryForm { get; }
    ContainmentEnum IsPointInside[out double[] Point, bool UseBox = true] { get; }
    bool IsSolid { get; }
    bool IsTransient { get; }
    SurfaceBodyMassProperties MassProperties { get; }
    string Name { get; set; }
    OrientedBox OrientedMinimumRangeBox { get; }
    object Parent { get; }
    Box PreciseRangeBox { get; }
    Box RangeBox { get; }
    ObjectTypeEnum Type { get; }
    Vertices Vertices { get; }
    bool Visible { get; set; }
    double Volume[double PrecisionPercent] { get; }
    Wires Wires { get; }
    // Methods
    object BindTransientKeyToObject(int TransientKey);
    void CalculateFacets(double Tolerance, out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out double[] NormalVectors, out int[] VertexIndices);
    void CalculateFacetsAndTextureMap(double Tolerance, out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out double[] NormalVectors, out int[] VertexIndices, out double[] TextureCoordinates);
    void CalculateFacetsWithOptions(double ChordalTolerance, NameValueMap Options, out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out double[] NormalVectors, out int[] VertexIndices, out object TextureCoordinates = Missing);
    void CalculateStrokes(double Tolerance, out int VertexCount, out int SegmentCount, out double[] VertexCoordinates, out int[] VertexIndices);
    void CalculateStrokesWithOptions(double ChordalTolerance, NameValueMap Options, out int VertexCount, out double[] VertexCoordinates, out int PolylineCount, out int[] PolylineLengths);
    void ClearAppearanceOverrides();
    void Delete();
    void FindUsingRay(Point RayStartPoint, UnitVector RayDirection, double Radius, out ObjectsEnumerator FoundEntities, out ObjectsEnumerator LocationPoints, bool FindFirstOnly = false);
    void GetAppearanceTextureMappingData(out TextureMappingTypeEnum TextureMappingType, out object TextureMappingAlignment = Missing);
    void GetExistingFacetTolerances(out int ToleranceCount, out double[] ExistingTolerances);
    void GetExistingFacets(double ToleranceIndex, out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out double[] NormalVectors, out int[] VertexIndices);
    void GetExistingFacetsAndTextureMap(double ToleranceIndex, out int VertexCount, out int FacetCount, out double[] VertexCoordinates, out double[] NormalVectors, out int[] VertexIndices, out double[] TextureCoordinates);
    void GetExistingStrokeTolerances(out int ToleranceCount, out double[] ExistingTolerances);
    void GetExistingStrokes(double ToleranceIndex, out int VertexCount, out double[] VertexCoordinates, out int PolylineCount, out int[] PolylineLengths);
    ObjectCollection GetFaceColors(object Faces = Missing);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    bool IsEntityValid(object EntityToCheck = Missing, int CheckLevel = 3, out object ProblemEntities = Missing);
    object LocateUsingPoint(ObjectTypeEnum ObjectType, Point PointOnObject, object ProximityTolerance = Missing);
    void SetAppearanceTextureMappingData(TextureMappingTypeEnum TextureMappingType, object TextureMappingAlignment = Missing);
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ComponentGraphics](../objects/ComponentGraphics.md).Body, [Edge](../objects/Edge.md).Parent, [EdgeLoop](../objects/EdgeLoop.md).Parent, [EdgeLoopProxy](../objects/EdgeLoopProxy.md).Parent, [EdgeProxy](../objects/EdgeProxy.md).Parent, [EdgeUse](../objects/EdgeUse.md).Parent, [EdgeUseProxy](../objects/EdgeUseProxy.md).Parent, [Face](../objects/Face.md).AlternateBody, [Face](../objects/Face.md).Parent, [Face](../objects/Face.md).SurfaceBody, [FaceProxy](../objects/FaceProxy.md).AlternateBody, [FaceProxy](../objects/FaceProxy.md).Parent, [FaceProxy](../objects/FaceProxy.md).SurfaceBody, [FaceShell](../objects/FaceShell.md).Parent, [FaceShell](../objects/FaceShell.md).SurfaceBody, [FaceShellProxy](../objects/FaceShellProxy.md).Parent, [FaceShellProxy](../objects/FaceShellProxy.md).SurfaceBody, [FlatPattern](../objects/FlatPattern.md).Body, [InterferenceResult](../objects/InterferenceResult.md).InterferenceBody, [RibDefinition](../objects/RibDefinition.md).AffectedBody, [SilhouetteCurve](../objects/SilhouetteCurve.md).Body, [SilhouetteCurveProxy](../objects/SilhouetteCurveProxy.md).Body, [SolidSweepDefinition](../objects/SolidSweepDefinition.md).ToolBody, [SurfaceBodies](../objects/SurfaceBodies.md).Item, [SurfaceBody](../objects/SurfaceBody.md).AlternateBody, [SurfaceBodyDefinition](../objects/SurfaceBodyDefinition.md).CreateTransientSurfaceBody, [SurfaceBodyMassProperties](../objects/SurfaceBodyMassProperties.md).Parent, [SurfaceBodyProxy](../objects/SurfaceBodyProxy.md).AlternateBody, [SurfaceBodyProxy](../objects/SurfaceBodyProxy.md).NativeObject, [SurfaceGraphics](../objects/SurfaceGraphics.md).Body, [ToNextExtent](../objects/ToNextExtent.md).Terminator, [TransientBRep](../objects/TransientBRep.md).Copy, [TransientBRep](../objects/TransientBRep.md).CreateIntersectionWithPlane, [TransientBRep](../objects/TransientBRep.md).CreateRuledSurface, [TransientBRep](../objects/TransientBRep.md).CreateSilhouetteCurve, [TransientBRep](../objects/TransientBRep.md).CreateSolidBlock, [TransientBRep](../objects/TransientBRep.md).CreateSolidCylinderCone, [TransientBRep](../objects/TransientBRep.md).CreateSolidSphere, [TransientBRep](../objects/TransientBRep.md).CreateSolidTorus, [Vertex](../objects/Vertex.md).Parent and 2 more (see `members.tsv`)

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ContainmentEnum](../enums/ContainmentEnum.md), [DataIO](../objects/DataIO.md), [EdgeCollection](../objects/EdgeCollection.md), [Edges](../objects/Edges.md), [FaceShells](../objects/FaceShells.md), [Faces](../objects/Faces.md), [NameValueMap](../objects/NameValueMap.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [OrientedBox](../objects/OrientedBox.md), [PartFeature](../objects/PartFeature.md), [PartFeaturesEnumerator](../objects/PartFeaturesEnumerator.md), [Point](../objects/Point.md), [SurfaceBodyMassProperties](../objects/SurfaceBodyMassProperties.md), [TextureMappingTypeEnum](../enums/TextureMappingTypeEnum.md), [UnitVector](../objects/UnitVector.md), [Vertices](../objects/Vertices.md), [Wires](../objects/Wires.md)

