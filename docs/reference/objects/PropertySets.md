# PropertySets

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.PropertySets`

```csharp
interface PropertySets
{
    // Properties
    int Count { get; }
    bool Dirty { get; }
    PropertySet Item[object Index] { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    PropertySet Add(string Name, object InternalName = Missing);
    void FlushToFile();
    bool PropertySetExists(string PropertySetName, out object PropertySet = Missing);
    void RefreshFromFile();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).FilePropertySets, [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).PropertySets, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).FilePropertySets, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).PropertySets, [AssemblyDocument](../objects/AssemblyDocument.md).FilePropertySets, [AssemblyDocument](../objects/AssemblyDocument.md).PropertySets, [BOMRow](../objects/BOMRow.md).OccurrencePropertySets, [ComponentOccurrence](../objects/ComponentOccurrence.md).OccurrencePropertySets, [ComponentOccurrenceProxy](../objects/ComponentOccurrenceProxy.md).OccurrencePropertySets, [Document](../objects/Document.md).FilePropertySets, [Document](../objects/Document.md).PropertySets, [DrawingDocument](../objects/DrawingDocument.md).FilePropertySets, [DrawingDocument](../objects/DrawingDocument.md).PropertySets, [PartDocument](../objects/PartDocument.md).FilePropertySets, [PartDocument](../objects/PartDocument.md).PropertySets, [PresentationDocument](../objects/PresentationDocument.md).FilePropertySets, [PresentationDocument](../objects/PresentationDocument.md).PropertySets, [PropertySet](../objects/PropertySet.md).Parent, [VirtualComponentDefinition](../objects/VirtualComponentDefinition.md).PropertySets

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PropertySet](../objects/PropertySet.md)

