# FilletVariableRadiusEdgeSet

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [FilletRadiusEdgeSet](../objects/FilletRadiusEdgeSet.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.FilletFeatures.Item[…].FilletDefinition.EdgeSetItem[…] → (FilletVariableRadiusEdgeSet)`

```csharp
interface FilletVariableRadiusEdgeSet
{
    // Properties
    object Application { get; }
    ContinuityTypeEnum ContinuityType { get; set; }
    EdgeCollection Edges { get; }
    Parameter EndRadius { get; }
    int IntermediateRadiusCount { get; }
    FilletIntermediateRadius IntermediateRadiusItem[int Index] { get; }
    Parameter StartRadius { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    FilletIntermediateRadius AddIntermediateRadius(Edge Edge, object Radius, object PercentLength);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FilletDefinition](../objects/FilletDefinition.md).AddVariableRadiusEdgeSet

**Referenced types:** [ContinuityTypeEnum](../enums/ContinuityTypeEnum.md), [Edge](../objects/Edge.md), [EdgeCollection](../objects/EdgeCollection.md), [FilletIntermediateRadius](../objects/FilletIntermediateRadius.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md)

