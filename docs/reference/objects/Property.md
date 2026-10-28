# Property

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.PropertySets.Item[…].Item[…]`

```csharp
interface Property
{
    // Properties
    bool Dirty { get; }
    string DisplayName { get; set; }
    string Expression { get; set; }
    string Name { get; }
    PropertySet Parent { get; }
    int PropId { get; }
    ObjectTypeEnum Type { get; }
    object Value { get; set; }
    // Methods
    void Delete();
}
```

**Returned by:** [PropertySet](../objects/PropertySet.md).Add, [PropertySet](../objects/PropertySet.md).Item, [PropertySet](../objects/PropertySet.md).ItemByPropId

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PropertySet](../objects/PropertySet.md)

