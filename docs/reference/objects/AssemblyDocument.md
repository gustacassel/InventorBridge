# AssemblyDocument

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [Document](../objects/Document.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

**How to get it:** `Application.ActiveDocument → (AssemblyDocument)`

```csharp
interface AssemblyDocument
{
    // Properties
    object ActivatedObject { get; }
    LightingStyle ActiveLightingStyle { get; set; }
    DocumentsEnumerator AllReferencedDocuments { get; }
    AssetsEnumerator AppearanceAssets { get; }
    Assets Assets { get; }
    string AssociativeForeignFilename { get; }
    AttributeManager AttributeManager { get; }
    AttributeSets AttributeSets { get; }
    BrowserPanes BrowserPanes { get; }
    ClientViews ClientViews { get; }
    bool Compacted { get; }
    AssemblyComponentDefinition ComponentDefinition { get; }
    string DatabaseRevisionId { get; }
    string DefaultCommand { get; }
    string DesignViewInfo { get; }
    bool Dirty { get; set; }
    DisabledCommandList DisabledCommandList { get; }
    CommandTypesEnum DisabledCommandTypes { get; set; }
    string DisplayNameBasis { get; set; } // since 2026
    bool DisplayNameOverridden { get; set; }
    DisplaySettings DisplaySettings { get; }
    DocumentEvents DocumentEvents { get; }
    DocumentInterests DocumentInterests { get; }
    DocumentSubType DocumentSubType { get; }
    DocumentTypeEnum DocumentType { get; }
    Document EmbeddingDocument { get; }
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
    bool IsEmbeddedDocument { get; }
    bool IsModifiable { get; }
    bool IsOpenExpress { get; set; }
    LightingStyles LightingStyles { get; }
    AssetsEnumerator MaterialAssets { get; }
    string ModelStateName { get; }
    ModelingSettings ModelingSettings { get; }
    bool NeedsMigrating { get; }
    ClientGraphicsCollection NonTransactingClientGraphicsCollection { get; }
    GraphicsDataSetsCollection NonTransactingGraphicsDataSetsCollection { get; }
    ObjectVisibility ObjectVisibility { get; }
    bool Open { get; }
    object Parent { get; }
    AssetsEnumerator PhysicalAssets { get; }
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
    SketchSettings SketchSettings { get; }
    SoftwareVersion SoftwareVersionCreated { get; }
    SoftwareVersion SoftwareVersionSaved { get; }
    string SubType { get; set; }
    TextStylesEnumerator TextStyles { get; }
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
    void GetSelectedObject(GenericObject Selection, out ObjectTypeEnum ObjectType, out NameValueMap AdditionalData, out ComponentOccurrence ContainingOccurrence, out object SelectedObject = Missing);
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

38 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md).Parent, [AssemblyComponentDefinitions](../objects/AssemblyComponentDefinitions.md).Parent, [WeldmentComponentDefinition](../objects/WeldmentComponentDefinition.md).Parent

**Referenced types:** [AssemblyComponentDefinition](../objects/AssemblyComponentDefinition.md), [Assets](../objects/Assets.md), [AssetsEnumerator](../objects/AssetsEnumerator.md), [AttributeManager](../objects/AttributeManager.md), [AttributeSets](../objects/AttributeSets.md), [BrowserPanes](../objects/BrowserPanes.md), [ClientGraphicsCollection](../objects/ClientGraphicsCollection.md), [ClientViews](../objects/ClientViews.md), [CommandTypesEnum](../enums/CommandTypesEnum.md), [ComponentOccurrence](../objects/ComponentOccurrence.md), [DisabledCommandList](../objects/DisabledCommandList.md), [DisplaySettings](../objects/DisplaySettings.md), [Document](../objects/Document.md), [DocumentDescriptorsEnumerator](../objects/DocumentDescriptorsEnumerator.md), [DocumentEvents](../objects/DocumentEvents.md), [DocumentInterests](../objects/DocumentInterests.md), [DocumentTypeEnum](../enums/DocumentTypeEnum.md), [DocumentsEnumerator](../objects/DocumentsEnumerator.md), [EnvironmentManager](../objects/EnvironmentManager.md), [File](../objects/File.md), [GenericObject](../objects/GenericObject.md), [GraphicsDataSetsCollection](../objects/GraphicsDataSetsCollection.md), [HighlightSet](../objects/HighlightSet.md), [IPictureDisp](../objects/IPictureDisp.md), [InventorVBAProject](../objects/InventorVBAProject.md), [LightingStyle](../objects/LightingStyle.md), [LightingStyles](../objects/LightingStyles.md), [LocationTypeEnum](../enums/LocationTypeEnum.md), [ModelingSettings](../objects/ModelingSettings.md), [NameValueMap](../objects/NameValueMap.md), [OLEDocumentTypeEnum](../enums/OLEDocumentTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectVisibility](../objects/ObjectVisibility.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [PrintManager](../objects/PrintManager.md), [PropertySets](../objects/PropertySets.md), [ReferenceKeyManager](../objects/ReferenceKeyManager.md), [ReferencedOLEFileDescriptors](../objects/ReferencedOLEFileDescriptors.md), [ReferencedOpaqueFileDescriptors](../objects/ReferencedOpaqueFileDescriptors.md), [SelectSet](../objects/SelectSet.md), [SelectionPreferences](../objects/SelectionPreferences.md), [SelectionPriorityEnum](../enums/SelectionPriorityEnum.md), [SketchSettings](../objects/SketchSettings.md), [SoftwareVersion](../objects/SoftwareVersion.md), [TextStylesEnumerator](../objects/TextStylesEnumerator.md), [ThumbnailSaveOptionEnum](../enums/ThumbnailSaveOptionEnum.md), [UnitsOfMeasure](../objects/UnitsOfMeasure.md), [Views](../objects/Views.md)

