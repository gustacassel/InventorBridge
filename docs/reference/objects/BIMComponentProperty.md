# BIMComponentProperty

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.BIMComponent.ComponentDescription.ComponentPropertySets.Item[…].Item[…]`

```csharp
interface BIMComponentProperty
{
    // Properties
    object Application { get; }
    string InternalName { get; }
    string Name { get; }
    BIMComponentPropertySet Parent { get; }
    ObjectTypeEnum Type { get; }
    string Value { get; set; }
}
```

**Returned by:** [BIMComponentPropertySet](../objects/BIMComponentPropertySet.md).Item

**Referenced types:** [BIMComponentPropertySet](../objects/BIMComponentPropertySet.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

