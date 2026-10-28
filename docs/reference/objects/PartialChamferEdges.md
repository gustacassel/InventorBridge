# PartialChamferEdges

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ChamferFeatures.Item[…].Definition.PartialChamferEdges`

```csharp
interface PartialChamferEdges
{
    // Properties
    object Application { get; }
    int Count { get; }
    PartialChamferDrivenDimensionTypeEnum DrivenDimensionType { get; set; }
    PartialChamferEdge Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    PartialChamferEdge Add(object Edge, object Start, object End);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ChamferDefinition](../objects/ChamferDefinition.md).CreatePartialChamferEdges, [ChamferDefinition](../objects/ChamferDefinition.md).PartialChamferEdges

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartialChamferDrivenDimensionTypeEnum](../enums/PartialChamferDrivenDimensionTypeEnum.md), [PartialChamferEdge](../objects/PartialChamferEdge.md)

