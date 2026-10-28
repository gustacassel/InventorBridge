# FilletFullRoundSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.FilletFeatures.Item[…].FilletDefinition.FullRoundSet`

```csharp
interface FilletFullRoundSet
{
    // Properties
    object Application { get; }
    FaceCollection CenterFaces { get; }
    bool IncludeTangentFaces { get; }
    FaceCollection SideFacesOne { get; }
    FaceCollection SideFacesTwo { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [FilletDefinition](../objects/FilletDefinition.md).AddFullRoundSet, [FilletDefinition](../objects/FilletDefinition.md).FullRoundSet

**Referenced types:** [FaceCollection](../objects/FaceCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

