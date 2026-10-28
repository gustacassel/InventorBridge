# TableStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.TableStyles.Item[…]`

```csharp
interface TableStyle
{
    // Properties
    object Application { get; }
    TextStyle ColumnHeaderTextStyle { get; set; }
    HorizontalTextAlignmentEnum ColumnTitleHorizontalJustification { get; set; }
    HorizontalTextAlignmentEnum ColumnValueHorizontalJustification { get; set; }
    double ColumnWidth { get; set; }
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
    void AddColumn(string Title = "", double Width = 0, HorizontalTextAlignmentEnum TitleHorizontalJustification = HorizontalTextAlignmentEnum.kAlignTextCenter, HorizontalTextAlignmentEnum ValueHorizontalJustification = HorizontalTextAlignmentEnum.kAlignTextCenter);
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

**Returned by:** [CustomTable](../objects/CustomTable.md).Style, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).BendTableStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).ConfigurationTableStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).TableStyle, [TableStylesEnumerator](../objects/TableStylesEnumerator.md).Item

**Referenced types:** [Color](../objects/Color.md), [HeadingPlacementEnum](../enums/HeadingPlacementEnum.md), [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [LineSpacingEnum](../enums/LineSpacingEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [TableDirectionEnum](../enums/TableDirectionEnum.md), [TextStyle](../objects/TextStyle.md)

