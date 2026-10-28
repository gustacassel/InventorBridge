# PositionalRepresentations

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.RepresentationsManager.PositionalRepresentations`

```csharp
interface PositionalRepresentations
{
    // Properties
    object Application { get; }
    int Count { get; }
    object ExcelWorkSheet { get; }
    PositionalRepresentation Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    PositionalRepresentation Add(string Name = "");
    void Export(string FileName, FileFormatEnum FileFormat, object Options = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [RepresentationsManager](../objects/RepresentationsManager.md).PositionalRepresentations

**Referenced types:** [FileFormatEnum](../enums/FileFormatEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PositionalRepresentation](../objects/PositionalRepresentation.md)

