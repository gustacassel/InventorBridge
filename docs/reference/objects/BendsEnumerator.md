# BendsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).Bends`

```csharp
interface BendsEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    Bend Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [RefoldFeature](../objects/RefoldFeature.md).Bends, [RefoldFeatureProxy](../objects/RefoldFeatureProxy.md).Bends, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).Bends, [UnfoldFeature](../objects/UnfoldFeature.md).Bends, [UnfoldFeatureProxy](../objects/UnfoldFeatureProxy.md).Bends

**Referenced types:** [Bend](../objects/Bend.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

