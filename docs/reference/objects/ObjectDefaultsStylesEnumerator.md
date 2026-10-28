# ObjectDefaultsStylesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.ObjectDefaultsStyles`

```csharp
interface ObjectDefaultsStylesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    ObjectDefaultsStyle Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingStylesManager](../objects/DrawingStylesManager.md).ObjectDefaultsStyles

**Referenced types:** [ObjectDefaultsStyle](../objects/ObjectDefaultsStyle.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

