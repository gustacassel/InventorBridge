# LoftRail

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.LoftFeatures.Item[…].Definition.LoftRails.Item[…]`

```csharp
interface LoftRail
{
    // Properties
    object Application { get; }
    LoftConditionEnum Condition { get; set; }
    bool HasConditions { get; }
    Parameter Impact { get; }
    object Rail { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [LoftRails](../objects/LoftRails.md).Add, [LoftRails](../objects/LoftRails.md).Item

**Referenced types:** [LoftConditionEnum](../enums/LoftConditionEnum.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md)

