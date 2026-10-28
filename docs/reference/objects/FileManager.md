# FileManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.FileManager`

```csharp
interface FileManager
{
    // Properties
    object Application { get; }
    FileManagerEvents FileManagerEvents { get; }
    object FileSystemObject { get; }
    FilesEnumerator Files { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    bool CanCADFileBeAssociativelyImported(string FullFileName);
    void CopyFile(string SourceFullFileName, string DestinationFullFileName, FileManagementEnum FileManagementOption = FileManagementEnum.kNoForceFile);
    void DeleteFile(string FullFileName, FileManagementEnum FileManagementOption = FileManagementEnum.kNoForceFile);
    string[] GetAutoCADBlockDefinitions(string FullFileName);
    string[] GetDWGDocumentReferences(object DocumentOrFileName);
    string[] GetDesignViewRepresentations(string FullFileName);
    string GetEmbeddedDocumentShortName(string FullFileName);
    CachedGraphicsStatusEnum GetExpressGraphicsStatus(string AssemblyFullFilename);
    void GetFileNameFromIdentifier(out byte[] Identifier, out string FullFileName, string AbsolutePath = "");
    string GetFullDocumentName(string FullFileName, string ModelStateName = "");
    string GetFullFileName(string FullDocumentName);
    void GetIdentifierFromFileName(string FullFileName, out byte[] Identifier, string AbsolutePath = "");
    string GetLastActiveDesignViewRepresentation(string FullFileName);
    string GetLastActiveModelState(string FullFileName);
    string GetModelStateName(string FullDocumentName);
    string[] GetModelStates(string FullFileName);
    string[] GetPositionalRepresentations(string FullFileName);
    string[] GetRFAFamilyCategories(object InCurrentLanguage = Missing); // since 2026
    int[] GetRFAFamilyCategoryIds(); // since 2026
    NameValueMap GetRevitEngineInstallationStatus(); // since 2025
    string[] GetRevitFamilyCategories(object InCurrentLanguage = Missing); // since 2026
    int[] GetRevitFamilyCategoryIds(); // since 2026
    string GetRevitFileVersionCreated(string FullFileName); // since 2026
    string[] GetSHXFontList(object BigFont = Missing);
    string GetTemplateFile(DocumentTypeEnum DocumentType, SystemOfMeasureEnum SystemOfMeasure = SystemOfMeasureEnum.kDefaultSystemOfMeasure, DraftingStandardEnum DraftingStandard = DraftingStandardEnum.kDefault_DraftingStandard, object DocumentSubType = Missing);
    string GetTemplateFileWithOptions(DocumentTypeEnum DocType, object SystemOfMeasure = Missing, object DraftingStandard = Missing, object DocumentSubType = Missing, object MoreOptions = Missing); // since 2025
    InstallationStatusEnum InstallRevitEngineVersion(string RevitEngineVersion); // since 2025
    bool IsEmbeddedDocumentPath(string FullFileName);
    bool IsFileNameValid(string FileName, out string ValidFileName);
    bool IsFutureCADFile(string FullFileName);
    bool IsInventorComponent(string FullFileName);
    bool IsInventorDWG(string FullFileName);
    void MoveFile(string SourceFullFileName, string DestinationFullFileName, FileManagementEnum FileManagementOption = FileManagementEnum.kNoForceFile);
    int ReferencedDocumentCount(string FullFileName);
    void RefreshAllDocuments();
    SoftwareVersion SoftwareVersionSaved(string FullFileName);
    bool WillOpenExpressDefault(string FullFileName);
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).FileManager, [ApprenticeServer](../objects/ApprenticeServer.md).FileManager, [ApprenticeServerComponent](../objects/ApprenticeServerComponent.md).FileManager, [InventorServer](../objects/InventorServer.md).FileManager

**Referenced types:** [DocumentTypeEnum](../enums/DocumentTypeEnum.md), [DraftingStandardEnum](../enums/DraftingStandardEnum.md), [FileManagementEnum](../enums/FileManagementEnum.md), [FileManagerEvents](../objects/FileManagerEvents.md), [FilesEnumerator](../objects/FilesEnumerator.md), [InstallationStatusEnum](../enums/InstallationStatusEnum.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SoftwareVersion](../objects/SoftwareVersion.md), [SystemOfMeasureEnum](../enums/SystemOfMeasureEnum.md)

