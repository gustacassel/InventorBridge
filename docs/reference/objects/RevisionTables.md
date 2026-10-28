# RevisionTables

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.RevisionTables`

```csharp
interface RevisionTables
{
    // Properties
    object Application { get; }
    int Count { get; }
    RevisionTable Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    RevisionTable Add(Point2d PlacementPoint);
    RevisionTable Add2(Point2d PlacementPoint, bool IsSheetScope = false, bool AutoIndex = true, bool AlphaIndex = false, string StartValue = "", object RevisionTableStyle = Missing, object Layer = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).RevisionTables

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Point2d](../objects/Point2d.md), [RevisionTable](../objects/RevisionTable.md)

