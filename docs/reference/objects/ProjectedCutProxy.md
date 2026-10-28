# ProjectedCutProxy

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ProjectedCutProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    string Name { get; set; }
    ProjectedCut NativeObject { get; }
    PlanarSketch Parent { get; }
    SketchEntitiesEnumerator SketchEntities { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void BreakLink();
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PlanarSketch](../objects/PlanarSketch.md), [ProjectedCut](../objects/ProjectedCut.md), [SketchEntitiesEnumerator](../objects/SketchEntitiesEnumerator.md)

