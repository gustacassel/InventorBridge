# AttributesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.AttributeManager.FindAttributes(…)`

```csharp
interface AttributesEnumerator
{
    // Properties
    int Count { get; }
    Attribute Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AttributeManager](../objects/AttributeManager.md).FindAttributes, [AttributeSet](../objects/AttributeSet.md).AddAttributes

**Referenced types:** [Attribute](../objects/Attribute.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

