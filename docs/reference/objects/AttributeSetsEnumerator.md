# AttributeSetsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.AttributeManager.FindAttributeSets(…)`

```csharp
interface AttributeSetsEnumerator
{
    // Properties
    int Count { get; }
    AttributeSet Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AttributeManager](../objects/AttributeManager.md).FindAttributeSets, [AttributeManager](../objects/AttributeManager.md).OpenAttributeSets

**Referenced types:** [AttributeSet](../objects/AttributeSet.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

