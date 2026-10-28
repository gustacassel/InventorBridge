# BalloonValueSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (DrawingDocument).ActiveSheet.Balloons.Item[…].BalloonValueSets.Item[…]`

```csharp
interface BalloonValueSet
{
    // Properties
    object Application { get; }
    string ItemNumber { get; }
    string OverrideValue { get; set; }
    Balloon Parent { get; }
    DrawingBOMRow ReferencedRow { get; }
    bool Static { get; set; }
    ObjectTypeEnum Type { get; }
    string Value { get; set; }
    // Methods
    void Delete();
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [BalloonValueSets](../objects/BalloonValueSets.md).Add, [BalloonValueSets](../objects/BalloonValueSets.md).Item

**Referenced types:** [Balloon](../objects/Balloon.md), [DrawingBOMRow](../objects/DrawingBOMRow.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

