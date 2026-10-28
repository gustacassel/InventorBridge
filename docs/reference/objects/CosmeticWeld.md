# CosmeticWeld

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition → (WeldmentComponentDefinition).Welds.CosmeticWelds.Item[…]`

```csharp
interface CosmeticWeld
{
    // Properties
    object Application { get; }
    CosmeticWeldDefinition Definition { get; set; }
    string Name { get; set; }
    Point SymbolAttachPoint { get; }
    Point SymbolBreakPoint { get; }
    ObjectTypeEnum Type { get; }
    string WeldInfo { get; }
    // Methods
    void Delete(bool RetainConsumedSketches = false, bool RetainDependentFeaturesAndSketches = false, bool RetainDependentWorkFeatures = false);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [CosmeticWelds](../objects/CosmeticWelds.md).Add, [CosmeticWelds](../objects/CosmeticWelds.md).Item

**Referenced types:** [CosmeticWeldDefinition](../objects/CosmeticWeldDefinition.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

