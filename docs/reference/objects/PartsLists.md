# PartsLists

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.PartsLists`

```csharp
interface PartsLists
{
    // Properties
    object Application { get; }
    int Count { get; }
    PartsList Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    PartsList Add(object ViewOrModel, Point2d PlacementPoint, PartsListLevelEnum Level = PartsListLevelEnum.kStructured, object NumberingScheme = Missing, int NumberOfSections = 1, bool WrapLeft = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).PartsLists

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartsList](../objects/PartsList.md), [PartsListLevelEnum](../enums/PartsListLevelEnum.md), [Point2d](../objects/Point2d.md)

