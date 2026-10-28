# FlatBendResult

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).FlatPattern.FlatBendResults.Item[…]`

```csharp
interface FlatBendResult
{
    // Properties
    double Angle { get; }
    object Application { get; }
    Bend Bend { get; }
    Edge Edge { get; }
    double InnerRadius { get; }
    string InternalName { get; }
    bool IsDirectionUp { get; }
    bool IsOnBottomFace { get; }
    FlatPattern Parent { get; }
    ObjectTypeEnum Type { get; }
    double kFactor { get; }
    // Methods
    void GetBendOrder(out int BenderOrder, out BendOrderSourceTypeEnum BendOrderSourceType);
    void SetBendOrder(int BenderOrder, bool AllowDuplicate);
}
```

**Returned by:** [FlatBendResults](../objects/FlatBendResults.md).Item

**Referenced types:** [Bend](../objects/Bend.md), [BendOrderSourceTypeEnum](../enums/BendOrderSourceTypeEnum.md), [Edge](../objects/Edge.md), [FlatPattern](../objects/FlatPattern.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

