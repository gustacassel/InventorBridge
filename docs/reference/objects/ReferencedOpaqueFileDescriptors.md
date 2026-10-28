# ReferencedOpaqueFileDescriptors

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.ReferencedOpaqueFileDescriptors`

```csharp
interface ReferencedOpaqueFileDescriptors
{
    // Properties
    object Application { get; }
    int Count { get; }
    ReferencedOpaqueFileDescriptor Item[int Index] { get; }
    ReferencedOpaqueFileDescriptor ItemByName[string Name] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ReferencedOpaqueFileDescriptor Add(string FullFileName);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).ReferencedOpaqueFileDescriptors, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).ReferencedOpaqueFileDescriptors, [AssemblyDocument](../objects/AssemblyDocument.md).ReferencedOpaqueFileDescriptors, [Document](../objects/Document.md).ReferencedOpaqueFileDescriptors, [DrawingDocument](../objects/DrawingDocument.md).ReferencedOpaqueFileDescriptors, [PartDocument](../objects/PartDocument.md).ReferencedOpaqueFileDescriptors, [PresentationDocument](../objects/PresentationDocument.md).ReferencedOpaqueFileDescriptors

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ReferencedOpaqueFileDescriptor](../objects/ReferencedOpaqueFileDescriptor.md)

