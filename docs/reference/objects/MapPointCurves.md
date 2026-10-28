# MapPointCurves

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.LoftFeatures.Item[…].Definition.MapPointCurves`

```csharp
interface MapPointCurves
{
    // Properties
    object Application { get; }
    int Count { get; }
    MapPointCurve Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    MapPointCurve AddMapCurve();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [LoftDefinition](../objects/LoftDefinition.md).MapPointCurves, [LoftFeatures](../objects/LoftFeatures.md).CreateMapCurves

**Referenced types:** [MapPointCurve](../objects/MapPointCurve.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

