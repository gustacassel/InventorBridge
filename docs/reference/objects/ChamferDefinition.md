# ChamferDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ChamferFeatures.Item[…].Definition`

```csharp
interface ChamferDefinition
{
    // Properties
    Parameter Angle { get; }
    object Application { get; }
    bool AutomaticEdgeChain { get; }
    EdgeCollection ChamferedEdges { get; set; }
    bool CornerSetback { get; set; }
    ChamferDefinitionTypeEnum DefinitionType { get; }
    Parameter Distance { get; }
    Parameter DistanceOne { get; }
    Parameter DistanceTwo { get; }
    Face Face { get; }
    PartFeature Parent { get; }
    PartialChamferEdges PartialChamferEdges { get; set; }
    bool PreserveAllFeatures { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    PartialChamferEdges CreatePartialChamferEdges();
}
```

**Returned by:** [ChamferFeature](../objects/ChamferFeature.md).Definition, [ChamferFeatureProxy](../objects/ChamferFeatureProxy.md).Definition, [CornerChamferDefinition](../objects/CornerChamferDefinition.md).ChamferDefinition, [PartialChamferEdge](../objects/PartialChamferEdge.md).Parent

**Referenced types:** [ChamferDefinitionTypeEnum](../enums/ChamferDefinitionTypeEnum.md), [EdgeCollection](../objects/EdgeCollection.md), [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [PartFeature](../objects/PartFeature.md), [PartialChamferEdges](../objects/PartialChamferEdges.md)

