# iPartTableRows

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.iPartFactory.TableRows`

```csharp
interface iPartTableRows
{
    // Properties
    object Application { get; }
    int Count { get; }
    iPartTableRow Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [iPartFactory](../objects/iPartFactory.md).TableRows

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iPartTableRow](../objects/iPartTableRow.md)

