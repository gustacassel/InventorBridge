# PointInferenceEnumerator

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CreateInteractionEvents(…).MouseEvents.PointInferences`

```csharp
interface PointInferenceEnumerator
{
    // Properties
    int Count { get; }
    PointInference Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [MouseEvents](../objects/MouseEvents.md).PointInferences

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [PointInference](../objects/PointInference.md)

