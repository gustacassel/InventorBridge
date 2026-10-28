# PartsListColumns

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.PartsLists.Item[…].PartsListColumns`

```csharp
interface PartsListColumns
{
    // Properties
    object Application { get; }
    int Count { get; }
    PartsListColumn Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    PartsListColumn Add(PropertyTypeEnum PropertyType, string PropertySetId = "", object PropertyIdentifier = Missing, int TargetIndex = 0, bool InsertBefore = true);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartsList](../objects/PartsList.md).PartsListColumns

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartsListColumn](../objects/PartsListColumn.md), [PropertyTypeEnum](../enums/PropertyTypeEnum.md)

