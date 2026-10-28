# iAssemblyTableColumn

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.iAssemblyFactory.FileNameColumn`

```csharp
interface iAssemblyTableColumn
{
    // Properties
    object Application { get; }
    int Count { get; }
    string DisplayHeading { get; }
    string FormattedHeading { get; }
    string Heading { get; }
    int Index { get; }
    iAssemblyTableCell Item[object Index] { get; }
    int Key { get; set; }
    iAssemblyFactory Parent { get; }
    iComponentColumnTypeEnum ReferencedDataType { get; }
    object ReferencedObject { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [iAssemblyFactory](../objects/iAssemblyFactory.md).FileNameColumn, [iAssemblyTableColumns](../objects/iAssemblyTableColumns.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iAssemblyFactory](../objects/iAssemblyFactory.md), [iAssemblyTableCell](../objects/iAssemblyTableCell.md), [iComponentColumnTypeEnum](../enums/iComponentColumnTypeEnum.md)

