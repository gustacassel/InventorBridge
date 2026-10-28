# SelectionPreferences

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.SelectionPreferences`

```csharp
interface SelectionPreferences
{
    // Properties
    object Application { get; }
    int Count { get; }
    ObjectTypeEnum Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(ObjectTypeEnum Type, object Index = Missing);
    void Clear();
    void Remove(int Index);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).SelectionPreferences, [Document](../objects/Document.md).SelectionPreferences, [DrawingDocument](../objects/DrawingDocument.md).SelectionPreferences, [PartDocument](../objects/PartDocument.md).SelectionPreferences, [PresentationDocument](../objects/PresentationDocument.md).SelectionPreferences

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

