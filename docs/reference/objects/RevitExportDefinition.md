# RevitExportDefinition

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (AssemblyDocument).ComponentDefinition.RevitExports.Item[…].Definition`

```csharp
interface RevitExportDefinition
{
    // Properties
    string ActiveDesignViewRepresentation { get; set; }
    string ActiveModelState { get; set; }
    string ActivePositionalRepresentation { get; set; }
    ObjectCollection AdditionalExcludedOccurrences { get; set; }
    ObjectCollection AdditionalIncludedOccurrences { get; set; }
    object Application { get; }
    bool EnableUpdating { get; set; }
    EnvelopesReplaceStyleEnum EnvelopesReplaceStyle { get; set; }
    string FileName { get; set; }
    bool IsAssociativeDesignView { get; set; }
    string Location { get; set; }
    RevitExport Parent { get; }
    ObjectCollection PreservedFeatures { get; set; }
    bool RemoveAllInternalVoids { get; set; }
    double RemoveChamfersDistanceRange { get; set; }
    SimplificationRemoveStyleEnum RemoveChamfersStyle { get; set; }
    double RemoveEmbossMaxHeightRange { get; set; }
    double RemoveFilletsRadiusRange { get; set; }
    SimplificationRemoveStyleEnum RemoveFilletsStyle { get; set; }
    double RemoveHolesDiameterRange { get; set; }
    SimplificationRemoveStyleEnum RemoveHolesStyle { get; set; }
    bool RemoveInternalParts { get; set; }
    bool RemovePartsBySize { get; set; }
    double RemovePartsSize { get; set; }
    double RemovePocketsMaxDepthRange { get; set; }
    SimplificationRemoveStyleEnum RemovePocketsStyle { get; set; }
    SimplificationRemoveStyleEnum RemoveTunnelsStyle { get; set; }
    string RevitTemplate { get; set; } // since 2026
    string RevitVersion { get; set; } // since 2025
    RevitExportStructureTypeEnum Structure { get; set; }
    ObjectTypeEnum Type { get; }
    bool UseColorOverrideFromSourceComponent { get; set; }
    // Methods
    RevitExportDefinition Copy();
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [RevitExport](../objects/RevitExport.md).Definition, [RevitExportDefinition](../objects/RevitExportDefinition.md).Copy, [RevitExports](../objects/RevitExports.md).CreateDefinition

**Referenced types:** [EnvelopesReplaceStyleEnum](../enums/EnvelopesReplaceStyleEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RevitExport](../objects/RevitExport.md), [RevitExportStructureTypeEnum](../enums/RevitExportStructureTypeEnum.md), [SimplificationRemoveStyleEnum](../enums/SimplificationRemoveStyleEnum.md)

