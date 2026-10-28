# DrawingBOMRows

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).DrawingBOMs.Item[…].DrawingBOMRows`

```csharp
interface DrawingBOMRows
{
    // Properties
    object Application { get; }
    int Count { get; }
    DrawingBOMRow Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingBOM](../objects/DrawingBOM.md).DrawingBOMRows

**Referenced types:** [DrawingBOMRow](../objects/DrawingBOMRow.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

