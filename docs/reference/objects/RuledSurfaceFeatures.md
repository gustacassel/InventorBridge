# RuledSurfaceFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.RuledSurfaceFeatures`

```csharp
interface RuledSurfaceFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    RuledSurfaceFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RuledSurfaceFeature Add(RuledSurfaceDefinition Definition);
    RuledSurfaceDefinition CreateDefinition(RuledSurfaceTypeEnum RuledSurfaceType, object GeneratrixCurves, object Distance, object Vector = Missing);
    RuledSurfaceEdgeFacePairs CreateRuledSurfaceEdgeFacePairs();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartFeatures](../objects/PartFeatures.md).RuledSurfaceFeatures, [SheetMetalFeatures](../objects/SheetMetalFeatures.md).RuledSurfaceFeatures

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RuledSurfaceDefinition](../objects/RuledSurfaceDefinition.md), [RuledSurfaceEdgeFacePairs](../objects/RuledSurfaceEdgeFacePairs.md), [RuledSurfaceFeature](../objects/RuledSurfaceFeature.md), [RuledSurfaceTypeEnum](../enums/RuledSurfaceTypeEnum.md)

