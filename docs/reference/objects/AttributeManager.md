# AttributeManager

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.AttributeManager`

```csharp
interface AttributeManager
{
    // Properties
    object Parent { get; }
    string RevisionId { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    AttributeSetsEnumerator FindAttributeSets(string AttributeSetName = "*", string AttributeName = "*", object AttributeValue = Missing);
    AttributesEnumerator FindAttributes(string AttributeSetName = "*", string AttributeName = "*", object AttributeValue = Missing);
    ObjectCollection FindObjects(string AttributeSetName = "*", string AttributeName = "*", object AttributeValue = Missing);
    ObjectCollection FindObjectsByPattern(string XPath);
    AttributeSetsEnumerator OpenAttributeSets(ObjectCollection Objects, string AttributeSetName);
    void PurgeAttributeSets(string AttributeSetName = "*", bool Preview = false, out object PreviewResult = Missing);
}
```

**Returned by:** [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).AttributeManager, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).AttributeManager, [AssemblyDocument](../objects/AssemblyDocument.md).AttributeManager, [Document](../objects/Document.md).AttributeManager, [DrawingDocument](../objects/DrawingDocument.md).AttributeManager, [PartDocument](../objects/PartDocument.md).AttributeManager, [PresentationDocument](../objects/PresentationDocument.md).AttributeManager

**Referenced types:** [AttributeSetsEnumerator](../objects/AttributeSetsEnumerator.md), [AttributesEnumerator](../objects/AttributesEnumerator.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

