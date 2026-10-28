# AttributeSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.AttributeSets.Item[…]`

```csharp
interface AttributeSet
{
    // Properties
    bool Copy { get; set; }
    bool CopyWithOwner { get; set; }
    int Count { get; }
    DataIO DataIO { get; }
    Attribute Item[object Index] { get; }
    string Name { get; set; }
    bool NameIsUsed[string AttributeName] { get; }
    object Parent { get; }
    bool Transient { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Attribute Add(string AttributeName, ValueTypeEnum ValueType, object Value);
    AttributesEnumerator AddAttributes(ref string[] AttributeNames, ref ValueTypeEnum[] ValueTypes, ref object[] Values, bool ReplaceExisting);
    AttributeSet CopyTo(object Object, bool ReplaceExisting = false);
    void Delete();
    void GetReferenceKey(out byte[] ReferenceKey, int KeyContext = 0);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AttributeSet](../objects/AttributeSet.md).CopyTo, [AttributeSets](../objects/AttributeSets.md).Add, [AttributeSets](../objects/AttributeSets.md).AddTransient, [AttributeSets](../objects/AttributeSets.md).Item, [AttributeSetsEnumerator](../objects/AttributeSetsEnumerator.md).Item

**Referenced types:** [Attribute](../objects/Attribute.md), [AttributesEnumerator](../objects/AttributesEnumerator.md), [DataIO](../objects/DataIO.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ValueTypeEnum](../enums/ValueTypeEnum.md)

