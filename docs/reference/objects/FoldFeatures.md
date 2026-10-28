# FoldFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).FoldFeatures`

```csharp
interface FoldFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    FoldFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    FoldFeature Add(FoldDefinition FoldDefinition);
    FoldDefinition CreateFoldDefinition(SketchLine BendLine, object BendAngle);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SheetMetalFeatures](../objects/SheetMetalFeatures.md).FoldFeatures

**Referenced types:** [FoldDefinition](../objects/FoldDefinition.md), [FoldFeature](../objects/FoldFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchLine](../objects/SketchLine.md)

