# FilletIntermediateRadius

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.FilletFeatures.Item[…].FilletDefinition.EdgeSetItem[…] → (FilletVariableRadiusEdgeSet).IntermediateRadiusItem[…]`

```csharp
interface FilletIntermediateRadius
{
    // Properties
    Edge Edge { get; }
    Parameter PercentLength { get; }
    Parameter Radius { get; }
}
```

**Returned by:** [FilletVariableRadiusEdgeSet](../objects/FilletVariableRadiusEdgeSet.md).AddIntermediateRadius, [FilletVariableRadiusEdgeSet](../objects/FilletVariableRadiusEdgeSet.md).IntermediateRadiusItem

**Referenced types:** [Edge](../objects/Edge.md), [Parameter](../objects/Parameter.md)

