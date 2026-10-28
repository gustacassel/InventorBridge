# GeneralOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.GeneralOptions`

```csharp
interface GeneralOptions
{
    // Properties
    double AnnotationScale { get; set; }
    object Application { get; }
    bool EnableLegacyProjectCreation { get; set; }
    bool EnableOptimizedSelection { get; set; }
    bool EnableSpellCheck { get; set; }
    GripSnapOptions GripSnapOptions { get; }
    double SecondLevelTooltipDelay { get; set; }
    double SelectOtherDelay { get; set; }
    bool ShowAutocompleteForCommandAlias { get; set; }
    bool ShowCommandAliasInputDialog { get; set; }
    bool ShowCommandPromptTooltips { get; set; }
    bool ShowDocumentTabTooltips { get; set; }
    bool ShowHomeBaseOnStartup { get; set; }
    bool ShowSecondLevelTooltips { get; set; }
    bool ShowTooltips { get; set; }
    SpellCheckOptions SpellCheckOptions { get; }
    StartupActionTypeEnum StartupActionType { get; set; }
    string StartupNewFileTemplateName { get; set; }
    string StartupProjectFileName { get; set; }
    string TextAppearance { get; set; }
    int TextSize { get; set; }
    ThreadTableQuery ThreadTableQuery { get; }
    int ToleranceValue { get; set; }
    double TooltipDelay { get; set; }
    ObjectTypeEnum Type { get; }
    int UndoFileSize { get; set; }
    UpdatePropertiesOnSaveForFileTypeEnum UpdatePropertiesOnSaveForFileType { get; set; }
    bool UseAutodeskOnlineHelp { get; set; }
    bool UseNegativeIntegralForInertialProperties { get; set; }
    string UserName { get; set; }
    bool iMateVisibility { get; set; }
}
```

9 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).GeneralOptions, [InventorServer](../objects/InventorServer.md).GeneralOptions

**Referenced types:** [GripSnapOptions](../objects/GripSnapOptions.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SpellCheckOptions](../objects/SpellCheckOptions.md), [StartupActionTypeEnum](../enums/StartupActionTypeEnum.md), [ThreadTableQuery](../objects/ThreadTableQuery.md), [UpdatePropertiesOnSaveForFileTypeEnum](../enums/UpdatePropertiesOnSaveForFileTypeEnum.md)

