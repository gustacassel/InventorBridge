# InventorServer

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface InventorServer
{
    // Properties
    AssetLibrary ActiveAppearanceLibrary { get; set; }
    ColorScheme ActiveColorScheme { get; }
    AssetLibrary ActiveMaterialLibrary { get; set; }
    ApplicationAddIns ApplicationAddIns { get; }
    ApplicationEvents ApplicationEvents { get; }
    AssemblyEvents AssemblyEvents { get; }
    AssemblyOptions AssemblyOptions { get; }
    AssetLibraries AssetLibraries { get; }
    ChangeManager ChangeManager { get; }
    ClientOperationEvents ClientOperationEvents { get; } // since 2025
    ClientResourceMaps ClientResourceMaps { get; } // since 2027
    ColorSchemes ColorSchemes { get; }
    ContentCenter ContentCenter { get; }
    ContentCenterOptions ContentCenterOptions { get; }
    DesignProjectManager DesignProjectManager { get; }
    DisplayOptions DisplayOptions { get; }
    Documents Documents { get; }
    DrawingOptions DrawingOptions { get; }
    ErrorManager ErrorManager { get; }
    AssetsEnumerator FavoriteAssets { get; }
    FileAccessEvents FileAccessEvents { get; }
    FileManager FileManager { get; }
    FileOptions FileOptions { get; }
    GeneralOptions GeneralOptions { get; }
    HardwareOptions HardwareOptions { get; }
    string InstallPath { get; }
    string LanguageName { get; }
    LanguageTools LanguageTools { get; }
    int Locale { get; }
    MaterialDisplayUnitsEnum MaterialDisplayUnits { get; set; }
    MeasureTools MeasureTools { get; }
    ModelStateEvents ModelStateEvents { get; }
    ModelingEvents ModelingEvents { get; }
    NotebookOptions NotebookOptions { get; }
    PartOptions PartOptions { get; }
    PresentationOptions PresentationOptions { get; }
    bool Ready { get; }
    RepresentationEvents RepresentationEvents { get; }
    SaveOptions SaveOptions { get; }
    SketchEvents SketchEvents { get; }
    SketchOptions SketchOptions { get; }
    SoftwareVersion SoftwareVersion { get; }
    StyleEvents StyleEvents { get; }
    StylesManager StylesManager { get; }
    bool SupportsFileManagement { get; set; }
    TransactionManager TransactionManager { get; }
    TransientBRep TransientBRep { get; }
    TransientGeometry TransientGeometry { get; }
    TransientObjects TransientObjects { get; }
    ObjectTypeEnum Type { get; }
    UnitsOfMeasure UnitsOfMeasure { get; }
    string UserName { get; set; }
    InventorVBAProjects VBAProjects { get; }
    object VBE { get; }
    iFeatureOptions iFeatureOptions { get; }
    // Methods
    void ConstructInternalNameAndRevisionId(string InternalNameToken, string RevisionIdToken, out string InternalName, out string RevisionId);
    object GetInterfaceObject(string ProgIDorCLSID);
    object GetInterfaceObject32(string ProgIDorCLSID);
    void ReserveLicense(string ClientId);
    void UnreserveLicense(string ClientId);
}
```

46 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ApplicationAddInSite](../objects/ApplicationAddInSite.md).InventorServer, [VbaApplication](../objects/VbaApplication.md).ThisServer

**Referenced types:** [ApplicationAddIns](../objects/ApplicationAddIns.md), [ApplicationEvents](../objects/ApplicationEvents.md), [AssemblyEvents](../objects/AssemblyEvents.md), [AssemblyOptions](../objects/AssemblyOptions.md), [AssetLibraries](../objects/AssetLibraries.md), [AssetLibrary](../objects/AssetLibrary.md), [AssetsEnumerator](../objects/AssetsEnumerator.md), [ChangeManager](../objects/ChangeManager.md), [ClientOperationEvents](../objects/ClientOperationEvents.md), [ClientResourceMaps](../objects/ClientResourceMaps.md), [ColorScheme](../objects/ColorScheme.md), [ColorSchemes](../objects/ColorSchemes.md), [ContentCenter](../objects/ContentCenter.md), [ContentCenterOptions](../objects/ContentCenterOptions.md), [DesignProjectManager](../objects/DesignProjectManager.md), [DisplayOptions](../objects/DisplayOptions.md), [Documents](../objects/Documents.md), [DrawingOptions](../objects/DrawingOptions.md), [ErrorManager](../objects/ErrorManager.md), [FileAccessEvents](../objects/FileAccessEvents.md), [FileManager](../objects/FileManager.md), [FileOptions](../objects/FileOptions.md), [GeneralOptions](../objects/GeneralOptions.md), [HardwareOptions](../objects/HardwareOptions.md), [InventorVBAProjects](../objects/InventorVBAProjects.md), [LanguageTools](../objects/LanguageTools.md), [MaterialDisplayUnitsEnum](../enums/MaterialDisplayUnitsEnum.md), [MeasureTools](../objects/MeasureTools.md), [ModelStateEvents](../objects/ModelStateEvents.md), [ModelingEvents](../objects/ModelingEvents.md), [NotebookOptions](../objects/NotebookOptions.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartOptions](../objects/PartOptions.md), [PresentationOptions](../objects/PresentationOptions.md), [RepresentationEvents](../objects/RepresentationEvents.md), [SaveOptions](../objects/SaveOptions.md), [SketchEvents](../objects/SketchEvents.md), [SketchOptions](../objects/SketchOptions.md), [SoftwareVersion](../objects/SoftwareVersion.md), [StyleEvents](../objects/StyleEvents.md), [StylesManager](../objects/StylesManager.md), [TransactionManager](../objects/TransactionManager.md), [TransientBRep](../objects/TransientBRep.md), [TransientGeometry](../objects/TransientGeometry.md), [TransientObjects](../objects/TransientObjects.md), [UnitsOfMeasure](../objects/UnitsOfMeasure.md), [iFeatureOptions](../objects/iFeatureOptions.md)

