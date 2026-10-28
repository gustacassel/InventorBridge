# MapPointCurve

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.LoftFeatures.Item[…].Definition.MapPointCurves.Item[…]`

```csharp
interface MapPointCurve
{
    // Properties
    object Application { get; }
    int PointCount { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void GetPosition(int Index, out object Entity, out double Result);
    Point GetPositionPoint(int Index);
    void SetPosition(object Entity, double Value);
    void SetPositionUsingPoint(int SectionIndex, Point Position);
}
```

**Returned by:** [MapPointCurves](../objects/MapPointCurves.md).AddMapCurve, [MapPointCurves](../objects/MapPointCurves.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

