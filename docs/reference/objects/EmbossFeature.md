# EmbossFeature

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [PartFeature](../objects/PartFeature.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.EmbossFeatures.Item[…]`

```csharp
interface EmbossFeature
{
    // Properties
    bool Adaptive { get; set; }
    Asset Appearance { get; set; }
    AppearanceSourceTypeEnum AppearanceSourceType { get; set; }
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool ConsumeInputs { get; set; }
    Parameter Depth { get; }
    PartFeatureExtentDirectionEnum Direction { get; set; }
    EmbossTypeEnum EmbossType { get; }
    string ExtendedName { get; }
    Faces Faces { get; }
    FeatureDimensions FeatureDimensions { get; }
    HealthStatusEnum HealthStatus { get; }
    bool IsOwnedByFeature { get; }
    string Name { get; set; }
    PartFeature OwnedBy { get; }
    ParametersEnumerator Parameters { get; }
    ComponentDefinition Parent { get; }
    ComponentOccurrencesEnumerator Participants { get; }
    Profile Profile { get; set; }
    Box RangeBox { get; }
    bool Shared { get; set; }
    bool Suppressed { get; set; }
    SurfaceBodies SurfaceBodies { get; }
    Parameter Taper { get; }
    Asset TopFaceAppearance { get; set; }
    AppearanceSourceTypeEnum TopFaceAppearanceSourceType { get; set; }
    ObjectTypeEnum Type { get; }
    Face WrapFace { get; set; }
    bool WrapToFace { get; }
    // Methods
    void Delete(bool RetainConsumedSketches = false, bool RetainDependentFeaturesAndSketches = false, bool RetainDependentWorkFeatures = false);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    bool GetSuppressionCondition(out Parameter Parameter, out ComparisonTypeEnum ComparisonType, out object Expression);
    void RemoveParticipant(ComponentOccurrence Occurrence);
    void SetAffectedBodies(ObjectCollection Bodies);
    void SetEmbossEngraveFromPlane(object Taper, PartFeatureExtentDirectionEnum ExtentDirection);
    void SetEmbossFromFace(object Distance, PartFeatureExtentDirectionEnum ExtentDirection, object WrapFace = Missing);
    void SetEndOfPart(bool Before);
    void SetEngraveFromFace(object Distance, PartFeatureExtentDirectionEnum ExtentDirection, object WrapFace = Missing);
    void SetSuppressionCondition(Parameter Parameter, ComparisonTypeEnum ComparisonType, object Expression);
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [EmbossFeatureProxy](../objects/EmbossFeatureProxy.md).NativeObject, [EmbossFeatures](../objects/EmbossFeatures.md).AddEmbossEngraveFromPlane, [EmbossFeatures](../objects/EmbossFeatures.md).AddEmbossFromFace, [EmbossFeatures](../objects/EmbossFeatures.md).AddEngraveFromFace, [EmbossFeatures](../objects/EmbossFeatures.md).Item

**Referenced types:** [AppearanceSourceTypeEnum](../enums/AppearanceSourceTypeEnum.md), [Asset](../objects/Asset.md), [AttributeSets](../objects/AttributeSets.md), [Box](../objects/Box.md), [ComparisonTypeEnum](../enums/ComparisonTypeEnum.md), [ComponentDefinition](../objects/ComponentDefinition.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ComponentOccurrencesEnumerator](../objects/ComponentOccurrencesEnumerator.md), [EmbossTypeEnum](../enums/EmbossTypeEnum.md), [Face](../objects/Face.md), [Faces](../objects/Faces.md), [FeatureDimensions](../objects/FeatureDimensions.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ParametersEnumerator](../objects/ParametersEnumerator.md), [PartFeature](../objects/PartFeature.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [Profile](../objects/Profile.md), [SurfaceBodies](../objects/SurfaceBodies.md)

