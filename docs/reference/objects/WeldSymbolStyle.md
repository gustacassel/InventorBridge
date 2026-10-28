# WeldSymbolStyle

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [EdgeSymbolStyle](../objects/EdgeSymbolStyle.md) → [Style](../objects/Style.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.WeldSymbolStyles.Item[…]`

```csharp
interface WeldSymbolStyle
{
    // Properties
    object Application { get; }
    bool ArrowSidePositionAbove { get; set; }
    string Comments { get; set; }
    FieldFlagDirectionTypeEnum FieldFlagDirection { get; set; }
    double IdentificationLineOffset { get; set; }
    IdentificationLinePlacementEnum IdentificationLinePlacement { get; set; }
    LineTypeEnum IdentificationLineType { get; set; }
    bool InUse { get; }
    string InternalName { get; }
    bool JustifyTextToLeader { get; set; }
    LeaderStyle LeaderStyle { get; set; }
    string Name { get; set; }
    object Parent { get; }
    StyleLocationEnum StyleLocation { get; }
    StyleTypeEnum StyleType { get; }
    bool SymbolSizeLinkToTextHeight { get; set; }
    double SymbolSizeScaleFactor { get; set; }
    TextStyle TextStyle { get; set; }
    ObjectTypeEnum Type { get; }
    bool UpToDate { get; }
    // Methods
    Style ConvertToLocal();
    Style Copy(string Name);
    void Delete();
    void GetBackingSymbolsFilter(out BackingSymbolTypeEnum[] BackingSymbolFilter);
    ContourSymbolVariationTypeEnum GetContourSymbolFilterVariationType(ContourSymbolTypeEnum ContourSymbolFilter);
    void GetContourSymbolsFilter(out ContourSymbolTypeEnum[] ContourSymbolFilter);
    LineTypeEnum GetIdentificationLineCustomLineType(out string LineTypeName, out string LineTypeDescription);
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
    WeldSymbolVariationTypeEnum GetWeldingSymbolFilterVariationType(WeldSymbolTypeEnum WeldingSymbolFilter);
    void GetWeldingSymbolsFilter(out WeldSymbolTypeEnum[] WeldingSymbolFilter);
    void SaveToGlobal();
    void SetBackingSymbolsFilter(ref BackingSymbolTypeEnum[] BackingSymbolFilter);
    void SetContourSymbolFilterVariationType(ContourSymbolTypeEnum ContourSymbolFilter, ContourSymbolVariationTypeEnum ContourSymbolVariation);
    void SetContourSymbolsFilter(ref ContourSymbolTypeEnum[] ContourSymbolFilter);
    void SetIdentificationLineCustomLineType(string FullFileName, string LineTypeName, bool ReplaceExisting);
    void SetWeldingSymbolFilterVariationType(WeldSymbolTypeEnum WeldingSymbolFilter, WeldSymbolVariationTypeEnum WeldingSymbolVariation);
    void SetWeldingSymbolsFilter(ref WeldSymbolTypeEnum[] WeldingSymbolFilter);
    void UpdateFromGlobal();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingWeldingSymbol](../objects/DrawingWeldingSymbol.md).Style, [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md).WeldSymbolStyle, [WeldSymbolStylesEnumerator](../objects/WeldSymbolStylesEnumerator.md).Item

**Referenced types:** [BackingSymbolTypeEnum](../enums/BackingSymbolTypeEnum.md), [ContourSymbolTypeEnum](../enums/ContourSymbolTypeEnum.md), [ContourSymbolVariationTypeEnum](../enums/ContourSymbolVariationTypeEnum.md), [FieldFlagDirectionTypeEnum](../enums/FieldFlagDirectionTypeEnum.md), [IdentificationLinePlacementEnum](../enums/IdentificationLinePlacementEnum.md), [LeaderStyle](../objects/LeaderStyle.md), [LineTypeEnum](../enums/LineTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Style](../objects/Style.md), [StyleLocationEnum](../enums/StyleLocationEnum.md), [StyleTypeEnum](../enums/StyleTypeEnum.md), [TextStyle](../objects/TextStyle.md), [WeldSymbolTypeEnum](../enums/WeldSymbolTypeEnum.md), [WeldSymbolVariationTypeEnum](../enums/WeldSymbolVariationTypeEnum.md)

