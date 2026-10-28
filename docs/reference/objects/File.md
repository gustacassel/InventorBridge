# File

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.File`

```csharp
interface File
{
    // Properties
    FilesEnumerator AllReferencedFiles { get; }
    object Application { get; }
    object AvailableDocuments { get; }
    string DatabaseRevisionId { get; }
    int FileSaveCounter { get; }
    string FullFileName { get; set; }
    bool HasLoadedDocuments { get; }
    bool HasReferencingFiles { get; }
    string InternalName { get; }
    FileDescriptorsEnumerator ReferencedFileDescriptors { get; }
    FilesEnumerator ReferencedFiles { get; }
    FilesEnumerator ReferencingFiles { get; }
    string RevisionId { get; }
    SoftwareVersion SoftwareVersionCreated { get; }
    SoftwareVersion SoftwareVersionSaved { get; }
    ObjectTypeEnum Type { get; }
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).File, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).File, [AssemblyDocument](../objects/AssemblyDocument.md).File, [Document](../objects/Document.md).File, [DrawingDocument](../objects/DrawingDocument.md).File, [FileDescriptor](../objects/FileDescriptor.md).Parent, [FileDescriptor](../objects/FileDescriptor.md).ReferencedFile, [FilesEnumerator](../objects/FilesEnumerator.md).Item, [PartDocument](../objects/PartDocument.md).File, [PresentationDocument](../objects/PresentationDocument.md).File

**Referenced types:** [FileDescriptorsEnumerator](../objects/FileDescriptorsEnumerator.md), [FilesEnumerator](../objects/FilesEnumerator.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [SoftwareVersion](../objects/SoftwareVersion.md)

