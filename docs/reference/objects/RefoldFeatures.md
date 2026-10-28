# RefoldFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).RefoldFeatures`

```csharp
interface RefoldFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    RefoldFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RefoldFeature Add(Face StationaryFace, object Bends = Missing, object Sketches = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SheetMetalFeatures](../objects/SheetMetalFeatures.md).RefoldFeatures

**Referenced types:** [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RefoldFeature](../objects/RefoldFeature.md)

