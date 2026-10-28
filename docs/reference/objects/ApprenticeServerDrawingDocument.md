# ApprenticeServerDrawingDocument

Inventor API object · versions: 2024+ · [index](../index.md)

**Inherits from:** [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md). The interop flattens COM inheritance: the members of these types are already listed here, and the object can be cast to them (and back, when its actual type is this one).

```csharp
interface ApprenticeServerDrawingDocument
{
    // Properties
    DraftingStandard ActiveStandard { get; }
    ApprenticeServerDocuments AllReferencedDocuments { get; }
    AttributeManager AttributeManager { get; }
    AttributeSets AttributeSets { get; }
    ClientViews ClientViews { get; }
    bool Compacted { get; }
    ComponentDefinition ComponentDefinition { get; }
    object ContainingDWGDocument { get; }
    string DatabaseRevisionId { get; }
    bool Dirty { get; set; }
    string DisplayName { get; set; }
    DocumentInterests DocumentInterests { get; }
    DocumentTypeEnum DocumentType { get; }
    File File { get; }
    PropertySets FilePropertySets { get; }
    int FileSaveCounter { get; }
    string FullDocumentName { get; }
    string FullFileName { get; }
    HealthStatusEnum HealthStatus { get; }
    string InternalName { get; }
    bool IsInventorDWG { get; }
    bool IsModifiable { get; }
    bool IsSubstitutePart { get; }
    bool NeedsMigrating { get; }
    bool Open { get; }
    ApprenticePrintManager PrintManager { get; }
    PropertySets PropertySets { get; }
    ReferenceKeyManager ReferenceKeyManager { get; }
    DocumentDescriptorsEnumerator ReferencedDocumentDescriptors { get; }
    ApprenticeServerDocuments ReferencedDocuments { get; }
    ReferencedOLEFileDescriptors ReferencedOLEFileDescriptors { get; }
    ReferencedOpaqueFileDescriptors ReferencedOpaqueFileDescriptors { get; }
    ApprenticeServerDocuments ReferencingDocuments { get; }
    bool RequiresUpdate { get; }
    bool ReservedForWrite { get; }
    bool ReservedForWriteByMe { get; set; }
    string ReservedForWriteLogin { get; }
    string ReservedForWriteName { get; }
    DateTime ReservedForWriteTime { get; }
    int ReservedForWriteVersion { get; }
    Sheets Sheets { get; }
    SoftwareVersion SoftwareVersionCreated { get; }
    SoftwareVersion SoftwareVersionSaved { get; }
    IPictureDisp Thumbnail { get; }
    ObjectTypeEnum Type { get; }
    UnitsOfMeasure UnitsOfMeasure { get; }
    // Methods
    void Close();
    HighlightSet CreateHighlightSet();
    ApprenticeServerDocuments FindWhereUsed(string FullFileName);
    void GetLocationFoundIn(out string LocationName, out LocationTypeEnum Type);
    void RevertReservedForWriteByMe();
}
```

12 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Referenced types:** [ApprenticePrintManager](../objects/ApprenticePrintManager.md), [ApprenticeServerDocuments](../objects/ApprenticeServerDocuments.md), [AttributeManager](../objects/AttributeManager.md), [AttributeSets](../objects/AttributeSets.md), [ClientViews](../objects/ClientViews.md), [ComponentDefinition](../objects/ComponentDefinition.md), [DocumentDescriptorsEnumerator](../objects/DocumentDescriptorsEnumerator.md), [DocumentInterests](../objects/DocumentInterests.md), [DocumentTypeEnum](../enums/DocumentTypeEnum.md), [DraftingStandard](../objects/DraftingStandard.md), [File](../objects/File.md), [HealthStatusEnum](../enums/HealthStatusEnum.md), [HighlightSet](../objects/HighlightSet.md), [IPictureDisp](../objects/IPictureDisp.md), [LocationTypeEnum](../enums/LocationTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PropertySets](../objects/PropertySets.md), [ReferenceKeyManager](../objects/ReferenceKeyManager.md), [ReferencedOLEFileDescriptors](../objects/ReferencedOLEFileDescriptors.md), [ReferencedOpaqueFileDescriptors](../objects/ReferencedOpaqueFileDescriptors.md), [Sheets](../objects/Sheets.md), [SoftwareVersion](../objects/SoftwareVersion.md), [UnitsOfMeasure](../objects/UnitsOfMeasure.md)

