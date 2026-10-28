# RipFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features → (SheetMetalFeatures).RipFeatures`

```csharp
interface RipFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    RipFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RipFeature Add(RipDefinition RipDefinition);
    RipDefinition CreateRipDefinition(Face RipFace);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [SheetMetalFeatures](../objects/SheetMetalFeatures.md).RipFeatures

**Referenced types:** [Face](../objects/Face.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RipDefinition](../objects/RipDefinition.md), [RipFeature](../objects/RipFeature.md)

