# Welds

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition → (WeldmentComponentDefinition).Welds`

```csharp
interface Welds
{
    // Properties
    object Application { get; }
    CosmeticWelds CosmeticWelds { get; }
    int Count { get; }
    Weld Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    WeldBeads WeldBeads { get; }
    // Methods
    void Edit();
    void ExitEdit();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).Welds

**Referenced types:** [CosmeticWelds](../objects/CosmeticWelds.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Weld](../objects/Weld.md), [WeldBeads](../objects/WeldBeads.md)

