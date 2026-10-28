# FilletSetback

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.FilletFeatures.Item[…].FilletDefinition.SetbackVertexItem[…].SetbackItem[…]`

```csharp
interface FilletSetback
{
    // Properties
    Edge Edge { get; }
    object Setback { get; set; }
}
```

**Returned by:** [FilletSetbackVertex](../objects/FilletSetbackVertex.md).SetbackItem

**Referenced types:** [Edge](../objects/Edge.md)

