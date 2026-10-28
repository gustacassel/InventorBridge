# PartialChamferEdge

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ChamferFeatures.Item[…].Definition.PartialChamferEdges.Item[…]`

```csharp
interface PartialChamferEdge
{
    // Properties
    object ChamferDistance { get; set; }
    EdgeCollection Edge { get; }
    object EndDistance { get; set; }
    ChamferDefinition Parent { get; }
    object StartDistance { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [PartialChamferEdges](../objects/PartialChamferEdges.md).Add, [PartialChamferEdges](../objects/PartialChamferEdges.md).Item

**Referenced types:** [ChamferDefinition](../objects/ChamferDefinition.md), [EdgeCollection](../objects/EdgeCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

