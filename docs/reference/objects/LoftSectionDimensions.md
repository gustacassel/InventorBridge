# LoftSectionDimensions

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.LoftFeatures.Item[…].Definition.LoftSectionDimensions`

```csharp
interface LoftSectionDimensions
{
    // Properties
    object Application { get; }
    int Count { get; }
    LoftSectionDimension Item[int Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    LoftSectionDimension AddDrivenSection(double Position, bool PositionAsAbsoluteDistance = false);
    LoftSectionDimension AddDrivingSection(double Position, double Size, bool PositionAsAbsoluteDistance = false, bool SizeAsScaleFactor = false);
}
```

1 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [LoftDefinition](../objects/LoftDefinition.md).LoftSectionDimensions

**Referenced types:** [LoftSectionDimension](../objects/LoftSectionDimension.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

