# PartsListRow

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.PartsLists.Item[…].PartsListRows.Item[…]`

```csharp
interface PartsListRow
{
    // Properties
    object Application { get; }
    bool Ballooned { get; }
    int Count { get; }
    bool Custom { get; }
    bool Expandable { get; }
    bool Expanded { get; set; }
    double Height { get; set; }
    PartsListCell Item[object Index] { get; }
    PartsList Parent { get; }
    ObjectsEnumerator ReferencedRows { get; }
    ObjectTypeEnum Type { get; }
    bool Visible { get; set; }
    // Methods
    void Remove();
    void Reposition(int TargetIndex = 0, bool InsertBefore = true);
    void SaveItemOverridesToBOM();
}
```

2 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartsListRows](../objects/PartsListRows.md).Add, [PartsListRows](../objects/PartsListRows.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [PartsList](../objects/PartsList.md), [PartsListCell](../objects/PartsListCell.md)

