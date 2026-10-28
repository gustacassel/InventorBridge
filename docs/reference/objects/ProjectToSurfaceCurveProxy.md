# ProjectToSurfaceCurveProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ProjectToSurfaceCurve](../objects/ProjectToSurfaceCurve.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].ProjectToSurfaceCurves.Item[…] → (ProjectToSurfaceCurveProxy)`

```csharp
interface ProjectToSurfaceCurveProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ComponentOccurrence ContainingOccurrence { get; }
    ObjectCollection Curves { get; set; }
    ObjectCollection Faces { get; set; }
    string Name { get; set; }
    ProjectToSurfaceCurve NativeObject { get; }
    Sketch3D Parent { get; }
    object ProjectDirection { get; set; }
    ProjectCurveToSurfaceTypeEnum ProjectionType { get; set; }
    SketchEntities3DEnumerator SketchEntities { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void BreakLink();
    void Delete();
    ProjectToSurfaceCurve Edit(ObjectCollection Faces, ObjectCollection Curves, object ProjectionType = Missing, object ProjectDirection = Missing);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProjectCurveToSurfaceTypeEnum](../enums/ProjectCurveToSurfaceTypeEnum.md), [ProjectToSurfaceCurve](../objects/ProjectToSurfaceCurve.md), [Sketch3D](../objects/Sketch3D.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md)

