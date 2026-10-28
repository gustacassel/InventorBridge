# HoleTable

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.HoleTables.Item[…]`

```csharp
interface HoleTable
{
    // Properties
    object Application { get; }
    bool ArrangeByPosition { get; set; }
    AttributeSets AttributeSets { get; }
    TextStyle ColumnHeaderTextStyle { get; set; }
    TextStyle DataTextStyle { get; set; }
    bool DeleteTagsOnRollup { get; set; }
    bool GroupHoleTypes { get; set; }
    HeadingPlacementEnum HeadingPlacement { get; set; }
    HoleTableColumns HoleTableColumns { get; }
    HoleTableRows HoleTableRows { get; }
    HoleTableTypeEnum HoleTableType { get; }
    bool IncludeCentermarks { get; set; }
    bool IncludeCircularCuts { get; set; }
    bool IncludeCounterBoreHoleFeatures { get; set; }
    bool IncludeCounterSinkHoleFeatures { get; set; }
    bool IncludeDrilledHoleFeatures { get; set; }
    bool IncludeHoleFeatures { get; set; }
    bool IncludeRecoveredPunchCenters { get; set; }
    bool IncludeThreadedHoleFeatures { get; set; }
    Layer Layer { get; set; }
    Sheet Parent { get; }
    DrawingView ParentView { get; }
    Point2d Position { get; set; }
    bool PreserveTagging { get; set; }
    Box2d RangeBox { get; }
    bool ReformatOnCustomHoleMatch { get; set; }
    RowMergeTypeEnum RowMergeType { get; set; }
    bool SecondaryTagModifierOnRollup { get; set; }
    bool SequentialNumbering { get; set; }
    bool ShowTitle { get; set; }
    HoleTableStyle Style { get; set; }
    string Title { get; set; }
    TextStyle TitleTextStyle { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
    void Export(string FileName, FileFormatEnum FileFormat, object Options = Missing);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void MatchCustomHoles(ObjectCollection HoleTags);
    void ShowTags(bool Value);
}
```

**Returned by:** [HoleTableCell](../objects/HoleTableCell.md).Parent, [HoleTableColumn](../objects/HoleTableColumn.md).Parent, [HoleTableRow](../objects/HoleTableRow.md).Parent, [HoleTables](../objects/HoleTables.md).Add, [HoleTables](../objects/HoleTables.md).AddByFeatureType, [HoleTables](../objects/HoleTables.md).AddSelected, [HoleTables](../objects/HoleTables.md).Item

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [Box2d](../objects/Box2d.md), [DrawingView](../objects/DrawingView.md), [FileFormatEnum](../enums/FileFormatEnum.md), [HeadingPlacementEnum](../enums/HeadingPlacementEnum.md), [HoleTableColumns](../objects/HoleTableColumns.md), [HoleTableRows](../objects/HoleTableRows.md), [HoleTableStyle](../objects/HoleTableStyle.md), [HoleTableTypeEnum](../enums/HoleTableTypeEnum.md), [Layer](../objects/Layer.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [RowMergeTypeEnum](../enums/RowMergeTypeEnum.md), [Sheet](../objects/Sheet.md), [TextStyle](../objects/TextStyle.md)

