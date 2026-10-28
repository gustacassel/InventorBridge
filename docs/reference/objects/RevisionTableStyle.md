# RevisionTableStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.RevisionTableStyles.Item[…]`

```csharp
interface RevisionTableStyle
{
    // Properties
    bool AllowLandingLineForRevisionTags { get; set; }
    object Application { get; }
    TextStyle ColumnHeaderTextStyle { get; set; }
    string Comments { get; set; }
    TextStyle DataTextStyle { get; set; }
    double HeadingGap { get; set; }
    HeadingPlacementEnum HeadingPlacement { get; set; }
    bool InUse { get; }
    Color InsideLineColor { get; set; }
    double InsideLineWeight { get; set; }
    string InternalName { get; }
    string Name { get; set; }
    Color OutsideLineColor { get; set; }
    double OutsideLineWeight { get; set; }
    object Parent { get; }
    RevisionIndexDefaults RevisionIndexDefaults { get; } // since 2025
    LeaderStyle RevisionTagLeaderStyle { get; set; }
    RevisionTagShapeEnum RevisionTagShape { get; set; }
    TextStyle RevisionTagTextStyle { get; set; }
    double RowGap { get; set; }
    LineSpacingEnum RowLineSpacing { get; set; }
    bool ShowTitle { get; set; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    TableDirectionEnum TableDirection { get; set; }
    string Title { get; set; }
    TextStyle TitleTextStyle { get; set; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    // Methods
    void AddColumn(RevisionTablePropertyEnum PropertyType, string PropertySetId = "", object PropertyIdentifier = Missing, string Title = "", double Width = 0, HorizontalTextAlignmentEnum TitleHorizontalJustification = HorizontalTextAlignmentEnum.kAlignTextCenter, HorizontalTextAlignmentEnum ValueHorizontalJustification = HorizontalTextAlignmentEnum.kAlignTextCenter);
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

**Returned by:** [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).RevisionTableStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).RevisionTagStyle, [RevisionTable](../objects/RevisionTable.md).Style, [RevisionTableStylesEnumerator](../objects/RevisionTableStylesEnumerator.md).Item

**Referenced types:** [Color](../objects/Color.md), [HeadingPlacementEnum](../enums/HeadingPlacementEnum.md), [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [LeaderStyle](../objects/LeaderStyle.md), [LineSpacingEnum](../enums/LineSpacingEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RevisionIndexDefaults](../objects/RevisionIndexDefaults.md), [RevisionTablePropertyEnum](../enums/RevisionTablePropertyEnum.md), [RevisionTagShapeEnum](../enums/RevisionTagShapeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [TableDirectionEnum](../enums/TableDirectionEnum.md), [TextStyle](../objects/TextStyle.md)

