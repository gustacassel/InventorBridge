# FaceCollection

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientObjects.CreateFaceCollection(…)`

```csharp
interface FaceCollection
{
    // Properties
    FaceCollectionEnum CollectionType { get; }
    int Count { get; }
    object Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(object Object);
    void Clear();
    void Remove(int Index);
    void RemoveByObject(object Object);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyJointDefinition](../objects/AssemblyJointDefinition.md).OriginOneReferencedFaces, [AssemblyJointDefinition](../objects/AssemblyJointDefinition.md).OriginTwoReferencedFaces, [Face](../objects/Face.md).TangentiallyConnectedFaces, [FaceDraftDefinition](../objects/FaceDraftDefinition.md).InputFaces, [FaceDraftFeature](../objects/FaceDraftFeature.md)._InputFaces, [FaceDraftFeatureProxy](../objects/FaceDraftFeatureProxy.md)._InputFaces, [FaceProxy](../objects/FaceProxy.md).TangentiallyConnectedFaces, [FilletConstantRadiusFaceSet](../objects/FilletConstantRadiusFaceSet.md).FacesOne, [FilletConstantRadiusFaceSet](../objects/FilletConstantRadiusFaceSet.md).FacesTwo, [FilletFullRoundSet](../objects/FilletFullRoundSet.md).CenterFaces, [FilletFullRoundSet](../objects/FilletFullRoundSet.md).SideFacesOne, [FilletFullRoundSet](../objects/FilletFullRoundSet.md).SideFacesTwo, [ModelSurfaceTextureSymbolDefinition](../objects/ModelSurfaceTextureSymbolDefinition.md).Faces, [ModelToleranceFeature](../objects/ModelToleranceFeature.md).AllFaces, [ModelToleranceFeatureProxy](../objects/ModelToleranceFeatureProxy.md).AllFaces, [MoveFaceDefinition](../objects/MoveFaceDefinition.md).Faces, [ReplaceFaceDefinition](../objects/ReplaceFaceDefinition.md).ExistingFaces, [ShellDefinition](../objects/ShellDefinition.md).InputFaces, [ShellThicknessFaceSet](../objects/ShellThicknessFaceSet.md).Faces, [SilhouetteCurve](../objects/SilhouetteCurve.md).ExcludedFaces, [SilhouetteCurveProxy](../objects/SilhouetteCurveProxy.md).ExcludedFaces, [SketchDrivenPatternDefinition](../objects/SketchDrivenPatternDefinition.md).ReferenceFaces, [TransientObjects](../objects/TransientObjects.md).CreateFaceCollection, [UnwrapDefinition](../objects/UnwrapDefinition.md).InputFaces

**Referenced types:** [FaceCollectionEnum](../enums/FaceCollectionEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

