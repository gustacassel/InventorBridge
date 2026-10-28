# FileDescriptor

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.ReferencedDocumentDescriptors.Item[…].ReferencedFileDescriptor`

```csharp
interface FileDescriptor
{
    // Properties
    object Application { get; }
    int FileSaveCounter { get; }
    string FullFileName { get; }
    string LibraryName { get; }
    LocationTypeEnum LocationType { get; }
    File Parent { get; }
    bool ReferenceDisabled { get; }
    bool ReferenceInternalNameDifferent { get; }
    bool ReferenceLocationDifferent { get; }
    bool ReferenceMissing { get; }
    File ReferencedFile { get; }
    FileTypeEnum ReferencedFileType { get; }
    string RelativeFileName { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    byte[] GetCustomLogicalFileName();
    void PutCustomLogicalFileName(ref byte[] Value);
    void ReplaceReference(string FullFileName);
}
```

4 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BOMRow](../objects/BOMRow.md).ReferencedFileDescriptor, [DocumentDescriptor](../objects/DocumentDescriptor.md).ReferencedFileDescriptor, [FileDescriptorsEnumerator](../objects/FileDescriptorsEnumerator.md).Item, [ReferencedOLEFileDescriptor](../objects/ReferencedOLEFileDescriptor.md).FileDescriptor

**Referenced types:** [File](../objects/File.md), [FileTypeEnum](../enums/FileTypeEnum.md), [LocationTypeEnum](../enums/LocationTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

