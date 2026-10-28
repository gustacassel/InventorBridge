# ReferencedOLEFileDescriptor

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.ReferencedOLEFileDescriptors.Item[…]`

```csharp
interface ReferencedOLEFileDescriptor
{
    // Properties
    object Application { get; }
    AttributeSets AttributeSets { get; }
    bool BrowserVisible { get; set; }
    string DisplayName { get; set; }
    FileDescriptor FileDescriptor { get; }
    string FullFileName { get; }
    object LastKnownFileTime { get; }
    string LogicalName { get; }
    OLEDocumentTypeEnum OLEDocumentType { get; }
    object Parent { get; }
    IntPtr ReferenceMonitoring { get; set; }
    ReferenceStatusEnum ReferenceStatus { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Activate(OLEVerbEnum Verb, out object OLEDocumentObject);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

**Returned by:** [ParameterTable](../objects/ParameterTable.md).ReferencedFileDescriptor, [ReferencedOLEFileDescriptors](../objects/ReferencedOLEFileDescriptors.md).Add, [ReferencedOLEFileDescriptors](../objects/ReferencedOLEFileDescriptors.md).Item, [ReferencedOLEFileDescriptors](../objects/ReferencedOLEFileDescriptors.md).ItemByName, [SketchImage](../objects/SketchImage.md).ReferencedFileDescriptor, [SketchImageProxy](../objects/SketchImageProxy.md).ReferencedFileDescriptor

**Referenced types:** [AttributeSets](../objects/AttributeSets.md), [FileDescriptor](../objects/FileDescriptor.md), [OLEDocumentTypeEnum](../enums/OLEDocumentTypeEnum.md), [OLEVerbEnum](../enums/OLEVerbEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferenceStatusEnum](../enums/ReferenceStatusEnum.md)

