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
    object BindKeyToObject(ref byte[] ReferenceKey, int KeyContext = 0, out object MatchType = Missing);
    bool CanBindKeyToObject(ref byte[] ReferenceKey, int KeyContext = 0, out object Object = Missing, out object Context = Missing);
    int CreateKeyContext();
    string KeyToString(ref byte[] ReferenceKey);
    int LoadContextFromArray(ref byte[] ContextData);
    void ReleaseKeyContext(int KeyContext);
    void SaveContextToArray(int KeyContext, ref byte[] Result);
    void StringToKey(string ReferenceKeyString, ref byte[] ReferenceKey);
}
```

**Returned by:** [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).ReferenceKeyManager, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).ReferenceKeyManager, [AssemblyDocument](../objects/AssemblyDocument.md).ReferenceKeyManager, [Document](../objects/Document.md).ReferenceKeyManager, [DrawingDocument](../objects/DrawingDocument.md).ReferenceKeyManager, [PartDocument](../objects/PartDocument.md).ReferenceKeyManager, [PresentationDocument](../objects/PresentationDocument.md).ReferenceKeyManager

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

