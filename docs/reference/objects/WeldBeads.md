# WeldBeads

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition → (WeldmentComponentDefinition).Welds.WeldBeads`

```csharp
interface WeldBeads
{
    // Properties
    object Application { get; }
    int Count { get; }
    WeldBead Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Welds](../objects/Welds.md).WeldBeads

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [WeldBead](../objects/WeldBead.md)

