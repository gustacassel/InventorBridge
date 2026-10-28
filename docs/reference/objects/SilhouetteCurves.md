# SilhouetteCurves

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SilhouetteCurves`

```csharp
interface SilhouetteCurves
{
    // Properties
    object Application { get; }
    int Count { get; }
    SilhouetteCurve Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SilhouetteCurve AddSilhouette(SurfaceBody Body, object DirectionEntity, object ExcludedFaces = Missing, object ExcludeStraightFaces = Missing, object ExcludeInteralFaces = Missing);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).SilhouetteCurves, [Sketch3DProxy](../objects/Sketch3DProxy.md).SilhouetteCurves

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SilhouetteCurve](../objects/SilhouetteCurve.md), [SurfaceBody](../objects/SurfaceBody.md)

