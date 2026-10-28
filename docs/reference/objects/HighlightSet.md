# HighlightSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.CreateHighlightSet(…)`

```csharp
interface HighlightSet
{
    // Properties
    Color Color { get; set; }
    int Count { get; }
    object Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void AddItem(object Entity);
    void AddMultipleItems(ObjectCollection Entities);
    void Clear();
    void Delete();
    void Remove(object Index);
}
```

3 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).CreateHighlightSet, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).CreateHighlightSet, [AssemblyDocument](../objects/AssemblyDocument.md).CreateHighlightSet, [Document](../objects/Document.md).CreateHighlightSet, [DrawingDocument](../objects/DrawingDocument.md).CreateHighlightSet, [PartDocument](../objects/PartDocument.md).CreateHighlightSet, [PresentationDocument](../objects/PresentationDocument.md).CreateHighlightSet

**Referenced types:** [Color](../objects/Color.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

