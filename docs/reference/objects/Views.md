# Views

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.Views`

```csharp
interface Views
{
    // Properties
    int Count { get; }
    View Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    View Add();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).Views, [Document](../objects/Document.md).Views, [DrawingDocument](../objects/DrawingDocument.md).Views, [PartDocument](../objects/PartDocument.md).Views, [PresentationDocument](../objects/PresentationDocument.md).Views

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [View](../objects/View.md)

