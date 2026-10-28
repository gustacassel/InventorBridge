# ProjectToSurfaceCurve

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].ProjectToSurfaceCurves.Item[…]`

```csharp
interface ProjectToSurfaceCurve
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ObjectCollection Curves { get; set; }
    ObjectCollection Faces { get; set; }
    string Name { get; set; }
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

**Returned by:** [ProjectToSurfaceCurve](../objects/ProjectToSurfaceCurve.md).Edit, [ProjectToSurfaceCurveProxy](../objects/ProjectToSurfaceCurveProxy.md).Edit, [ProjectToSurfaceCurveProxy](../objects/ProjectToSurfaceCurveProxy.md).NativeObject, [ProjectToSurfaceCurves](../objects/ProjectToSurfaceCurves.md).Add, [ProjectToSurfaceCurves](../objects/ProjectToSurfaceCurves.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProjectCurveToSurfaceTypeEnum](../enums/ProjectCurveToSurfaceTypeEnum.md), [Sketch3D](../objects/Sketch3D.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md)

