# ContourFlangeFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).ContourFlangeFeatures`

```csharp
interface ContourFlangeFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    ContourFlangeFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ContourFlangeFeature Add(ContourFlangeDefinition ContourFlangeDefinition);
    ContourFlangeDefinition CreateDefinition(Path Path, object Operation = Missing, object WidthExtentsFromSketchPlane = Missing, object EdgeSet = Missing, object BendEdges = Missing); // since 2026
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SheetMetalFeatures](../objects/SheetMetalFeatures.md).ContourFlangeFeatures

**Referenced types:** [ContourFlangeDefinition](../objects/ContourFlangeDefinition.md), [ContourFlangeFeature](../objects/ContourFlangeFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Path](../objects/Path.md)

