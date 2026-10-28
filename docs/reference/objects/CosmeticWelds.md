# CosmeticWelds

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition → (WeldmentComponentDefinition).Welds.CosmeticWelds`

```csharp
interface CosmeticWelds
{
    // Properties
    object Application { get; }
    int Count { get; }
    CosmeticWeld Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    CosmeticWeld Add(CosmeticWeldDefinition CosmeticWeldDefinition);
    CosmeticWeldDefinition CreateDefinition(EdgeCollection Edges);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Welds](../objects/Welds.md).CosmeticWelds

**Referenced types:** [CosmeticWeld](../objects/CosmeticWeld.md), [CosmeticWeldDefinition](../objects/CosmeticWeldDefinition.md), [EdgeCollection](../objects/EdgeCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

