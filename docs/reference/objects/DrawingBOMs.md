# DrawingBOMs

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).DrawingBOMs`

```csharp
interface DrawingBOMs
{
    // Properties
    object Application { get; }
    int Count { get; }
    DrawingBOM Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    bool IsDrawingBOMDefined(string FullFileName);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingDocument](../objects/DrawingDocument.md).DrawingBOMs

**Referenced types:** [DrawingBOM](../objects/DrawingBOM.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

