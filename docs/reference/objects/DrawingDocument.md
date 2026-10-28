# DrawingDocument

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Document](../objects/Document.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (DrawingDocument)`

```csharp
interface DrawingDocument
{
    // Properties
    object ActivatedObject { get; }
    Sheet ActiveSheet { get; }
    DocumentsEnumerator AllReferencedDocuments { get; }
    AttributeManager AttributeManager { get; }
    AttributeSets AttributeSets { get; }
    AutoCADBlockDefinitions AutoCADBlockDefinitions { get; }
    BorderDefinitions BorderDefinitions { get; }
    BrowserPanes BrowserPanes { get; }
    ClientViews ClientViews { get; }
    bool Compacted { get; }
    object ContainingDWGDocument { get; }
    string DatabaseRevisionId { get; }
    string DefaultCommand { get; }
    bool Dirty { get; set; }
    DisabledCommandList DisabledCommandList { get; }
    CommandTypesEnum DisabledCommandTypes { get; set; }
    string DisplayNameBasis { get; set; } // since 2026
    bool DisplayNameOverridden { get; set; }
    DocumentEvents DocumentEvents { get; }
    DocumentInterests DocumentInterests { get; }
    DocumentSubType DocumentSubType { get; }
    DocumentTypeEnum DocumentType { get; }
    DrawingBOMs DrawingBOMs { get; }
    DrawingEvents DrawingEvents { get; }
    DrawingHatchPatternsManager DrawingHatchPatternsManager { get; }
    DrawingSettings DrawingSettings { get; }
    EnvironmentManager EnvironmentManager { get; }
    File File { get; }
    PropertySets FilePropertySets { get; }
    int FileSaveCounter { get; }
    string FullDisplayName { get; } // since 2026
    string FullDocumentName { get; }
    string FullFileName { get; set; }
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    bool HasReferencesMissing { get; } // since 2025
    string InternalName { get; }
    bool IsInventorDWG { get; }
    bool IsModifiable { get; }
    string ModelStateName { get; }
    bool NeedsMigrating { get; }
    ClientGraphicsCollection NonTransactingClientGraphicsCollection { get; }
    GraphicsDataSetsCollection NonTransactingGraphicsDataSetsCollection { get; }
    bool Open { get; }
    Parameters Parameters { get; }
    object Parent { get; }
    PrintManager PrintManager { get; }
    PropertySets PropertySets { get; }
    CommandTypesEnum RecentChanges { get; }
    ReferenceKeyManager ReferenceKeyManager { get; }
    DocumentDescriptorsEnumerator ReferencedDocumentDescriptors { get; }
    DocumentsEnumerator ReferencedDocuments { get; }
    ReferencedOLEFileDescriptors ReferencedOLEFileDescriptors { get; }
    ObjectsEnumerator ReferencedOLEFileDescriptors2[OLEDocumentTypeEnum ReferenceType = OLEDocumentTypeEnum.kOLEDocumentUnknownObject] { get; }
    ReferencedOpaqueFileDescriptors ReferencedOpaqueFileDescriptors { get; }
    DocumentsEnumerator ReferencingDocuments { get; }
    bool RequiresUpdate { get; }
    bool ReservedForWrite { get; }
    bool ReservedForWriteByMe { get; set; }
    string ReservedForWriteLogin { get; }
    string ReservedForWriteName { get; }
    DateTime ReservedForWriteTime { get; }
    int ReservedForWriteVersion { get; }
    SelectSet SelectSet { get; }
    SelectionPreferences SelectionPreferences { get; }
    SelectionPriorityEnum SelectionPriority { get; set; }
    SheetFormats SheetFormats { get; }
    SheetSettings SheetSettings { get; }
    Sheets Sheets { get; }
    SketchSettings SketchSettings { get; }
    SketchedSymbolDefinitions SketchedSymbolDefinitions { get; }
    SoftwareVersion SoftwareVersionCreated { get; }
    SoftwareVersion SoftwareVersionSaved { get; }
    DrawingStylesManager StylesManager { get; }
    string SubType { get; set; }
    IPictureDisp Thumbnail { get; }
    ThumbnailSaveOptionEnum ThumbnailSaveOption { get; }
    TitleBlockDefinitions TitleBlockDefinitions { get; }
    ObjectTypeEnum Type { get; }
    UnitsOfMeasure UnitsOfMeasure { get; }
    InventorVBAProject VBAProject { get; }
    Views Views { get; }
    // Methods
    void Activate();
    void Close(bool SkipSave = false);
    HighlightSet CreateHighlightSet();
    DocumentsEnumerator FindWhereUsed(string FullFileName);
    void GetLocationFoundIn(out string LocationName, out LocationTypeEnum LocationType);
    void GetMissingAddInBehavior(out string ClientId, out CommandTypesEnum DisabledCommandTypesEnum, out ObjectCollection DisabledCommands);
    object GetPrivateStorage(string StorageName, bool CreateIfNecessary);
    object GetPrivateStream(string StreamName, bool CreateIfNecessary);
    bool HasPrivateStorage(string StorageName);
    bool HasPrivateStream(string StreamName);
    void MakeAllViewsPrecise();
    void MakeAllViewsRaster();
    void ProcessViewSelection(GenericObject Selection, out DrawingView ContainingView, out object SelectedObject);
    void PutInternalNameAndRevisionId(string InternalNameToken, string RevisionIdToken, out string InternalName, out string RevisionId);
    void Rebuild();
    bool Rebuild2(bool AcceptErrorsAndContinue = true);
    void ReleaseReference();
    void ResolveFile(); // since 2025
    void RevertReservedForWriteByMe();
    void Save();
    void Save2(bool SaveDependents = true, object DocumentsToSave = Missing);
    void SaveAs(string FileName, bool SaveCopyAs);
    void SaveAs2(string FullFileName, bool SaveCopyAs, object Options = Missing);
    void SaveAsInventorDWG(string FullFileName, bool SaveCopyAs);
    void SetMissingAddInBehavior(string ClientId, CommandTypesEnum DisabledCommandTypesEnum, object DisabledCommands = Missing);
    void SetThumbnailSaveOption(ThumbnailSaveOptionEnum SaveOption, string ImageFullFileName = "");
    void Update();
    bool Update2(bool AcceptErrorsAndContinue = true);
}
```

27 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AutoCADBlockDefinition](../objects/AutoCADBlockDefinition.md).Parent, [BorderDefinition](../objects/BorderDefinition.md).Parent, [DrawingBOM](../objects/DrawingBOM.md).Parent, [DrawingEvents](../objects/DrawingEvents.md).Parent, [DrawingHatchPatternsManager](../objects/DrawingHatchPatternsManager.md).Parent, [DrawingSettings](../objects/DrawingSettings.md).Parent, [DrawingStylesManager](../objects/DrawingStylesManager.md).Parent, [SheetFormat](../objects/SheetFormat.md).Parent, [SheetSettings](../objects/SheetSettings.md).Parent, [SketchedSymbolDefinition](../objects/SketchedSymbolDefinition.md).Parent, [TitleBlockDefinition](../objects/TitleBlockDefinition.md).Parent

**Referenced types:** [AttributeManager](../objects/AttributeManager.md), [AttributeSets](../objects/AttributeSets.md), [AutoCADBlockDefinitions](../objects/AutoCADBlockDefinitions.md), [BorderDefinitions](../objects/BorderDefinitions.md), [BrowserPanes](../objects/BrowserPanes.md), [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md), [ClientViews](../objects/ClientViews.md), [CommandTypesEnum](../enums/CommandTypesEnum.md), [DisabledCommandList](../objects/DisabledCommandList.md), [DocumentDescriptorsEnumerator](../objects/DocumentDescriptorsEnumerator.md), [DocumentEvents](../objects/DocumentEvents.md), [DocumentInterests](../objects/DocumentInterests.md), [DocumentTypeEnum](../enums/DocumentTypeEnum.md), [DocumentsEnumerator](../objects/DocumentsEnumerator.md), [DrawingBOMs](../objects/DrawingBOMs.md), [DrawingEvents](../objects/DrawingEvents.md), [DrawingHatchPatternsManager](../objects/DrawingHatchPatternsManager.md), [DrawingSettings](../objects/DrawingSettings.md), [DrawingStylesManager](../objects/DrawingStylesManager.md), [DrawingView](../objects/DrawingView.md), [EnvironmentManager](../objects/EnvironmentManager.md), [File](../objects/File.md), [GenericObject](../objects/GenericObject.md), [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md), [HighlightSet](../objects/HighlightSet.md), [IPictureDisp](../objects/IPictureDisp.md), [InventorVBAProject](../objects/InventorVBAProject.md), [LocationTypeEnum](../enums/LocationTypeEnum.md), [OLEDocumentTypeEnum](../enums/OLEDocumentTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [Parameters](../objects/Parameters.md), [PrintManager](../objects/PrintManager.md), [PropertySets](../objects/PropertySets.md), [ReferenceKeyManager](../objects/ReferenceKeyManager.md), [ReferencedOLEFileDescriptors](../objects/ReferencedOLEFileDescriptors.md), [ReferencedOpaqueFileDescriptors](../objects/ReferencedOpaqueFileDescriptors.md), [SelectSet](../objects/SelectSet.md), [SelectionPreferences](../objects/SelectionPreferences.md), [SelectionPriorityEnum](../enums/SelectionPriorityEnum.md), [Sheet](../objects/Sheet.md), [SheetFormats](../objects/SheetFormats.md), [SheetSettings](../objects/SheetSettings.md), [Sheets](../objects/Sheets.md), [SketchSettings](../objects/SketchSettings.md), [SketchedSymbolDefinitions](../objects/SketchedSymbolDefinitions.md), [SoftwareVersion](../objects/SoftwareVersion.md), [ThumbnailSaveOptionEnum](../enums/ThumbnailSaveOptionEnum.md), [TitleBlockDefinitions](../objects/TitleBlockDefinitions.md), [UnitsOfMeasure](../objects/UnitsOfMeasure.md), [Views](../objects/Views.md)

