# Document

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument`

```csharp
interface Document
{
    // Properties
    object ActivatedObject { get; }
    DocumentsEnumerator AllReferencedDocuments { get; }
    AttributeManager AttributeManager { get; }
    AttributeSets AttributeSets { get; }
    BrowserPanes BrowserPanes { get; }
    ClientViews ClientViews { get; }
    bool Compacted { get; }
    string DatabaseRevisionId { get; }
    string DefaultCommand { get; }
    bool Dirty { get; set; }
    CommandTypesEnum DisabledCommandTypes { get; set; }
    string DisplayNameBasis { get; set; } // since 2026
    bool DisplayNameOverridden { get; set; }
    DocumentEvents DocumentEvents { get; }
    DocumentInterests DocumentInterests { get; }
    DocumentSubType DocumentSubType { get; }
    DocumentTypeEnum DocumentType { get; }
    File File { get; }
    PropertySets FilePropertySets { get; }
    int FileSaveCounter { get; }
    string FullDisplayName { get; } // since 2026
    string FullDocumentName { get; }
    string FullFileName { get; set; }
    GraphicsDataSetsCollection GraphicsDataSetsCollection { get; }
    bool HasReferencesMissing { get; } // since 2025
    string InternalName { get; }
    bool IsModifiable { get; }
    string ModelStateName { get; }
    bool NeedsMigrating { get; }
    ClientGraphicsCollection NonTransactingClientGraphicsCollection { get; }
    GraphicsDataSetsCollection NonTransactingGraphicsDataSetsCollection { get; }
    bool Open { get; }
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
    SoftwareVersion SoftwareVersionCreated { get; }
    SoftwareVersion SoftwareVersionSaved { get; }
    string SubType { get; set; }
    IPictureDisp Thumbnail { get; }
    ThumbnailSaveOptionEnum ThumbnailSaveOption { get; }
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
    void SetMissingAddInBehavior(string ClientId, CommandTypesEnum DisabledCommandTypesEnum, object DisabledCommands = Missing);
    void SetThumbnailSaveOption(ThumbnailSaveOptionEnum SaveOption, string ImageFullFileName = "");
    void Update();
    bool Update2(bool AcceptErrorsAndContinue = true);
}
```

26 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).ActiveDocument, [Application](../objects/Application.md).ActiveEditDocument, [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).FactoryDocument, [AssemblyDocument](../objects/AssemblyDocument.md).EmbeddingDocument, [BrowserNodeDefinition](../objects/BrowserNodeDefinition.md).Parent, [BrowserPane](../objects/BrowserPane.md).Parent, [ClientBrowserNodeDefinition](../objects/ClientBrowserNodeDefinition.md).Parent, [ClientNodeResource](../objects/ClientNodeResource.md).Parent, [Documents](../objects/Documents.md).Add, [Documents](../objects/Documents.md).AddWithOptions, [Documents](../objects/Documents.md).Item, [Documents](../objects/Documents.md).ItemByName, [Documents](../objects/Documents.md).Open, [Documents](../objects/Documents.md).OpenWithOptions, [DocumentsEnumerator](../objects/DocumentsEnumerator.md).Item, [EnvironmentManager](../objects/EnvironmentManager.md).Parent, [FileMetadata](../objects/FileMetadata.md).Document, [FlatPatternSettings](../objects/FlatPatternSettings.md).Parent, [InteractionEvents](../objects/InteractionEvents.md).TargetDocument, [ModelState](../objects/ModelState.md).Document, [ModelState](../objects/ModelState.md).FactoryDocument, [ModelingSettings](../objects/ModelingSettings.md).Parent, [NativeBrowserNodeDefinition](../objects/NativeBrowserNodeDefinition.md).Parent, [ObjectVisibility](../objects/ObjectVisibility.md).Parent, [PartComponentDefinition](../objects/PartComponentDefinition.md).FactoryDocument, [PartDocument](../objects/PartDocument.md).EmbeddingDocument, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).FactoryDocument, [Sketch3DSettings](../objects/Sketch3DSettings.md).Parent, [SketchSettings](../objects/SketchSettings.md).Parent, [Transaction](../objects/Transaction.md).Document, [View](../objects/View.md).Document, [View](../objects/View.md).Parent, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).FactoryDocument

**Referenced types:** [AttributeManager](../objects/AttributeManager.md), [AttributeSets](../objects/AttributeSets.md), [BrowserPanes](../objects/BrowserPanes.md), [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md), [ClientViews](../objects/ClientViews.md), [CommandTypesEnum](../enums/CommandTypesEnum.md), [DocumentDescriptorsEnumerator](../objects/DocumentDescriptorsEnumerator.md), [DocumentEvents](../objects/DocumentEvents.md), [DocumentInterests](../objects/DocumentInterests.md), [DocumentTypeEnum](../enums/DocumentTypeEnum.md), [DocumentsEnumerator](../objects/DocumentsEnumerator.md), [File](../objects/File.md), [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md), [HighlightSet](../objects/HighlightSet.md), [IPictureDisp](../objects/IPictureDisp.md), [InventorVBAProject](../objects/InventorVBAProject.md), [LocationTypeEnum](../enums/LocationTypeEnum.md), [OLEDocumentTypeEnum](../enums/OLEDocumentTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [PrintManager](../objects/PrintManager.md), [PropertySets](../objects/PropertySets.md), [ReferenceKeyManager](../objects/ReferenceKeyManager.md), [ReferencedOLEFileDescriptors](../objects/ReferencedOLEFileDescriptors.md), [ReferencedOpaqueFileDescriptors](../objects/ReferencedOpaqueFileDescriptors.md), [SelectSet](../objects/SelectSet.md), [SelectionPreferences](../objects/SelectionPreferences.md), [SelectionPriorityEnum](../enums/SelectionPriorityEnum.md), [SoftwareVersion](../objects/SoftwareVersion.md), [ThumbnailSaveOptionEnum](../enums/ThumbnailSaveOptionEnum.md), [UnitsOfMeasure](../objects/UnitsOfMeasure.md), [Views](../objects/Views.md)

