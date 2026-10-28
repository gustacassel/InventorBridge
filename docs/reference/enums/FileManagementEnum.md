# FileManagementEnum

Inventor API enum · versions: 2024+ · [index](../index.md)

```csharp
enum FileManagementEnum
{
    kNoForceFile = 0,
    kForceFile = 1,
    kDeleteFileMask = 1,
    kOverwriteExistingFile = 32,
    kOverwriteReservedFile = 64,
    kOverwriteReadOnlyFile = 128,
    kCopyFileMask = 224,
    kMoveFileMask = 225,
}
```

**Used by:** [FileManager](../objects/FileManager.md).CopyFile, [FileManager](../objects/FileManager.md).DeleteFile, [FileManager](../objects/FileManager.md).MoveFile

