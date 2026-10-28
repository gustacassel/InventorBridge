# UnfoldFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).UnfoldFeatures`

```csharp
interface UnfoldFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    UnfoldFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    UnfoldFeature Add(Face StationaryFace, object Bends = Missing, object Sketches = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SheetMetalFeatures](../objects/SheetMetalFeatures.md).UnfoldFeatures

**Referenced types:** [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [UnfoldFeature](../objects/UnfoldFeature.md)

