# iPartFactory

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.iPartFactory`

```csharp
interface iPartFactory
{
    // Properties
    object Application { get; }
    bool CustomFactory { get; }
    iPartTableRow DefaultRow { get; set; }
    iPartTableColumn DisplayStyleColumn { get; set; }
    object ExcelWorkSheet { get; }
    FactoryOptions FactoryOptions { get; }
    iPartTableColumn FileNameColumn { get; set; }
    iPartTableColumn MaterialColumn { get; set; }
    string MemberCacheDir { get; }
    MemberEditScopeEnum MemberEditScope { get; set; }
    object Parent { get; }
    iPartTableColumns TableColumns { get; }
    iPartTableRows TableRows { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    iPartMember CreateCustomMember(string FullFileName, object Row = Missing, object CustomInput = Missing);
    iPartMember CreateMember(object Row = Missing);
    void Delete();
    void Export(string FileName, FileFormatEnum FileFormat, object Options = Missing);
}
```

**Returned by:** [PartComponentDefinition](../objects/PartComponentDefinition.md).CreateFactory, [PartComponentDefinition](../objects/PartComponentDefinition.md).iPartFactory, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).CreateFactory, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).iPartFactory, [iPartMember](../objects/iPartMember.md).ParentFactory, [iPartTableCell](../objects/iPartTableCell.md).Parent, [iPartTableColumn](../objects/iPartTableColumn.md).Parent, [iPartTableRow](../objects/iPartTableRow.md).Parent

**Referenced types:** [FactoryOptions](../objects/FactoryOptions.md), [FileFormatEnum](../enums/FileFormatEnum.md), [MemberEditScopeEnum](../enums/MemberEditScopeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [iPartMember](../objects/iPartMember.md), [iPartTableColumn](../objects/iPartTableColumn.md), [iPartTableColumns](../objects/iPartTableColumns.md), [iPartTableRow](../objects/iPartTableRow.md), [iPartTableRows](../objects/iPartTableRows.md)

