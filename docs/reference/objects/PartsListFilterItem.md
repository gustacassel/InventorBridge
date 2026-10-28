# PartsListFilterItem

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.PartsLists.Item[…].FilterSettings.Item[…]`

```csharp
interface PartsListFilterItem
{
    // Properties
    object Application { get; }
    bool Enabled { get; set; }
    PartsListFilterItemTypeEnum FilterItemType { get; }
    NameValueMap Options { get; set; }
    PartsListFilterSettings Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [PartsListFilterSettings](../objects/PartsListFilterSettings.md).Add, [PartsListFilterSettings](../objects/PartsListFilterSettings.md).Item

**Referenced types:** [NameValueMap](../objects/NameValueMap.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartsListFilterItemTypeEnum](../enums/PartsListFilterItemTypeEnum.md), [PartsListFilterSettings](../objects/PartsListFilterSettings.md)

