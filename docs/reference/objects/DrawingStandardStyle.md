# DrawingStandardStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.StandardStyles.Item[…]`

```csharp
interface DrawingStandardStyle
{
    // Properties
    ObjectDefaultsStyle ActiveObjectDefaults { get; set; }
    object Application { get; }
    bool ApplyExcludeCharactersToBendTables { get; set; }
    bool ApplyExcludeCharactersToHoleTables { get; set; }
    bool ApplyExcludeCharactersToRevisionTables { get; set; }
    bool ApplyExcludeCharactersToViewNames { get; set; }
    string Comments { get; set; }
    DecimalMarkerTypeEnum DecimalMarkerType { get; set; }
    string ExcludeCharacters { get; set; }
    bool FirstAngleProjection { get; set; }
    FrontViewPlaneEnum FrontViewPlane { get; set; }
    double GlobalLineScale { get; set; }
    bool InUse { get; }
    string InternalName { get; }
    DraftingStandardEnum InternationalStandardReference { get; }
    UnitsTypeEnum LinearUnits { get; set; }
    string Name { get; set; }
    object Parent { get; }
    bool PartialCircularThreadEdge { get; set; }
    bool PartialSectionThreadEnd { get; set; }
    object PresetLineWeights { get; set; }
    object PresetScales { get; set; }
    object PresetSectionHatchAngles { get; set; }
    object PresetTextHeights { get; set; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    // Methods
    Style ConvertToLocal();
    Style Copy(string Name);
    void Delete();
    ObjectCollection GetAvailableStyles(StyleTypeEnum StyleType); // since 2026
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    void GetViewAnnotationDefaults(DrawingViewTypeEnum ViewType, out string FormattedText); // since 2026
    void GetViewLabelDefaults(DrawingViewTypeEnum ViewType, out string Prefix, out bool Visible, out string FormattedText, out bool ConstrainToBorder, out bool PlaceBelowView);
    void SaveToGlobal();
    void SetAvailableStyles(StyleTypeEnum StyleType, ObjectCollection Styles); // since 2026
    void SetViewAnnotationDefaults(DrawingViewTypeEnum ViewType, string FormattedText); // since 2026
    void SetViewLabelDefaults(DrawingViewTypeEnum ViewType, string Prefix, bool Visible, string FormattedText, bool ConstrainToBorder, bool PlaceBelowView);
    void UpdateFromGlobal();
}
```

11 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingStandardStylesEnumerator](../objects/DrawingStandardStylesEnumerator.md).Item, [DrawingStylesManager](../objects/DrawingStylesManager.md).ActiveStandardStyle

**Referenced types:** [DecimalMarkerTypeEnum](../enums/DecimalMarkerTypeEnum.md), [DraftingStandardEnum](../enums/DraftingStandardEnum.md), [DrawingViewTypeEnum](../enums/DrawingViewTypeEnum.md), [FrontViewPlaneEnum](../enums/FrontViewPlaneEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [UnitsTypeEnum](../enums/UnitsTypeEnum.md)

