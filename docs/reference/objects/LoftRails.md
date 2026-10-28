# LoftRails

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.LoftFeatures.Item[…].Definition.LoftRails`

```csharp
interface LoftRails
{
    // Properties
    object Application { get; }
    int Count { get; }
    LoftRail Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    LoftRail Add(object Value, object Condition = Missing, object Impact = Missing);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [LoftDefinition](../objects/LoftDefinition.md).LoftRails

**Referenced types:** [LoftRail](../objects/LoftRail.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

