# DecalFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.DecalFeatures`

```csharp
interface DecalFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    DecalFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DecalFeature Add(SketchImage Image, Face Face, bool WrapFace = false, bool ChainFaces = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).DecalFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).DecalFeatures

**Referenced types:** [DecalFeature](../objects/DecalFeature.md), [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SketchImage](../objects/SketchImage.md)

