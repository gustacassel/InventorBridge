# RevolveFeatureProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [RevolveFeature](../objects/RevolveFeature.md) → [PartFeature](../objects/PartFeature.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.RevolveFeatures.Item[…] → (RevolveFeatureProxy)`

```csharp
interface RevolveFeatureProxy
{
    // Properties
    bool Adaptive { get; set; }
    Asset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    object AxisEntity { get; set; }
    bool ConsumeInputs { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    Faces EndFaces { get; }
    string ExtendedName { get; }
    PartFeatureExtent Extent { get; }
    PartFeatureExtent ExtentTwo { get; }
    PartFeatureExtentEnum ExtentTwoType { get; }
    PartFeatureExtentEnum ExtentType { get; }
    Faces Faces { get; }
    FeatureDimensions FeatureDimensions { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsOwnedByFeature { get; }
    bool IsTwoDirectional { get; }
    string Name { get; set; }
    RevolveFeature NativeObject { get; }
    PartFeatureOperationEnum Operation { get; set; }
    PartFeature OwnedBy { get; }
    ParametersEnumerator Parameters { get; }
    ComponentDefinition Parent { get; }
    ComponentOccurrencesEnumerator Participants { get; }
    Profile Profile { get; set; }
    Box RangeBox { get; }
    bool Shared { get; set; }
    Faces SideFaces { get; }
    Faces StartFaces { get; }
    bool Suppressed { get; set; }
    SurfaceBodies SurfaceBodies { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddParticipant(ComponentOccurrence Occurrence);
    void Delete(bool RetainConsumedSketches = false, bool RetainDependentFeaturesAndSketches = false, bool RetainDependentWorkFeatures = false);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    bool GetSuppressionCondition(out Parameter Parameter, out ComparisonTypeEnum ComparisonType, out object Expression);
    void RemoveParticipant(ComponentOccurrence Occurrence);
    void SetAffectedBodies(ObjectCollection Bodies);
    void SetAngleExtent(object Angle, PartFeatureExtentDirectionEnum ExtentDirection);
    void SetEndOfPart(bool Before);
    void SetFromToExtent(object FromFace, bool ExtendFromFace, object ToFace, bool ExtendToFace, PartFeatureExtentDirectionEnum ExtentDirection, bool MinimumSolution);
    void SetFullExtent();
    void SetSuppressionCondition(Parameter Parameter, ComparisonTypeEnum ComparisonType, object Expression);
    void SetToFaceExtent(object ToFace, bool ExtendToFace, PartFeatureExtentDirectionEnum ExtentDirection, bool MinimumSolution);
    void SetToNextExtent(PartFeatureExtentDirectionEnum ExtentDirection, SurfaceBody Terminator);
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComparisonTypeEnum](../enums/ComparisonTypeEnum.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [Faces](../objects/Faces.md), [FeatureDimensions](../objects/FeatureDimensions.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ParametersEnumerator](../objects/ParametersEnumerator.md), [PartFeature](../objects/PartFeature.md), [PartFeatureExtent](../objects/PartFeatureExtent.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [PartFeatureExtentEnum](../enums/PartFeatureExtentEnum.md), [PartFeatureOperationEnum](../enums/PartFeatureOperationEnum.md), [Profile](../objects/Profile.md), [RevolveFeature](../objects/RevolveFeature.md), [SurfaceBodies](../objects/SurfaceBodies.md), [SurfaceBody](../objects/SurfaceBody.md)

