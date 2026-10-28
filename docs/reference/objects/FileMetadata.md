# FileMetadata

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientObjects.CreateFileMetadata(…)`

```csharp
interface FileMetadata
{
    // Properties
    BOMStructureEnum BOMStructure { get; set; }
    string DisplayName { get; set; }
    bool DisplayNameOverridden { get; set; }
    Document Document { get; set; }
    string FileName { get; set; }
    bool FileNameOverridden { get; set; }
    string FileProperties { get; set; }
    string FullFileName { get; set; }
    string TemplateFileName { get; set; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [TransientObjects](../objects/TransientObjects.md).CreateFileMetadata

**Referenced types:** [BOMStructureEnum](../enums/BOMStructureEnum.md), [Document](../objects/Document.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

