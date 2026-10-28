# OnFaceCurves

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Sketches3D.Item[…].OnFaceCurves`

```csharp
interface OnFaceCurves
{
    // Properties
    object Application { get; }
    int Count { get; }
    OnFaceCurve Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    OnFaceCurve Add(NameValueMap Faces, NameValueMap FitPoints);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sketch3D](../objects/Sketch3D.md).OnFaceCurves, [Sketch3DProxy](../objects/Sketch3DProxy.md).OnFaceCurves

**Referenced types:** [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [OnFaceCurve](../objects/OnFaceCurve.md)

