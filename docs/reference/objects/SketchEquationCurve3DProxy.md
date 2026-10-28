# SketchEquationCurve3DProxy

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [SketchEquationCurve3D](../objects/SketchEquationCurve3D.md) → [SketchEntity3D](../objects/SketchEntity3D.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].SketchEquationCurves3D.Item[…] → (SketchEquationCurve3DProxy)`

```csharp
interface SketchEquationCurve3DProxy
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    ConstraintStatusEnum ConstraintStatus { get; }
    SketchConstraints3DEnumerator Constraints3D { get; }
    bool Construction { get; set; }
    ComponentOccurrence ContainingOccurrence { get; }
    bool CurvatureDisplay { get; set; }
    SketchPoint3D EndSketchPoint { get; }
    BSplineCurve Geometry { get; }
    bool HasReferenceComponent { get; }
    double Length { get; }
    SketchEquationCurve3D NativeObject { get; }
    SketchEntities3DEnumerator OwnedBy { get; }
    Sketch3D Parent { get; }
    Box RangeBox { get; }
    bool Reference { get; set; }
    ReferenceComponent ReferenceComponent { get; }
    object ReferencedEntity { get; }
    SketchPoint3D StartSketchPoint { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetEquation(out CoordinateSystemTypeEnum CoordinateSystemType, out string XValueOrRadius, out string YValueOrTheta, out string ZValueOrPhi, out Parameter MinValue, out Parameter MaxValue);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SetEquation(CoordinateSystemTypeEnum CoordinateSystemType, string XValueOrRadius, string YValueOrTheta, string ZValueOrPhi, object MinValue, object MaxValue);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [BSplineCurve](../objects/BSplineCurve.md), [Box](../objects/Box.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [ConstraintStatusEnum](../enums/ConstraintStatusEnum.md), [CoordinateSystemTypeEnum](../enums/CoordinateSystemTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md), [ReferenceComponent](../objects/ReferenceComponent.md), [Sketch3D](../objects/Sketch3D.md), [SketchConstraints3DEnumerator](../objects/SketchConstraints3DEnumerator.md), [SketchEntities3DEnumerator](../objects/SketchEntities3DEnumerator.md), [SketchEquationCurve3D](../objects/SketchEquationCurve3D.md), [SketchPoint3D](../objects/SketchPoint3D.md)

