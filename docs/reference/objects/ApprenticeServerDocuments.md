# ApprenticeServerDocuments

Inventor API object · versions: 2024+ · [index](../index.md)

```csharp
interface ApprenticeServerDocuments
{
    // Properties
    int Count { get; }
    ApprenticeServerDocument Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).AllReferencedDocuments, [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).FindWhereUsed, [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).ReferencedDocuments, [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).ReferencingDocuments, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).AllReferencedDocuments, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).FindWhereUsed, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).ReferencedDocuments, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).ReferencingDocuments

**Referenced types:** [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

