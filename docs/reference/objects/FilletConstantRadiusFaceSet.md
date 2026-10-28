# FilletConstantRadiusFaceSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.FilletFeatures.Item[…].FilletDefinition.FaceSet`

```csharp
interface FilletConstantRadiusFaceSet
{
    // Properties
    object Application { get; }
    Point BiasPoint { get; }
    FaceCollection FacesOne { get; }
    bool FacesOneReverseDirection { get; }
    FaceCollection FacesTwo { get; }
    bool FacesTwoReverseDirection { get; }
    bool IncludeTangentFaces { get; }
    Parameter Radius { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [FilletDefinition](../objects/FilletDefinition.md).AddFaceSet, [FilletDefinition](../objects/FilletDefinition.md).FaceSet

**Referenced types:** [FaceCollection](../objects/FaceCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [Point](../objects/Point.md)

