# ContentTableColumn

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ContentCenter.TreeViewTopNode.Families.Item[…].FileNameColumn`

```csharp
interface ContentTableColumn
{
    // Properties
    object Application { get; }
    ValueTypeEnum DataType { get; }
    string DisplayHeading { get; set; }
    object Expression { get; set; }
    bool HasPropertyMap { get; }
    string InternalName { get; }
    bool IsCustom { get; }
    int KeyColumnOrder { get; set; }
    ContentFamily Parent { get; }
    ObjectTypeEnum Type { get; }
    object Units { get; set; }
    // Methods
    void ClearPropertyMap();
    void GetPropertyMap(out string PropertySetId, out string PropertyIdentifier);
    void SetPropertyMap(string PropertySetId, object PropertyIdentifier);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [ContentFamily](../objects/ContentFamily.md).DesignationColumn, [ContentFamily](../objects/ContentFamily.md).FileNameColumn, [ContentTableColumns](../objects/ContentTableColumns.md).Add, [ContentTableColumns](../objects/ContentTableColumns.md).Item

**Referenced types:** [ContentFamily](../objects/ContentFamily.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ValueTypeEnum](../enums/ValueTypeEnum.md)

