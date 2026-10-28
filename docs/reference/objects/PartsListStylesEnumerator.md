# PartsListStylesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.PartsListStyles`

```csharp
interface PartsListStylesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    PartsListStyle Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingStylesManager](../objects/DrawingStylesManager.md).PartsListStyles

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PartsListStyle](../objects/PartsListStyle.md)

