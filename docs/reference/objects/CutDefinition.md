# CutDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…] → (CutFeature).Definition`

```csharp
interface CutDefinition
{
    // Properties
    object Application { get; }
    bool CutAcrossBends { get; }
    bool CutNormalToFlat { get; set; }
    PartFeatureExtent Extent { get; }
    PartFeatureExtentEnum ExtentType { get; }
    CutFeature Parent { get; }
    Profile Profile { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void SetCutAcrossBendsExtent(object Distance);
    void SetDistanceExtent(object Distance, PartFeatureExtentDirectionEnum Direction);
    void SetFromToExtent(object FromFace, bool ExtendFromFace, object ToFace, bool ExtendToFace);
    void SetThroughAllExtent(PartFeatureExtentDirectionEnum Direction);
    void SetToExtent(object ToFace, bool ExtendToFace);
    void SetToNextExtent(PartFeatureExtentDirectionEnum Direction);
}
```

**Returned by:** [CutFeature](../objects/CutFeature.md).Definition, [CutFeatureProxy](../objects/CutFeatureProxy.md).Definition, [CutFeatures](../objects/CutFeatures.md).CreateCutDefinition

**Referenced types:** [CutFeature](../objects/CutFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtent](../objects/PartFeatureExtent.md), [PartFeatureExtentDirectionEnum](../enums/PartFeatureExtentDirectionEnum.md), [PartFeatureExtentEnum](../enums/PartFeatureExtentEnum.md), [Profile](../objects/Profile.md)

