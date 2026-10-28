# MarkStylesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).MarkStyles`

```csharp
interface MarkStylesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    MarkStyle Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [PartDocument](../objects/PartDocument.md).MarkStyles

**Referenced types:** [MarkStyle](../objects/MarkStyle.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

