# PartsListStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.PartsListStyles.Item[…]`

```csharp
interface PartsListStyle
{
    // Properties
    object Application { get; }
    TextStyle ColumnHeaderTextStyle { get; set; }
    string Comments { get; set; }
    TextStyle DataTextStyle { get; set; }
    double HeadingGap { get; set; }
    HeadingPlacementEnum HeadingPlacement { get; set; }
    bool InUse { get; }
    string InternalName { get; }
    string Name { get; set; }
    object Parent { get; }
    double RowGap { get; set; }
    LineSpacingEnum RowLineSpacing { get; set; }
    bool ShowTitle { get; set; }
    PartsListSortSettings SortSettings { get; } // since 2025
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    TableDirectionEnum TableDirection { get; set; }
    string Title { get; set; }
    TextStyle TitleTextStyle { get; set; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    // Methods
    void AddColumn(PropertyTypeEnum PropertyType, string PropertySetId = "", object PropertyIdentifier = Missing, string Title = "", double Width = 0, HorizontalTextAlignmentEnum TitleHorizontalJustification = HorizontalTextAlignmentEnum.kAlignTextCenter, HorizontalTextAlignmentEnum ValueHorizontalJustification = HorizontalTextAlignmentEnum.kAlignTextCenter);
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

**Returned by:** [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).PartsListStyle, [PartsList](../objects/PartsList.md).Style, [PartsListStylesEnumerator](../objects/PartsListStylesEnumerator.md).Item

**Referenced types:** [HeadingPlacementEnum](../enums/HeadingPlacementEnum.md), [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [LineSpacingEnum](../enums/LineSpacingEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartsListSortSettings](../objects/PartsListSortSettings.md), [PropertyTypeEnum](../enums/PropertyTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [TableDirectionEnum](../enums/TableDirectionEnum.md), [TextStyle](../objects/TextStyle.md)

