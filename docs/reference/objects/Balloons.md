# Balloons

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.Balloons`

```csharp
interface Balloons
{
    // Properties
    object Application { get; }
    int Count { get; }
    Balloon Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    Balloon Add(ObjectCollection LeaderPoints, object VirtualComponent = Missing, object Level = Missing, object NumberingScheme = Missing, object BalloonStyle = Missing, object Layer = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [Sheet](../objects/Sheet.md).Balloons

**Referenced types:** [Balloon](../objects/Balloon.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

