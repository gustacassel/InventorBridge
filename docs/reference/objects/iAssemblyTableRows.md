# iAssemblyTableRows

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.iAssemblyFactory.TableRows`

```csharp
interface iAssemblyTableRows
{
    // Properties
    object Application { get; }
    int Count { get; }
    iAssemblyTableRow Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [iAssemblyFactory](../objects/iAssemblyFactory.md).TableRows

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iAssemblyTableRow](../objects/iAssemblyTableRow.md)

