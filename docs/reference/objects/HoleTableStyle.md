# HoleTableStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.HoleTableStyles.Item[…]`

```csharp
interface HoleTableStyle
{
    // Properties
    object Application { get; }
    bool ArrangeByPosition { get; set; }
    TextStyle ColumnHeaderTextStyle { get; set; }
    string Comments { get; set; }
    TextStyle DataTextStyle { get; set; }
    bool DeleteTagsOnRollup { get; set; }
    bool GroupHoleTypes { get; set; }
    HeadingPlacementEnum HeadingPlacement { get; set; }
    bool InUse { get; }
    bool IncludeCentermarks { get; set; }
    bool IncludeCircularCuts { get; set; }
    bool IncludeCounterBoreHoleFeatures { get; set; }
    bool IncludeCounterSinkHoleFeatures { get; set; }
    bool IncludeDrilledHoleFeatures { get; set; }
    bool IncludeHoleFeatures { get; set; }
    bool IncludeRecoveredPunchCenters { get; set; }
    bool IncludeThreadedHoleFeatures { get; set; }
    Color InsideLineColor { get; set; }
    double InsideLineWeight { get; set; }
    string InternalName { get; }
    string Name { get; set; }
    Color OutsideLineColor { get; set; }
    double OutsideLineWeight { get; set; }
    object Parent { get; }
    bool PreserveTagging { get; set; }
    bool ReformatOnCustomHoleMatch { get; set; }
    RowMergeTypeEnum RowMergeType { get; set; }
    bool SecondaryTagModifierOnRollup { get; set; }
    bool SequentialNumbering { get; set; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    string Title { get; set; }
    TextStyle TitleTextStyle { get; set; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    bool UseLeaderForTags { get; set; }
    // Methods
    void AddColumn(HolePropertyEnum PropertyType, string CustomPropertyName = "", string Title = "", double Width = 0, HorizontalTextAlignmentEnum TitleHorizontalJustification = HorizontalTextAlignmentEnum.kAlignTextCenter, HorizontalTextAlignmentEnum ValueHorizontalJustification = HorizontalTextAlignmentEnum.kAlignTextCenter);
    Style ConvertToLocal();
    Style Copy(string Name);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void RemoveAllColumns();
    void SaveToGlobal();
    void UpdateFromGlobal();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [HoleTable](../objects/HoleTable.md).Style, [HoleTableStylesEnumerator](../objects/HoleTableStylesEnumerator.md).Item, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).HoleTableStyle

**Referenced types:** [Color](../objects/Color.md), [HeadingPlacementEnum](../enums/HeadingPlacementEnum.md), [HolePropertyEnum](../enums/HolePropertyEnum.md), [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RowMergeTypeEnum](../enums/RowMergeTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [TextStyle](../objects/TextStyle.md)

