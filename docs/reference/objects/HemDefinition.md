# HemDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…] → (HemFeature).Definition`

```csharp
interface HemDefinition
{
    // Properties
    object Application { get; }
    BendOptions BendOptions { get; set; }
    EdgeCollection Edges { get; set; }
    HemTypeEnum HemType { get; }
    object HemTypeDefinition { get; }
    bool IsOnEdgeSide { get; set; }
    bool IsUnfoldMethodOverridden { get; set; }
    HemFeature Parent { get; }
    ObjectTypeEnum Type { get; }
    UnfoldMethod UnfoldMethod { get; set; }
    PartFeatureExtent WidthExtent { get; }
    PartFeatureExtentEnum WidthExtentType { get; }
    // Methods
    HemDefinition Copy();
    void SetCenteredWidthExtent(object Width);
    void SetDoubleHemType(object Gap, object Length);
    void SetEdgeWidthExtent();
    void SetFromToWidthExtent(object FromEntity, object ToEntity);
    void SetOffsetWidthExtent(object OffsetEntityOne, object OffsetDistanceOne, object OffsetEntityTwo, object OffsetDistanceTwo);
    void SetRolledHemType(object Radius, object Angle);
    void SetSingleHemType(object Gap, object Length);
    void SetTeardropHemType(object Radius, object Angle);
    void SetWidthOffsetWidthExtent(object Width, object OffsetDistance, object OffsetEntity, bool PositiveDirection);
}
```

**Returned by:** [DoubleHemDefinition](../objects/DoubleHemDefinition.md).Parent, [HemDefinition](../objects/HemDefinition.md).Copy, [HemFeature](../objects/HemFeature.md).Definition, [HemFeatureProxy](../objects/HemFeatureProxy.md).Definition, [HemFeatures](../objects/HemFeatures.md).CreateHemDefinition, [RolledHemDefinition](../objects/RolledHemDefinition.md).Parent, [SingleHemDefinition](../objects/SingleHemDefinition.md).Parent, [TeardropHemDefinition](../objects/TeardropHemDefinition.md).Parent

**Referenced types:** [BendOptions](../objects/BendOptions.md), [EdgeCollection](../objects/EdgeCollection.md), [HemFeature](../objects/HemFeature.md), [HemTypeEnum](../enums/HemTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartFeatureExtent](../objects/PartFeatureExtent.md), [PartFeatureExtentEnum](../enums/PartFeatureExtentEnum.md), [UnfoldMethod](../objects/UnfoldMethod.md)

