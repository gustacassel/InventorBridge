# ProjectedCuts

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].ProjectedCuts`

```csharp
interface ProjectedCuts
{
    // Properties
    object Application { get; }
    int Count { get; }
    ProjectedCut Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ProjectedCut Add();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PlanarSketch](../objects/PlanarSketch.md).ProjectedCuts, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).ProjectedCuts, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).ProjectedCuts, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).ProjectedCuts

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProjectedCut](../objects/ProjectedCut.md)

