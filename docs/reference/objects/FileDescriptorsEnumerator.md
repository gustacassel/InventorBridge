# FileDescriptorsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.File.ReferencedFileDescriptors`

```csharp
interface FileDescriptorsEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    FileDescriptor Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [File](../objects/File.md).ReferencedFileDescriptors

**Referenced types:** [FileDescriptor](../objects/FileDescriptor.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

