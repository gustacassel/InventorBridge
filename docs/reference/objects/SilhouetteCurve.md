# SilhouetteCurve

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SilhouetteCurves.Item[…]`

```csharp
interface SilhouetteCurve
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    SurfaceBody Body { get; set; }
    object DirectionEntity { get; set; }
    bool ExcludeInternalFaces { get; set; }
    bool ExcludeStraightFaces { get; set; }
    FaceCollection ExcludedFaces { get; set; }
    string Name { get; set; }
    Sketch3D Parent { get; }
    SketchEntities3DEnumerator SketchEntities { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void BreakLink();
    void Delete();
    SilhouetteCurve Edit(SurfaceBody FacesOrBody, object DirectionEntity, object ExcludedFaces = Missing, object ExcludeStraightFaces = Missing, object ExcludeInternalFaces = Missing);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SilhouetteCurve](../objects/SilhouetteCurve.md).Edit, [SilhouetteCurveProxy](../objects/SilhouetteCurveProxy.md).Edit, [SilhouetteCurveProxy](../objects/SilhouetteCurveProxy.md).NativeObject, [SilhouetteCurves](../objects/SilhouetteCurves.md).AddSilhouette, [SilhouetteCurves](../objects/SilhouetteCurves.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [FaceCollection](../objects/FaceCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sketch3D](../objects/Sketch3D.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SurfaceBody](../objects/SurfaceBody.md)

