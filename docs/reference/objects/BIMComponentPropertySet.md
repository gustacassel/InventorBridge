# BIMComponentPropertySet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BIMComponent.ComponentDescription.ComponentPropertySets.Item[…]`

```csharp
interface BIMComponentPropertySet
{
    // Properties
    object Application { get; }
    int Count { get; }
    string InternalName { get; }
    BIMComponentProperty Item[object Index] { get; }
    string Name { get; }
    BIMComponent Parent { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BIMComponentProperty](../objects/BIMComponentProperty.md).Parent, [BIMComponentPropertySets](../objects/BIMComponentPropertySets.md).Item

**Referenced types:** [BIMComponent](../objects/BIMComponent.md), [BIMComponentProperty](../objects/BIMComponentProperty.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

