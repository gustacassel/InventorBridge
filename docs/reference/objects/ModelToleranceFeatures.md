# ModelToleranceFeatures

Inventor API object · versions: 2024+ · [index](../index.md)

**How to get it:** `Application.ActiveDocument → (PartDocument).ComponentDefinition.ModelToleranceFeatures`

```csharp
interface ModelToleranceFeatures
{
    // Properties
    object Application { get; }
    int Count { get; }
    ModelToleranceFeature Item[object Index] { get; }
    ObjectTypeEnum Type { get; }
    // Methods
    void CreateStatusVisualization();
    ModelToleranceFeature GetToleranceFeatureFromFace(Face Face);
    void RemoveStatusVisualization();
    bool StatusVisualized();
    void UpdateStatusVisualization();
}
```

5 hidden member(s) omitted: they are obsolete or internal and should not be used.

**Returned by:** [FlatPattern](../objects/FlatPattern.md).ModelToleranceFeatures, [PartComponentDefinition](../objects/PartComponentDefinition.md).ModelToleranceFeatures, [SheetMetalComponentDefinition](../objects/SheetMetalComponentDefinition.md).ModelToleranceFeatures

**Referenced types:** [Face](../objects/Face.md), [ModelToleranceFeature](../objects/ModelToleranceFeature.md), [ObjectTypeEnum](../enums/ObjectTypeEnum.md)

