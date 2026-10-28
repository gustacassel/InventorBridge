# SketchFillRegion

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).BorderDefinitions.Item[…].Sketch.SketchFillRegions.Item[…]`

```csharp
interface SketchFillRegion
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    Color Color { get; set; }
    Sketch Parent { get; }
    Profile Profile { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [SketchFillRegions](../objects/SketchFillRegions.md).Add, [SketchFillRegions](../objects/SketchFillRegions.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Color](../objects/Color.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Profile](../objects/Profile.md), [Sketch](../objects/Sketch.md)

