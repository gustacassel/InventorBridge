# Profile

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].Profiles.Item[…]`

```csharp
interface Profile
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    int Count { get; }
    ProfilePath Item[int Index] { get; }
    bool MergeFaces { get; set; }
    Sketch Parent { get; }
    RegionProperties RegionProperties { get; }
    ObjectTypeEnum Type { get; }
    Wires Wires { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BreakOutOperation](../objects/BreakOutOperation.md).Profile, [CoilFeature](../objects/CoilFeature.md).Profile, [CoilFeatureProxy](../objects/CoilFeatureProxy.md).Profile, [CutDefinition](../objects/CutDefinition.md).Profile, [EmbossFeature](../objects/EmbossFeature.md).Profile, [EmbossFeatureProxy](../objects/EmbossFeatureProxy.md).Profile, [ExtrudeDefinition](../objects/ExtrudeDefinition.md).Profile, [FaceFeatureDefinition](../objects/FaceFeatureDefinition.md).Profile, [ProfilePath](../objects/ProfilePath.md).Parent, [ProfilePathProxy](../objects/ProfilePathProxy.md).Parent, [ProfileProxy](../objects/ProfileProxy.md).NativeObject, [Profiles](../objects/Profiles.md).AddForSolid, [Profiles](../objects/Profiles.md).AddForSurface, [Profiles](../objects/Profiles.md).Item, [RevolveFeature](../objects/RevolveFeature.md).Profile, [RevolveFeatureProxy](../objects/RevolveFeatureProxy.md).Profile, [SketchFillRegion](../objects/SketchFillRegion.md).Profile, [SketchHatchRegion](../objects/SketchHatchRegion.md).Profile, [SweepDefinition](../objects/SweepDefinition.md).Profile

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProfilePath](../objects/ProfilePath.md), [RegionProperties](../objects/RegionProperties.md), [Sketch](../objects/Sketch.md), [Wires](../objects/Wires.md)

