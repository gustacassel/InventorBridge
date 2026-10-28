# BOM

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.BOM`

```csharp
interface BOM
{
    // Properties
    object Application { get; }
    BOMViews BOMViews { get; }
    bool HideSuppressedComponentsInBOM { get; set; }
    object Parent { get; }
    bool PartsOnlyViewEnabled { get; set; }
    int PartsOnlyViewMinimumDigits { get; set; }
    NumberingSchemeEnum PartsOnlyViewNumberingScheme { get; set; }
    bool RenumberItemsSequentially { get; set; }
    bool RequiresUpdate { get; }
    string RevisionId { get; }
    string StructuredViewDelimiter { get; set; }
    bool StructuredViewEnabled { get; set; }
    bool StructuredViewFirstLevelOnly { get; set; }
    int StructuredViewMinimumDigits { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void ExportBOMCustomization(string FileName);
    void GetPartNumberMergeSettings(out bool MergeEnabled, out string[] MergeExcludeList);
    void GetPartNumberMergeSettings2(out bool MergeEnabled, out string[] MergeExcludeList, out bool MergeInstanceRows);
    void ImportBOMCustomization(string FileName);
    void SetPartNumberMergeSettings(bool MergeEnabled, object MergeKeys = Missing);
    void SetPartNumberMergeSettings2(bool MergeEnabled, object MergeKeys = Missing, object MergeInstanceRows = Missing);
}
```

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).BOM, [BOMView](../objects/BOMView.md).Parent, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).BOM

**Referenced types:** [BOMViews](../objects/BOMViews.md), [NumberingSchemeEnum](../enums/NumberingSchemeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

