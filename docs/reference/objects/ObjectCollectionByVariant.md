# ObjectCollectionByVariant

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.TransientObjects.CreateObjectCollectionByVariant(…)`

```csharp
interface ObjectCollectionByVariant
{
    // Properties
    int Count { get; }
    object Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Add(string StringIndex, object Object);
    void Remove(object Index);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [TransientObjects](../objects/TransientObjects.md).CreateObjectCollectionByVariant

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

