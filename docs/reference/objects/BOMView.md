# BOMView

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.BOM.BOMViews.Item[…]`

```csharp
interface BOMView
{
    // Properties
    object Application { get; }
    BOMRowsEnumerator BOMRows { get; }
    string ModelStateMemberName { get; }
    string Name { get; }
    BOM Parent { get; }
    string RevisionId { get; }
    ObjectTypeEnum Type { get; }
    BOMViewTypeEnum ViewType { get; }
    string iAssemblyMemberName { get; set; }
    // Methods
    void Export(string FileName, FileFormatEnum FileFormat, object Options = Missing);
    void Renumber(int StartValue = 1, int Increment = 1, object BOMRowsToRenumber = Missing);
    void Sort(string PrimaryColumnTitle, bool PrimaryColumnAscending = true, string SecondaryColumnTitle = "", bool SecondaryColumnAscending = true, string TertiaryColumnTitle = "", bool TertiaryColumnAscending = true);
    void Sort2(string PrimaryColumnTitle, bool PrimaryColumnAscending = true, string SecondaryColumnTitle = "", bool SecondaryColumnAscending = true, string TertiaryColumnTitle = "", bool TertiaryColumnAscending = true, bool SortByString = true);
}
```

**Returned by:** [BOMViews](../objects/BOMViews.md).Item

**Referenced types:** [BOM](../objects/BOM.md), [BOMRowsEnumerator](../objects/BOMRowsEnumerator.md), [BOMViewTypeEnum](../enums/BOMViewTypeEnum.md), [FileFormatEnum](../enums/FileFormatEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

