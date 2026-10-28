# BIMComponentPropertySets

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BIMComponent.ComponentDescription.ComponentPropertySets`

```csharp
interface BIMComponentPropertySets
{
    // Properties
    object Application { get; }
    int Count { get; }
    BIMComponentPropertySet Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BIMComponentDescription](../objects/BIMComponentDescription.md).ComponentPropertySets

**Referenced types:** [BIMComponentPropertySet](../objects/BIMComponentPropertySet.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

