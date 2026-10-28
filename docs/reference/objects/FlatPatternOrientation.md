# FlatPatternOrientation

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition → (SheetMetalComponentDefinition).FlatPattern.FlatPatternOrientations.Item[…]`

```csharp
interface FlatPatternOrientation
{
    // Properties
    object AlignmentAxis { get; set; }
    Parameter AlignmentRotation { get; }
    AlignmentTypeEnum AlignmentType { get; set; }
    object Application { get; }
    bool FlipAlignmentAxis { get; set; }
    bool FlipBaseFace { get; set; }
    string Name { get; set; }
    FlatPattern Parent { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void Activate();
    FlatPatternOrientation Copy(string Name = "");
    void Delete();
}
```

**Returned by:** [FlatPatternOrientation](../objects/FlatPatternOrientation.md).Copy, [FlatPatternOrientations](../objects/FlatPatternOrientations.md).ActiveFlatPatternOrientation, [FlatPatternOrientations](../objects/FlatPatternOrientations.md).Item

**Referenced types:** [AlignmentTypeEnum](../enums/AlignmentTypeEnum.md), [FlatPattern](../objects/FlatPattern.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md), [Parameter](../objects/Parameter.md)

