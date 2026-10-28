# BOMViews

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.BOM.BOMViews`

```csharp
interface BOMViews
{
    // Properties
    object Application { get; }
    int Count { get; }
    BOMView Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BOM](../objects/BOM.md).BOMViews

**Referenced types:** [BOMView](../objects/BOMView.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

