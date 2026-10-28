# Styles

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.Styles`

```csharp
interface Styles
{
    // Properties
    object Application { get; }
    int Count { get; }
    Style Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingStylesManager](../objects/DrawingStylesManager.md).Styles

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Style](../objects/Style.md)

