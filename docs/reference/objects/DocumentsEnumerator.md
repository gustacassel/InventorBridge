# DocumentsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.Documents.VisibleDocuments`

```csharp
interface DocumentsEnumerator
{
    // Properties
    int Count { get; }
    Document Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).AllReferencedDocuments, [AssemblyDocument](../objects/AssemblyDocument.md).FindWhereUsed, [AssemblyDocument](../objects/AssemblyDocument.md).ReferencedDocuments, [AssemblyDocument](../objects/AssemblyDocument.md).ReferencingDocuments, [Document](../objects/Document.md).AllReferencedDocuments, [Document](../objects/Document.md).FindWhereUsed, [Document](../objects/Document.md).ReferencedDocuments, [Document](../objects/Document.md).ReferencingDocuments, [Documents](../objects/Documents.md).VisibleDocuments, [DrawingDocument](../objects/DrawingDocument.md).AllReferencedDocuments, [DrawingDocument](../objects/DrawingDocument.md).FindWhereUsed, [DrawingDocument](../objects/DrawingDocument.md).ReferencedDocuments, [DrawingDocument](../objects/DrawingDocument.md).ReferencingDocuments, [PartDocument](../objects/PartDocument.md).AllReferencedDocuments, [PartDocument](../objects/PartDocument.md).FindWhereUsed, [PartDocument](../objects/PartDocument.md).ReferencedDocuments, [PartDocument](../objects/PartDocument.md).ReferencingDocuments, [PresentationDocument](../objects/PresentationDocument.md).AllReferencedDocuments, [PresentationDocument](../objects/PresentationDocument.md).FindWhereUsed, [PresentationDocument](../objects/PresentationDocument.md).ReferencedDocuments, [PresentationDocument](../objects/PresentationDocument.md).ReferencingDocuments

**Referenced types:** [Document](../objects/Document.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

