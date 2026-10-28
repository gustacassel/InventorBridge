# RuledSurfaceDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.RuledSurfaceFeatures.Item[…].Definition`

```csharp
interface RuledSurfaceDefinition
{
    // Properties
    object Application { get; }
    object Distance { get; set; }
    object DraftAngle { get; set; }
    bool FlipExtendDirection { get; set; }
    object GeneratrixCurves { get; set; }
    RuledSurfaceFeature Parent { get; }
    RuledSurfaceTypeEnum RuledSurfaceType { get; }
    ObjectTypeEnum Type { get; }
    object Vector { get; set; }
    // Methods
    RuledSurfaceDefinition Copy();
    void SetToNormal(RuledSurfaceEdgeFacePairs GeneratrixCurves, object Distance, bool FlipExtendDirection = false);
    void SetToSweep(object GeneratrixCurves, object Distance, object Vector, bool FlipExtendDirection = false);
    void SetToTangent(RuledSurfaceEdgeFacePairs GeneratrixCurves, object Distance, bool FlipExtendDirection = false);
}
```

**Returned by:** [RuledSurfaceDefinition](../objects/RuledSurfaceDefinition.md).Copy, [RuledSurfaceFeature](../objects/RuledSurfaceFeature.md).Definition, [RuledSurfaceFeatureProxy](../objects/RuledSurfaceFeatureProxy.md).Definition, [RuledSurfaceFeatures](../objects/RuledSurfaceFeatures.md).CreateDefinition

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RuledSurfaceEdgeFacePairs](../objects/RuledSurfaceEdgeFacePairs.md), [RuledSurfaceFeature](../objects/RuledSurfaceFeature.md), [RuledSurfaceTypeEnum](../enums/RuledSurfaceTypeEnum.md)

