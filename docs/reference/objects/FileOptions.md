# FileOptions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.FileOptions`

```csharp
interface FileOptions
{
    // Properties
    object Application { get; }
    string ContentCenterPath { get; set; }
    DraftingStandardEnum DefaultTemplateDrawingStandard { get; set; }
    bool DefaultTemplateUnitsAreInches { get; set; }
    string DefaultVBAProjectFileFullFilename { get; set; }
    string DesignDataPath { get; set; }
    string EnvironmentPath { get; set; }
    FileNamingDefaultsOptions FileNamingDefaultsOptions { get; } // since 2026
    FileOpenOptions FileOpenOptions { get; }
    string PresetsPath { get; set; }
    string ProjectsPath { get; set; }
    string SymbolLibraryPath { get; set; }
    string TeamWebFullFilename { get; set; }
    string TemplatesPath { get; set; }
    string TexturePath { get; set; }
    ObjectTypeEnum Type { get; }
    string UndoPath { get; set; }
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).FileOptions, [ApprenticeServer](../objects/ApprenticeServer.md).FileOptions, [ApprenticeServerComponent](../objects/ApprenticeServerComponent.md).FileOptions, [InventorServer](../objects/InventorServer.md).FileOptions

**Referenced types:** [DraftingStandardEnum](../enums/DraftingStandardEnum.md), [FileNamingDefaultsOptions](../objects/FileNamingDefaultsOptions.md), [FileOpenOptions](../objects/FileOpenOptions.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

