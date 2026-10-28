# iPartTableColumns

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.iPartFactory.TableColumns`

```csharp
interface iPartTableColumns
{
    // Properties
    object Application { get; }
    int Count { get; }
    iPartTableColumn Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [iPartFactory](../objects/iPartFactory.md).TableColumns

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iPartTableColumn](../objects/iPartTableColumn.md)

