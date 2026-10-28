# Attribute

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.AttributeSets.Item[…].Item[…]`

```csharp
interface Attribute
{
    // Properties
    string Name { get; set; }
    object Parent { get; }
    ObjectTypeEnum Type { get; }
    object Value { get; set; }
    ValueTypeEnum ValueType { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [AttributeSet](../objects/AttributeSet.md).Add, [AttributeSet](../objects/AttributeSet.md).Item, [AttributesEnumerator](../objects/AttributesEnumerator.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ValueTypeEnum](../enums/ValueTypeEnum.md)

