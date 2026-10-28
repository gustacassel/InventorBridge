# PlanarSketches

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches`

```csharp
interface PlanarSketches
{
    // Properties
    object Application { get; }
    int Count { get; }
    PlanarSketch Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    PlanarSketch Add(object PlanarEntity, bool UseFaceEdges = false);
    PlanarSketch AddWithOrientation(object PlanarEntity, object AxisEntity, bool NaturalAxisDirection, bool AxisIsX, object Origin, bool UseFaceEdges = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).Sketches, [FlatPattern](../objects/FlatPattern.md).Sketches, [PartComponentDefinition](../objects/PartComponentDefinition.md).Sketches, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).Sketches, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).Sketches

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PlanarSketch](../objects/PlanarSketch.md)

