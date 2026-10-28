# ProjectToSurfaceCurves

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].ProjectToSurfaceCurves`

```csharp
interface ProjectToSurfaceCurves
{
    // Properties
    object Application { get; }
    int Count { get; }
    ProjectToSurfaceCurve Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ProjectToSurfaceCurve Add(ObjectCollection Faces, ObjectCollection Curves, object ProjectionType = Missing, object ProjectDirection = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).ProjectToSurfaceCurves, [Sketch3DProxy](../objects/Sketch3DProxy.md).ProjectToSurfaceCurves

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ProjectToSurfaceCurve](../objects/ProjectToSurfaceCurve.md)

