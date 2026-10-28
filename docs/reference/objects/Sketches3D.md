# Sketches3D

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D`

```csharp
interface Sketches3D
{
    // Properties
    object Application { get; }
    int Count { get; }
    Sketch3D Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Sketch3D Add();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPattern](../objects/FlatPattern.md).Sketches3D, [PartComponentDefinition](../objects/PartComponentDefinition.md).Sketches3D, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).Sketches3D

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch3D](../objects/Sketch3D.md)

