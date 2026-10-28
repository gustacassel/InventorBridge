# FlangeFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).FlangeFeatures`

```csharp
interface FlangeFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    FlangeFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    FlangeFeature Add(FlangeDefinition FlangeDefinition);
    FlangeDefinition CreateDefinition(EdgeCollection Edges, FlangeReferenceTypeEnum FlangeAngleReferenceType, object FlangeAngleOrFlangeAngleReferencePlane, object FlangePlacementType = Missing, object Distance = Missing, object Options = Missing); // since 2025
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SheetMetalFeatures](../objects/SheetMetalFeatures.md).FlangeFeatures

**Referenced types:** [EdgeCollection](../objects/EdgeCollection.md), [FlangeDefinition](../objects/FlangeDefinition.md), [FlangeFeature](../objects/FlangeFeature.md), [FlangeReferenceTypeEnum](../enums/FlangeReferenceTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

