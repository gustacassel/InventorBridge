# FilletSetbackVertex

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.FilletFeatures.Item[…].FilletDefinition.SetbackVertexItem[…]`

```csharp
interface FilletSetbackVertex
{
    // Properties
    bool MinimalSetback { get; set; }
    int SetbackCount { get; }
    FilletSetback SetbackItem[int Index] { get; }
    ObjectTypeEnum Type { get; }
    bool UseSetbacks { get; set; }
    Vertex Vertex { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FilletDefinition](../objects/FilletDefinition.md).SetbackVertexItem

**Referenced types:** [FilletSetback](../objects/FilletSetback.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Vertex](../objects/Vertex.md)

