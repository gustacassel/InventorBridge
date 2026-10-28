# LeaderStylesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).StylesManager.LeaderStyles`

```csharp
interface LeaderStylesEnumerator
{
    // Properties
    object Application { get; }
    int Count { get; }
    LeaderStyle Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [DrawingStylesManager](../objects/DrawingStylesManager.md).LeaderStyles

**Referenced types:** [LeaderStyle](../objects/LeaderStyle.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

