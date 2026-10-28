# iAssemblyFactory

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.iAssemblyFactory`

```csharp
interface iAssemblyFactory
{
    // Properties
    object Application { get; }
    iAssemblyTableRow DefaultRow { get; set; }
    object ExcelWorkSheet { get; }
    FactoryOptions FactoryOptions { get; }
    iAssemblyTableColumn FileNameColumn { get; set; }
    string MemberCacheDir { get; }
    MemberEditScopeEnum MemberEditScope { get; set; }
    AssemblyComponentDefinition Parent { get; }
    iAssemblyTableColumns TableColumns { get; }
    iAssemblyTableRows TableRows { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void CreateMember(object Row = Missing);
    void Delete();
    void Export(string FileName, FileFormatEnum FileFormat, object Options = Missing);
}
```

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).CreateFactory, [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).iAssemblyFactory, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).CreateFactory, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).iAssemblyFactory, [iAssemblyMember](../objects/iAssemblyMember.md).ParentFactory, [iAssemblyTableCell](../objects/iAssemblyTableCell.md).Parent, [iAssemblyTableColumn](../objects/iAssemblyTableColumn.md).Parent, [iAssemblyTableRow](../objects/iAssemblyTableRow.md).Parent

**Referenced types:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [FactoryOptions](../objects/FactoryOptions.md), [FileFormatEnum](../enums/FileFormatEnum.md), [MemberEditScopeEnum](../enums/MemberEditScopeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iAssemblyTableColumn](../objects/iAssemblyTableColumn.md), [iAssemblyTableColumns](../objects/iAssemblyTableColumns.md), [iAssemblyTableRow](../objects/iAssemblyTableRow.md), [iAssemblyTableRows](../objects/iAssemblyTableRows.md)

