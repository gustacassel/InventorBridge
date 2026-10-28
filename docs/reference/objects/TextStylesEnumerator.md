# TextStylesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).TextStyles`

```csharp
interface TextStylesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    TextStyle Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [AssemblyDocument](../objects/AssemblyDocument.md).TextStyles, [DrawingStylesManager](../objects/DrawingStylesManager.md).TextStyles, [PartDocument](../objects/PartDocument.md).TextStyles

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [TextStyle](../objects/TextStyle.md)

