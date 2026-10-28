# Application

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface Application
{
    // Properties
    AssetLibrary ActiveAppearanceLibrary { get; set; }
    ColorScheme ActiveColorScheme { get; }
    Document ActiveDocument { get; }
    DocumentTypeEnum ActiveDocumentType { get; }
    Document ActiveEditDocument { get; }
    object ActiveEditObject { get; }
    AssetLibrary ActiveMaterialLibrary { get; set; }
    View ActiveView { get; }
    ViewFrame ActiveViewFrame { get; }
    ApplicationAddIns ApplicationAddIns { get; }
    ApplicationEvents ApplicationEvents { get; }
    AssemblyEvents AssemblyEvents { get; }
    AssemblyOptions AssemblyOptions { get; }
    AssetLibraries AssetLibraries { get; }
    string[] AvailableComparisonVersions { get; }
    CameraEvents CameraEvents { get; }
    string Caption { get; set; }
    ChangeManager ChangeManager { get; }
    ClientOperationEvents ClientOperationEvents { get; } // since 2025
    ClientResourceMaps ClientResourceMaps { get; }
    ColorSchemes ColorSchemes { get; }
    CommandManager CommandManager { get; }
    string ComparisonVersion { get; set; }
    ContentCenter ContentCenter { get; }
    ContentCenterOptions ContentCenterOptions { get; }
    DarkSiteLevelEnum DarkSiteLevel { get; } // since 2027
    DesignProjectManager DesignProjectManager { get; }
    DisplayOptions DisplayOptions { get; }
    Documents Documents { get; }
    DrawingOptions DrawingOptions { get; }
    ErrorManager ErrorManager { get; }
    AssetsEnumerator FavoriteAssets { get; }
    FileAccessEvents FileAccessEvents { get; }
    FileManager FileManager { get; }
    FileOptions FileOptions { get; }
    FileUIEvents FileUIEvents { get; }
    GeneralOptions GeneralOptions { get; }
    HardwareOptions HardwareOptions { get; }
    int Height { get; set; }
    HelpManager HelpManager { get; }
    string InstallPath { get; }
    bool IsIn3dPrintMode { get; }
    string LanguageCode { get; }
    string LanguageName { get; }
    LanguageTools LanguageTools { get; }
    int Left { get; set; }
    int Locale { get; }
    bool LoggedIn { get; }
    string LoginUserId { get; }
    string LoginUserName { get; }
    bool MRUDisplay { get; set; }
    bool MRUEnabled { get; set; }
    int MainFrameHWND { get; }
    MaterialDisplayUnitsEnum MaterialDisplayUnits { get; set; }
    MeasureTools MeasureTools { get; }
    ModelStateEvents ModelStateEvents { get; }
    ModelingEvents ModelingEvents { get; }
    NotebookOptions NotebookOptions { get; }
    bool OpenDocumentsDisplay { get; set; }
    PartOptions PartOptions { get; }
    PresentationOptions PresentationOptions { get; }
    PromptsOptions PromptsOptions { get; } // since 2025
    bool Ready { get; }
    RepresentationEvents RepresentationEvents { get; }
    SaveOptions SaveOptions { get; }
    bool ScreenUpdating { get; set; }
    bool SilentOperation { get; set; }
    SketchEvents SketchEvents { get; }
    SketchOptions SketchOptions { get; }
    SoftwareVersion SoftwareVersion { get; }
    string StatusBarText { get; set; }
    StyleEvents StyleEvents { get; }
    StylesManager StylesManager { get; }
    bool SupportsFileManagement { get; set; }
    ThemeManager ThemeManager { get; }
    int Top { get; set; }
    TransactionManager TransactionManager { get; }
    TransientBRep TransientBRep { get; }
    TransientGeometry TransientGeometry { get; }
    TransientObjects TransientObjects { get; }
    ObjectTypeEnum Type { get; }
    UnitsOfMeasure UnitsOfMeasure { get; }
    UserInterfaceManager UserInterfaceManager { get; }
    string UserName { get; set; }
    InventorVBAProjects VBAProjects { get; }
    object VBE { get; }
    ViewFramesEnumerator ViewFrames { get; }
    ViewsEnumerator Views { get; }
    bool Visible { get; set; }
    WebBrowserDialogs WebBrowserDialogs { get; }
    int Width { get; set; }
    WindowsSizeEnum WindowState { get; set; }
    iFeatureOptions iFeatureOptions { get; }
    // Methods
    void ConstructInternalNameAndRevisionId(string InternalNameToken, string RevisionIdToken, out string InternalName, out string RevisionId);
    FactoryTableDialog CreateFactoryTableDialog(string FullFileName);
    void CreateFileDialog(out FileDialog Dialog);
    ProgressBar CreateProgressBar(bool DisplayInStatusBar, int NumberOfSteps, string Title, bool AllowCancel = false, int HWND = 0);
    void ExportApplicationOptions(string FullFileName);
    void GetAppFrameExtents(out int Top, out int Left, out int Height, out int Width);
    object GetInterfaceObject(string ProgIDorCLSID);
    object GetInterfaceObject32(string ProgIDorCLSID);
    void GetMDIClientAreaExtents(out int Top, out int Left, out int Height, out int Width);
    string GetMaterialXFromAsset(Asset Asset, object converterOptions = Missing);
    void ImportApplicationOptions(string FullFileName);
    void Move(ref int Top, ref int Left, ref int Height, ref int Width);
    void Quit();
    void RefreshRibbonForComparison();
    void ReserveLicense(string ClientId);
    void UnreserveLicense(string ClientId);
    void UseAutoCADRelatedSettings();
    void UseInventorSettings();
}
```

64 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ApplicationAddInSite](../objects/ApplicationAddInSite.md).Application, [AuxiliaryFeatureIndicator](../objects/AuxiliaryFeatureIndicator.md).Application, [AuxiliaryFeatureIndicators](../objects/AuxiliaryFeatureIndicators.md).Application, [BalloonTip](../objects/BalloonTip.md).Application, [BalloonTips](../objects/BalloonTips.md).Application, [BrowserFoldersEnumerator](../objects/BrowserFoldersEnumerator.md).Application, [BrowserNodesEnumerator](../objects/BrowserNodesEnumerator.md).Application, [ButtonDefinition](../objects/ButtonDefinition.md).Application, [ClientResourceMap](../objects/ClientResourceMap.md).Parent, [ComboBoxDefinition](../objects/ComboBoxDefinition.md).Application, [CommandCategories](../objects/CommandCategories.md).Application, [CommandCategory](../objects/CommandCategory.md).Application, [CommandControl](../objects/CommandControl.md).Application, [CommandControls](../objects/CommandControls.md).Application, [CommandControlsEnumerator](../objects/CommandControlsEnumerator.md).Application, [CommandManager](../objects/CommandManager.md).Parent, [ControlDefinition](../objects/ControlDefinition.md).Application, [ControlDefinitionEvents](../objects/ControlDefinitionEvents.md).Application, [ControlDefinitions](../objects/ControlDefinitions.md).Application, [DisabledCommandList](../objects/DisabledCommandList.md).Application, [Environment](../objects/Environment.md).Application, [Environment](../objects/Environment.md).Parent, [EnvironmentList](../objects/EnvironmentList.md).Application, [EnvironmentManager](../objects/EnvironmentManager.md).Application, [Environments](../objects/Environments.md).Application, [FileUIEvents](../objects/FileUIEvents.md).Application, [FileUIEvents](../objects/FileUIEvents.md).Parent, [InteractionEvents](../objects/InteractionEvents.md).Application, [InventorVBAProject](../objects/InventorVBAProject.md).Parent, [InventorVBAProjects](../objects/InventorVBAProjects.md).Parent, [KeyboardEvents](../objects/KeyboardEvents.md).Application, [LicenseManager](../objects/LicenseManager.md).Application, [LicenseManager](../objects/LicenseManager.md).Parent, [MacroControlDefinition](../objects/MacroControlDefinition.md).Application, [ManipulatorEvents](../objects/ManipulatorEvents.md).Application, [MeasureEvents](../objects/MeasureEvents.md).Application, [MiniToolbar](../objects/MiniToolbar.md).Application, [MiniToolbarButton](../objects/MiniToolbarButton.md).Application, [MiniToolbarCheckBox](../objects/MiniToolbarCheckBox.md).Application, [MiniToolbarComboBox](../objects/MiniToolbarComboBox.md).Application and 34 more (see `members.tsv`)

**Referenced types:** [ApplicationAddIns](../objects/ApplicationAddIns.md), [ApplicationEvents](../objects/ApplicationEvents.md), [AssemblyEvents](../objects/AssemblyEvents.md), [AssemblyOptions](../objects/AssemblyOptions.md), [Asset](../objects/Asset.md), [AssetLibraries](../objects/AssetLibraries.md), [AssetLibrary](../objects/AssetLibrary.md), [AssetsEnumerator](../objects/AssetsEnumerator.md), [CameraEvents](../objects/CameraEvents.md), [ChangeManager](../objects/ChangeManager.md), [ClientOperationEvents](../objects/ClientOperationEvents.md), [ClientResourceMaps](../objects/ClientResourceMaps.md), [ColorScheme](../objects/ColorScheme.md), [ColorSchemes](../objects/ColorSchemes.md), [CommandManager](../objects/CommandManager.md), [ContentCenter](../objects/ContentCenter.md), [ContentCenterOptions](../objects/ContentCenterOptions.md), [DarkSiteLevelEnum](../enums/DarkSiteLevelEnum.md), [DesignProjectManager](../objects/DesignProjectManager.md), [DisplayOptions](../objects/DisplayOptions.md), [Document](../objects/Document.md), [DocumentTypeEnum](../enums/DocumentTypeEnum.md), [Documents](../objects/Documents.md), [DrawingOptions](../objects/DrawingOptions.md), [ErrorManager](../objects/ErrorManager.md), [FactoryTableDialog](../objects/FactoryTableDialog.md), [FileAccessEvents](../objects/FileAccessEvents.md), [FileDialog](../objects/FileDialog.md), [FileManager](../objects/FileManager.md), [FileOptions](../objects/FileOptions.md), [FileUIEvents](../objects/FileUIEvents.md), [GeneralOptions](../objects/GeneralOptions.md), [HardwareOptions](../objects/HardwareOptions.md), [HelpManager](../objects/HelpManager.md), [InventorVBAProjects](../objects/InventorVBAProjects.md), [LanguageTools](../objects/LanguageTools.md), [MaterialDisplayUnitsEnum](../enums/MaterialDisplayUnitsEnum.md), [MeasureTools](../objects/MeasureTools.md), [ModelStateEvents](../objects/ModelStateEvents.md), [ModelingEvents](../objects/ModelingEvents.md), [NotebookOptions](../objects/NotebookOptions.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartOptions](../objects/PartOptions.md), [PresentationOptions](../objects/PresentationOptions.md), [ProgressBar](../objects/ProgressBar.md), [PromptsOptions](../objects/PromptsOptions.md), [RepresentationEvents](../objects/RepresentationEvents.md), [SaveOptions](../objects/SaveOptions.md), [SketchEvents](../objects/SketchEvents.md), [SketchOptions](../objects/SketchOptions.md), [SoftwareVersion](../objects/SoftwareVersion.md), [StyleEvents](../objects/StyleEvents.md), [StylesManager](../objects/StylesManager.md), [ThemeManager](../objects/ThemeManager.md), [TransactionManager](../objects/TransactionManager.md), [TransientBRep](../objects/TransientBRep.md), [TransientGeometry](../objects/TransientGeometry.md), [TransientObjects](../objects/TransientObjects.md), [UnitsOfMeasure](../objects/UnitsOfMeasure.md), [UserInterfaceManager](../objects/UserInterfaceManager.md), [View](../objects/View.md), [ViewFrame](../objects/ViewFrame.md), [ViewFramesEnumerator](../objects/ViewFramesEnumerator.md), [ViewsEnumerator](../objects/ViewsEnumerator.md), [WebBrowserDialogs](../objects/WebBrowserDialogs.md), [WindowsSizeEnum](../enums/WindowsSizeEnum.md), [iFeatureOptions](../objects/iFeatureOptions.md)

