# TransitionSymbolStylesEnumerator

Inventor API object · versions: 2025, 2026, 2027 · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.TransitionSymbolStyles`

```csharp
interface TransitionSymbolStylesEnumerator
{
    // Properties
    object Application { get; } // since 2025
    int Count { get; } // since 2025
    TransitionSymbolStyle Item[object Index] { get; } // since 2025
    ObjectTypeEnum Type { get; } // since 2025
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingStylesManager](../objects/DrawingStylesManager.md).TransitionSymbolStyles

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [TransitionSymbolStyle](../objects/TransitionSymbolStyle.md)

