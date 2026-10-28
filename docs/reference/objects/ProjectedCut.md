# ProjectedCut

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches.Item[…].ProjectedCuts.Item[…]`

```csharp
interface ProjectedCut
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    string Name { get; set; }
    PlanarSketch Parent { get; }
    SketchEntitiesEnumerator SketchEntities { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void BreakLink();
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [ProjectedCutProxy](../objects/ProjectedCutProxy.md).NativeObject, [ProjectedCuts](../objects/ProjectedCuts.md).Add, [ProjectedCuts](../objects/ProjectedCuts.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PlanarSketch](../objects/PlanarSketch.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md)

