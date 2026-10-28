# Documents

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.Documents`

```csharp
interface Documents
{
    // Properties
    int Count { get; }
    Document Item[int Index] { get; }
    Document ItemByName[string FullDocumentName] { get; }
    int LoadedCount { get; }
    ObjectTypeEnum Type { get; }
    DocumentsEnumerator VisibleDocuments { get; }
    // Methods
    Document Add(DocumentTypeEnum DocumentType, string TemplateFileName = "", bool CreateVisible = true);
    Document AddWithOptions(DocumentTypeEnum DocumentType, object Options = Missing); // since 2026
    void CloseAll(bool UnreferencedOnly = false);
    Document Open(string FullDocumentName, bool OpenVisible = true);
    Document OpenWithOptions(string FullDocumentName, NameValueMap Options, bool OpenVisible = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).Documents, [InventorServer](../objects/InventorServer.md).Documents

**Referenced types:** [Document](../objects/Document.md), [DocumentTypeEnum](../enums/DocumentTypeEnum.md), [DocumentsEnumerator](../objects/DocumentsEnumerator.md), [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

