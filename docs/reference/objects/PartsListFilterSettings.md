# PartsListFilterSettings

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.PartsLists.Item[…].FilterSettings`

```csharp
interface PartsListFilterSettings
{
    // Properties
    object Application { get; }
    int Count { get; }
    bool Enabled { get; set; }
    PartsListFilterItem Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    PartsListFilterItem Add(PartsListFilterItemTypeEnum PartsListFilterItemType, object Options = Missing);
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartsList](../objects/PartsList.md).FilterSettings, [PartsListFilterItem](../objects/PartsListFilterItem.md).Parent

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartsListFilterItem](../objects/PartsListFilterItem.md), [PartsListFilterItemTypeEnum](../enums/PartsListFilterItemTypeEnum.md)

