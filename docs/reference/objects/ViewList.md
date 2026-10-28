# ViewList

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument.NonTransactingClientGraphicsCollection.Item[…].Item[…].VisibleInViews`

```csharp
interface ViewList
{
    // Properties
    int Count { get; }
    View Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(View View);
    void Remove(View View);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [GraphicsNode](../objects/GraphicsNode.md).VisibleInViews, [GraphicsNodeProxy](../objects/GraphicsNodeProxy.md).VisibleInViews

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [View](../objects/View.md)

