# SheetFormats

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).SheetFormats`

```csharp
interface SheetFormats
{
    // Properties
    object Application { get; }
    int Count { get; }
    SheetFormat Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    SheetFormat Add(Sheet Sheet, string Name);
    SheetFormat AddWithOptions(Sheet Sheet, string Name, object Options = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingDocument](../objects/DrawingDocument.md).SheetFormats

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Sheet](../objects/Sheet.md), [SheetFormat](../objects/SheetFormat.md)

