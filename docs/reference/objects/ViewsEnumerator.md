# ViewsEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.Views`

```csharp
interface ViewsEnumerator
{
    // Properties
    int Count { get; }
    View Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).Views

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [View](../objects/View.md)

