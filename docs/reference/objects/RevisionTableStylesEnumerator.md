# RevisionTableStylesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.RevisionTableStyles`

```csharp
interface RevisionTableStylesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    RevisionTableStyle Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingStylesManager](../objects/DrawingStylesManager.md).RevisionTableStyles

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RevisionTableStyle](../objects/RevisionTableStyle.md)

