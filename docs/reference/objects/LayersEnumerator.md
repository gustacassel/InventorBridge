# LayersEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.Layers`

```csharp
interface LayersEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    Layer Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingStylesManager](../objects/DrawingStylesManager.md).Layers

**Referenced types:** [Layer](../objects/Layer.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

