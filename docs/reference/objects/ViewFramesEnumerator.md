# ViewFramesEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ViewFrames`

```csharp
interface ViewFramesEnumerator
{
    // Properties
    Application Application { get; }
    int Count { get; }
    ViewFrame Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Application](../objects/Application.md).ViewFrames

**Referenced types:** [Application](../objects/Application.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ViewFrame](../objects/ViewFrame.md)

