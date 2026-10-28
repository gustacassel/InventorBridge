# DrawingStandardStylesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.StandardStyles`

```csharp
interface DrawingStandardStylesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    DrawingStandardStyle Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingStylesManager](../objects/DrawingStylesManager.md).StandardStyles

**Referenced types:** [DrawingStandardStyle](../objects/DrawingStandardStyle.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

