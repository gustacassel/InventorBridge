# HoleTableStylesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.HoleTableStyles`

```csharp
interface HoleTableStylesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    HoleTableStyle Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingStylesManager](../objects/DrawingStylesManager.md).HoleTableStyles

**Referenced types:** [HoleTableStyle](../objects/HoleTableStyle.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

