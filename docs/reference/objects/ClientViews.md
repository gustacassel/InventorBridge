# ClientViews

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.ClientViews`

```csharp
interface ClientViews
{
    // Properties
    object Application { get; }
    int Count { get; }
    ClientView Item[int Index] { get; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    ClientView Add(int HWND);
    ClientView AddBySubset(int HWND, int Left, int Top, int Width, int Height);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ApprenticeServerDocument](../objects/ApprenticeServerDocument.md).ClientViews, [ApprenticeServerDrawingDocument](../objects/ApprenticeServerDrawingDocument.md).ClientViews, [AssemblyDocument](../objects/AssemblyDocument.md).ClientViews, [ClientView](../objects/ClientView.md).Parent, [Document](../objects/Document.md).ClientViews, [DrawingDocument](../objects/DrawingDocument.md).ClientViews, [PartDocument](../objects/PartDocument.md).ClientViews, [PresentationDocument](../objects/PresentationDocument.md).ClientViews, [Sheet](../objects/Sheet.md).ClientViews

**Referenced types:** [ClientView](../objects/ClientView.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

