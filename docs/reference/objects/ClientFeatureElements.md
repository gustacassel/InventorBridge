# ClientFeatureElements

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.ClientFeatures.Item[…].Definition.ClientFeatureElements`

```csharp
interface ClientFeatureElements
{
    // Properties
    object Application { get; }
    int Count { get; }
    ClientFeatureElement Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ClientFeatureElement Add(object Element, bool BrowserVisible = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ClientFeatureDefinition](../objects/ClientFeatureDefinition.md).ClientFeatureElements

**Referenced types:** [ClientFeatureElement](../objects/ClientFeatureElement.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

