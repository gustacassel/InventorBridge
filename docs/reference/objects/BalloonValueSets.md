# BalloonValueSets

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.Balloons.Item[…].BalloonValueSets`

```csharp
interface BalloonValueSets
{
    // Properties
    object Application { get; }
    int Count { get; }
    BalloonValueSet Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BalloonValueSet Add(object Component);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Balloon](../objects/Balloon.md).BalloonValueSets

**Referenced types:** [BalloonValueSet](../objects/BalloonValueSet.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

