# EdgeSymbolStylesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.EdgeSymbolStyles`

```csharp
interface EdgeSymbolStylesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    EdgeSymbolStyle Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingStylesManager](../objects/DrawingStylesManager.md).EdgeSymbolStyles

**Referenced types:** [EdgeSymbolStyle](../objects/EdgeSymbolStyle.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

