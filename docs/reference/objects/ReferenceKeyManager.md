# ReferenceKeyManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.ReferenceKeyManager`

```csharp
interface ReferenceKeyManager
{
    // Properties
    object Application { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    object BindKeyToObject(out byte[] ReferenceKey, int KeyContext = 0, out object MatchType = Missing);
    bool CanBindKeyToObject(out byte[] ReferenceKey, int KeyContext = 0, out object Object = Missing, out object Context = Missing);
    int CreateKeyContext();
    string KeyToString(out byte[] ReferenceKey);
    int LoadContextFromArray(out byte[] ContextData);
    void ReleaseKeyContext(int KeyContext);
    void SaveContextToArray(int KeyContext, out byte[] Result);
    void StringToKey(string ReferenceKeyString, out byte[] ReferenceKey);
}
```

**Returned by:** [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).ReferenceKeyManager, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).ReferenceKeyManager, [AssemblyDocument](../objects/AssemblyDocument.md).ReferenceKeyManager, [Document](../objects/Document.md).ReferenceKeyManager, [DrawingDocument](../objects/DrawingDocument.md).ReferenceKeyManager, [PartDocument](../objects/PartDocument.md).ReferenceKeyManager, [PresentationDocument](../objects/PresentationDocument.md).ReferenceKeyManager

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

