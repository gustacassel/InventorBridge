# BossSets

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.RibFeatures.Item[…].Definition.BossSets`

```csharp
interface BossSets
{
    // Properties
    object Application { get; }
    int Count { get; }
    BossSet Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    BossSet Add(ObjectCollection Centers, BossTypeEnum Type, object Diameter, object Offset, object Taper);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [RibDefinition](../objects/RibDefinition.md).BossSets

**Referenced types:** [BossSet](../objects/BossSet.md), [BossTypeEnum](../enums/BossTypeEnum.md), [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

