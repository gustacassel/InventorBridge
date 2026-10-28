# SilhouetteCurveProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SilhouetteCurve](../objects/SilhouetteCurve.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SilhouetteCurves.Item[…] → (SilhouetteCurveProxy)`

```csharp
interface SilhouetteCurveProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    SurfaceBody Body { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    object DirectionEntity { get; set; }
    bool ExcludeInternalFaces { get; set; }
    bool ExcludeStraightFaces { get; set; }
    FaceCollection ExcludedFaces { get; set; }
    string Name { get; set; }
    SilhouetteCurve NativeObject { get; }
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

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [FaceCollection](../objects/FaceCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SilhouetteCurve](../objects/SilhouetteCurve.md), [Sketch3D](../objects/Sketch3D.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SurfaceBody](../objects/SurfaceBody.md)

