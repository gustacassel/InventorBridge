# ReferencedOLEFileDescriptors

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.ReferencedOLEFileDescriptors`

```csharp
interface ReferencedOLEFileDescriptors
{
    // Properties
    object Application { get; }
    int Count { get; }
    ReferencedOLEFileDescriptor Item[int Index] { get; }
    ReferencedOLEFileDescriptor ItemByName[string Name] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ReferencedOLEFileDescriptor Add(string FullFileName, OLEDocumentTypeEnum Type = OLEDocumentTypeEnum.kOLEDocumentLinkObject);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).ReferencedOLEFileDescriptors, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).ReferencedOLEFileDescriptors, [AssemblyDocument](../objects/AssemblyDocument.md).ReferencedOLEFileDescriptors, [Document](../objects/Document.md).ReferencedOLEFileDescriptors, [DrawingDocument](../objects/DrawingDocument.md).ReferencedOLEFileDescriptors, [PartDocument](../objects/PartDocument.md).ReferencedOLEFileDescriptors, [PresentationDocument](../objects/PresentationDocument.md).ReferencedOLEFileDescriptors

**Referenced types:** [OLEDocumentTypeEnum](../enums/OLEDocumentTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferencedOLEFileDescriptor](../objects/ReferencedOLEFileDescriptor.md)

