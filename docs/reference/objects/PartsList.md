# PartsList

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.PartsLists.Item[…]`

```csharp
interface PartsList
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    TextStyle ColumnHeaderTextStyle { get; set; }
    TextStyle DataTextStyle { get; set; }
    PartsListFilterSettings FilterSettings { get; }
    HeadingPlacementEnum HeadingPlacement { get; set; }
    bool HideZeroQuantityRows { get; set; }
    Layer Layer { get; set; }
    PartsListLevelEnum Level { get; }
    int MaximumRows { get; set; }
    string[] MembersToInclude { get; set; }
    int NumberOfSections { get; set; }
    NumberingSchemeEnum NumberingScheme { get; }
    Sheet Parent { get; }
    PartsListColumns PartsListColumns { get; }
    PartsListRows PartsListRows { get; }
    Point2d Position { get; set; }
    Box2d RangeBox { get; }
    DocumentDescriptor ReferencedDocumentDescriptor { get; }
    double Rotation { get; set; }
    double RowGap { get; }
    LineSpacingEnum RowLineSpacing { get; set; }
    bool ShowTitle { get; set; }
    PartsListStyle Style { get; set; }
    TableDirectionEnum TableDirection { get; set; }
    string Title { get; set; }
    TextStyle TitleTextStyle { get; set; }
    ObjectTypeEnum Type { get; }
    bool WrapAutomatically { get; set; }
    bool WrapLeft { get; set; }
    // Methods
    PartsList CopyTo(Sheet TargetSheet);
    void Delete();
    void Export(string FileName, PartsListFileFormatEnum FileFormat, object Options = Missing);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void Renumber();
    void ReplaceBOMView(PartsListLevelEnum Level, object NumberingScheme = Missing, object MinimumDigitsOrDelimiter = Missing, object IgnoreOverrides = Missing); // since 2027
    void SaveItemOverridesToBOM();
    void Sort(string PrimaryColumnTitle, bool PrimaryColumnAscending = true, string SecondaryColumnTitle = "", bool SecondaryColumnAscending = true, string TertiaryColumnTitle = "", bool TertiaryColumnAscending = true);
    void Sort2(string PrimaryColumnTitle, bool PrimaryColumnAscending = true, string SecondaryColumnTitle = "", bool SecondaryColumnAscending = true, string TertiaryColumnTitle = "", bool TertiaryColumnAscending = true, bool SortByString = true, bool AutoSortOnUpdate = false);
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartsList](../objects/PartsList.md).CopyTo, [PartsListCell](../objects/PartsListCell.md).Parent, [PartsListColumn](../objects/PartsListColumn.md).Parent, [PartsListRow](../objects/PartsListRow.md).Parent, [PartsLists](../objects/PartsLists.md).Add, [PartsLists](../objects/PartsLists.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [DocumentDescriptor](../objects/DocumentDescriptor.md), [HeadingPlacementEnum](../enums/HeadingPlacementEnum.md), [Layer](../objects/Layer.md), [LineSpacingEnum](../enums/LineSpacingEnum.md), [NumberingSchemeEnum](../enums/NumberingSchemeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartsListColumns](../objects/PartsListColumns.md), [PartsListFileFormatEnum](../enums/PartsListFileFormatEnum.md), [PartsListFilterSettings](../objects/PartsListFilterSettings.md), [PartsListLevelEnum](../enums/PartsListLevelEnum.md), [PartsListRows](../objects/PartsListRows.md), [PartsListStyle](../objects/PartsListStyle.md), [Point2d](../objects/Point2d.md), [Sheet](../objects/Sheet.md), [TableDirectionEnum](../enums/TableDirectionEnum.md), [TextStyle](../objects/TextStyle.md)

