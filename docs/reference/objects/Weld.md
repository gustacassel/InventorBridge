# Weld

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition → (WeldmentComponentDefinition).Welds.Item[…]`

```csharp
interface Weld
{
    // Properties
    object Application { get; }
    string Name { get; set; }
    Point SymbolAttachPoint { get; }
    Point SymbolBreakPoint { get; }
    ObjectTypeEnum Type { get; }
    string WeldInfo { get; }
    // Methods
    void Delete(bool RetainConsumedSketches = false, bool RetainDependentFeaturesAndSketches = false, bool RetainDependentWorkFeatures = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Welds](../objects/Welds.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point](../objects/Point.md)

