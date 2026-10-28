# Profiles

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].Profiles`

```csharp
interface Profiles
{
    // Properties
    object Application { get; }
    int Count { get; }
    Profile Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Profile AddForSolid(bool Combine = true, object ProfilePathSegments = Missing, object Reserved = Missing);
    Profile AddForSurface(object Curve = Missing);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingSketch](../objects/DrawingSketch.md).Profiles, [PlanarSketch](../objects/PlanarSketch.md).Profiles, [PlanarSketchProxy](../objects/PlanarSketchProxy.md).Profiles, [SketchBlockDefinition](../objects/SketchBlockDefinition.md).Profiles, [SketchBlockDefinitionProxy](../objects/SketchBlockDefinitionProxy.md).Profiles

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Profile](../objects/Profile.md)

