# TransientObjects

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientObjects`

```csharp
interface TransientObjects
{
    // Methods
    Camera CreateCamera();
    Color CreateColor(byte Red, byte Green, byte Blue, double Opacity = 1);
    DataMedium CreateDataMedium();
    EdgeCollection CreateEdgeCollection(object ObjectsEnumerator = Missing);
    FaceCollection CreateFaceCollection(object ObjectsEnumerator = Missing);
    FileMetadata CreateFileMetadata(object FullFileName = Missing);
    NameValueMap CreateNameValueMap();
    ObjectCollection CreateObjectCollection(object ObjectsEnumerator = Missing);
    ObjectCollectionByVariant CreateObjectCollectionByVariant(object ObjectsEnumeratorByVariant = Missing);
    string CreateSignatureString(string StringToSign);
    TranslationContext CreateTranslationContext();
}
```

**Returned by:** [Application](../objects/Application.md).TransientObjects, [ApprenticeServer](../objects/ApprenticeServer.md).TransientObjects, [ApprenticeServerComponent](../objects/ApprenticeServerComponent.md).TransientObjects, [InventorServer](../objects/InventorServer.md).TransientObjects

**Referenced types:** [Camera](../objects/Camera.md), [Color](../objects/Color.md), [DataMedium](../objects/DataMedium.md), [EdgeCollection](../objects/EdgeCollection.md), [FaceCollection](../objects/FaceCollection.md), [FileMetadata](../objects/FileMetadata.md), [NameValueMap](../objects/NameValueMap.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectCollectionByVariant](../objects/ObjectCollectionByVariant.md), [TranslationContext](../objects/TranslationContext.md)

