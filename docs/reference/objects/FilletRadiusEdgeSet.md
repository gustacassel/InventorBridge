# FilletRadiusEdgeSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.FilletFeatures.Item[…].FilletDefinition.EdgeSetItem[…]`

```csharp
interface FilletRadiusEdgeSet
{
    // Properties
    object Application { get; }
    EdgeCollection Edges { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [FilletDefinition](../objects/FilletDefinition.md).EdgeSetItem

**Referenced types:** [EdgeCollection](../objects/EdgeCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

