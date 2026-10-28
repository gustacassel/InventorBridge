# LoftSectionDimension

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.Features.LoftFeatures.Item[…].Definition.LoftSectionDimensions.Item[…]`

```csharp
interface LoftSectionDimension
{
    // Properties
    object Application { get; }
    bool IsDrivingSection { get; set; }
    double Position { get; set; }
    bool PositionAsAbsoluteDistance { get; set; }
    double Size { get; set; }
    bool SizeAsScaleFactor { get; set; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Delete();
}
```

**Returned by:** [LoftSectionDimensions](../objects/LoftSectionDimensions.md).AddDrivenSection, [LoftSectionDimensions](../objects/LoftSectionDimensions.md).AddDrivingSection, [LoftSectionDimensions](../objects/LoftSectionDimensions.md).Item

**Referenced types:** [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

