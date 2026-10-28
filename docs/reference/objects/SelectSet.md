# SelectSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.SelectSet`

```csharp
interface SelectSet
{
    // Properties
    int Count { get; }
    object Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Clear();
    void Delete();
    void Remove(object Index);
    void Select(object Entity);
    void SelectMultiple(ObjectCollection Entities);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).SelectSet, [Document](../objects/Document.md).SelectSet, [DrawingDocument](../objects/DrawingDocument.md).SelectSet, [PartDocument](../objects/PartDocument.md).SelectSet, [PresentationDocument](../objects/PresentationDocument.md).SelectSet

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

