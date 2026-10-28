# DocumentDescriptorsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.ReferencedDocumentDescriptors`

```csharp
interface DocumentDescriptorsEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    DocumentDescriptor Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).ReferencedDocumentDescriptors, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).ReferencedDocumentDescriptors, [AssemblyDocument](../objects/AssemblyDocument.md).ReferencedDocumentDescriptors, [Document](../objects/Document.md).ReferencedDocumentDescriptors, [DrawingDocument](../objects/DrawingDocument.md).ReferencedDocumentDescriptors, [PartDocument](../objects/PartDocument.md).ReferencedDocumentDescriptors, [PresentationDocument](../objects/PresentationDocument.md).ReferencedDocumentDescriptors

**Referenced types:** [DocumentDescriptor](../objects/DocumentDescriptor.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

