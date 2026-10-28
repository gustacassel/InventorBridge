# DocumentInterests

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.DocumentInterests`

```csharp
interface DocumentInterests
{
    // Properties
    object Application { get; }
    int Count { get; }
    DocumentInterest Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    DocumentInterest Add(string ClientId, string Name, DocumentInterestTypeEnum InterestType, int DataVersion = -1, object ClientData = Missing);
    bool HasInterest(string ClientIdOrName);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).DocumentInterests, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).DocumentInterests, [AssemblyDocument](../objects/AssemblyDocument.md).DocumentInterests, [Document](../objects/Document.md).DocumentInterests, [DrawingDocument](../objects/DrawingDocument.md).DocumentInterests, [PartDocument](../objects/PartDocument.md).DocumentInterests, [PresentationDocument](../objects/PresentationDocument.md).DocumentInterests

**Referenced types:** [DocumentInterest](../objects/DocumentInterest.md), [DocumentInterestTypeEnum](../enums/DocumentInterestTypeEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

