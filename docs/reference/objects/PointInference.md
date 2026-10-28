# PointInference

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.CommandManager.CreateInteractionEvents(…).MouseEvents.PointInferences.Item[…]`

```csharp
interface PointInference
{
    // Properties
    object Application { get; }
    ObjectsEnumerator Entity { get; }
    PointInferenceEnum InferenceType { get; }
    ObjectTypeEnum Type { get; }
}
```

**Returned by:** [PointInferenceEnumerator](../objects/PointInferenceEnumerator.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [ObjectsEnumerator](../objects/ObjectsEnumerator.md), [PointInferenceEnum](../enums/PointInferenceEnum.md)

