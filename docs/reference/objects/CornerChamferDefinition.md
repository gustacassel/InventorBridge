# CornerChamferDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.Item[…] → (CornerChamferFeature).Definition`

```csharp
interface CornerChamferDefinition
{
    // Properties
    object Application { get; }
    ChamferDefinition ChamferDefinition { get; }
    ChamferDefinitionTypeEnum ChamferDefinitionType { get; }
    EdgeCollection CornerEdges { get; set; }
    CornerChamferFeature Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CornerChamferDefinition Copy();
    void SetDistance(EdgeCollection CornerEdges, object Distance);
    void SetDistanceAndAngle(EdgeCollection CornerEdges, Face Face, object Distance, object Angle);
    void SetTwoDistances(Edge CornerEdge, Face Face, object DistanceOne, object DistanceTwo);
}
```

**Returned by:** [CornerChamferDefinition](../objects/CornerChamferDefinition.md).Copy, [CornerChamferFeature](../objects/CornerChamferFeature.md).Definition, [CornerChamferFeatureProxy](../objects/CornerChamferFeatureProxy.md).Definition, [CornerChamferFeatures](../objects/CornerChamferFeatures.md).CreateCornerChamferDefinition

**Referenced types:** [ChamferDefinition](../objects/ChamferDefinition.md), [ChamferDefinitionTypeEnum](../enums/ChamferDefinitionTypeEnum.md), [CornerChamferFeature](../objects/CornerChamferFeature.md), [Edge](../objects/Edge.md), [EdgeCollection](../objects/EdgeCollection.md), [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

