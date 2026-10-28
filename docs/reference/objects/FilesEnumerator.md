# FilesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.FileManager.Files`

```csharp
interface FilesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    File Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [File](../objects/File.md).AllReferencedFiles, [File](../objects/File.md).ReferencedFiles, [File](../objects/File.md).ReferencingFiles, [FileManager](../objects/FileManager.md).Files

**Referenced types:** [File](../objects/File.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

