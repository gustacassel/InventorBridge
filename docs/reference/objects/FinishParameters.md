# FinishParameters

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).Parameters.FinishParameters`

```csharp
interface FinishParameters
{
    // Properties
    int Count { get; }
    FinishParameter Item[object Value] { get; }
    ObjectTypeEnum Type { get; }
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Parameters](../objects/Parameters.md).FinishParameters

**Referenced types:** [FinishParameter](../objects/FinishParameter.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

