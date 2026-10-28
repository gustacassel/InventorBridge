# TextStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (PartDocument).TextStyles.Item[…]`

```csharp
interface TextStyle
{
    // Properties
    object Application { get; }
    bool Bold { get; set; }
    Color Color { get; set; }
    string Comments { get; set; }
    string Font { get; set; }
    double FontSize { get; set; }
    HorizontalTextAlignmentEnum HorizontalJustification { get; set; }
    bool InUse { get; }
    string InternalName { get; }
    bool Italic { get; set; }
    double LineSpacing { get; set; }
    TextLineSpacingTypeEnum LineSpacingType { get; set; }
    string Name { get; set; }
    object Parent { get; }
    double Rotation { get; set; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    ObjectTypeEnum Type { get; }
    bool Underline { get; set; }
    bool UpToDate { get; }
    VerticalTextAlignmentEnum VerticalJustification { get; set; }
    double WidthScale { get; set; }
    // Methods
    Style ConvertToLocal();
    Style Copy(string Name);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void SaveToGlobal();
    void UpdateFromGlobal();
}
```

12 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BalloonStyle](../objects/BalloonStyle.md).TextStyle, [CustomTable](../objects/CustomTable.md).ColumnHeaderTextStyle, [CustomTable](../objects/CustomTable.md).DataTextStyle, [CustomTable](../objects/CustomTable.md).TitleTextStyle, [DimensionStyle](../objects/DimensionStyle.md).TextStyle, [DimensionStyle](../objects/DimensionStyle.md).ToleranceTextStyle, [DrawingViewLabel](../objects/DrawingViewLabel.md).TextStyle, [EdgeSymbolStyle](../objects/EdgeSymbolStyle.md).TextStyle, [FeatureControlFrameStyle](../objects/FeatureControlFrameStyle.md).TextStyle, [GeneralNote](../objects/GeneralNote.md).TextStyle, [HoleTable](../objects/HoleTable.md).ColumnHeaderTextStyle, [HoleTable](../objects/HoleTable.md).DataTextStyle, [HoleTable](../objects/HoleTable.md).TitleTextStyle, [HoleTableStyle](../objects/HoleTableStyle.md).ColumnHeaderTextStyle, [HoleTableStyle](../objects/HoleTableStyle.md).DataTextStyle, [HoleTableStyle](../objects/HoleTableStyle.md).TitleTextStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).BorderTextStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).GeneralNoteStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).SketchTextStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).SketchedSymbolTextStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).TitleBlockTextStyle, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).ViewLabelStyle, [PartsList](../objects/PartsList.md).ColumnHeaderTextStyle, [PartsList](../objects/PartsList.md).DataTextStyle, [PartsList](../objects/PartsList.md).TitleTextStyle, [PartsListStyle](../objects/PartsListStyle.md).ColumnHeaderTextStyle, [PartsListStyle](../objects/PartsListStyle.md).DataTextStyle, [PartsListStyle](../objects/PartsListStyle.md).TitleTextStyle, [RevisionTable](../objects/RevisionTable.md).ColumnHeaderTextStyle, [RevisionTable](../objects/RevisionTable.md).DataTextStyle, [RevisionTable](../objects/RevisionTable.md).TitleTextStyle, [RevisionTableStyle](../objects/RevisionTableStyle.md).ColumnHeaderTextStyle, [RevisionTableStyle](../objects/RevisionTableStyle.md).DataTextStyle, [RevisionTableStyle](../objects/RevisionTableStyle.md).RevisionTagTextStyle, [RevisionTableStyle](../objects/RevisionTableStyle.md).TitleTextStyle, [SurfaceTextureStyle](../objects/SurfaceTextureStyle.md).TextStyle, [TableFormat](../objects/TableFormat.md).TextStyle, [TableStyle](../objects/TableStyle.md).ColumnHeaderTextStyle, [TableStyle](../objects/TableStyle.md).DataTextStyle, [TableStyle](../objects/TableStyle.md).TitleTextStyle and 5 more (see `members.tsv`)

**Referenced types:** [Color](../objects/Color.md), [HorizontalTextAlignmentEnum](../enums/HorizontalTextAlignmentEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [TextLineSpacingTypeEnum](../enums/TextLineSpacingTypeEnum.md), [VerticalTextAlignmentEnum](../enums/VerticalTextAlignmentEnum.md)

