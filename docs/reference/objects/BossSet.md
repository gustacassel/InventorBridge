# BossSet

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.RibFeatures.Item[…].Definition.BossSets.Item[…]`

```csharp
interface BossSet
{
    // Properties
    object Application { get; }
    ObjectCollection Centers { get; set; }
    object Diameter { get; set; }
    object Offset { get; set; }
    RibDefinition Parent { get; }
    object TaperAngle { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [BossSets](../objects/BossSets.md).Add, [BossSets](../objects/BossSets.md).Item

**Referenced types:** [ObjectCollection](../objects/ObjectCollection.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [RibDefinition](../objects/RibDefinition.md)

