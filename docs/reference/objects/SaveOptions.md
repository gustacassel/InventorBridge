# SaveOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.SaveOptions`

```csharp
interface SaveOptions
{
    // Properties
    object Application { get; }
    bool DefaultToSaveForAPIChanges { get; set; }
    bool DefaultToSaveForFileResolutionChange { get; set; }
    bool DefaultToSaveForImplicitUpdate { get; set; }
    bool DefaultToSaveForManualUpdates { get; set; }
    bool DefaultToSaveForMassPropertyUpdate { get; set; }
    bool DefaultToSaveForMigration { get; set; }
    bool DefaultToSaveForModelStateUpdates { get; set; }
    bool DefaultToSaveForUserEdits { get; set; }
    bool PromptSaveForAPIChanges { get; set; }
    bool PromptSaveForFileResolutionChange { get; set; }
    bool PromptSaveForImplicitUpdate { get; set; }
    bool PromptSaveForManualUpdates { get; set; }
    bool PromptSaveForMassPropertyUpdate { get; set; }
    bool PromptSaveForMigration { get; set; }
    bool PromptSaveForModelStateUpdates { get; set; }
    bool PromptSaveForUserEdits { get; set; }
    bool SaveFilesInLibraryFolders { get; set; }
    double SaveReminderTimer { get; set; }
    bool ShowSaveReminder { get; set; }
    ReportLocationEnum TranslatorReportLocation { get; set; }
    ObjectTypeEnum Type { get; }
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).SaveOptions, [InventorServer](../objects/InventorServer.md).SaveOptions

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReportLocationEnum](../enums/ReportLocationEnum.md)

